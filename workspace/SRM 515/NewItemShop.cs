using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NewItemShop {
    public double getMaximum(int swords, string[] customers) {

        var id = Enumerate(24, x => -1);
        var cost = new int[24];
        var prob = new double[24];
        foreach (var s in customers.Select((x, i) => new { x, i })) {
            foreach (var t in s.x.Split(' ')) {
                var tt = t.Split(',');
                var time = int.Parse(tt[0]);
                var val = int.Parse(tt[1]);
                var p = int.Parse(tt[2]) / 100.0;
                id[time] = s.i;
                cost[time] = val;
                prob[time] = p;
            }
        }
        var m = customers.Length;
        var cnt = Enumerate(m, x => id.Count(y => y == x));
        var num = new int[m];
        Debug.WriteLine(cnt.AsJoinedString());
        var n = 0;
        for (int i = 0; i < m; i++) {
            num[i] = -1;
            if (cnt[i] >= 2) num[i] = n++;
        }
        Debug.WriteLine(num.AsJoinedString());
        Debug.WriteLine(n);
        var dp = new double[1 << n, swords + 1];
        for (int _ = 23; _ >= 0; _--) {
            if (id[_] == -1) continue;
            var u = id[_];
            var v = num[u];
            var c = cost[_];
            var p = prob[_];
            var q = 1.0;
            for (int j = 0; j < _; j++)
                if (id[j] == u) q -= prob[j];
            var next = new double[1 << n, swords + 1];
            for (int i = (1 << n) - 1; i >= 0; i--) {
                for (int k = swords; k > 0; k--) {
                    if (v == -1) {
                        var max = Math.Max(dp[i, k], dp[i, k - 1] + c);
                        next[i, k] = dp[i, k] * (1 - p) + max * p;
                    }
                    else {
                        var nmask = i | (1 << v);
                        if ((i >> v & 1) == 1) {
                            next[i, k] = dp[i, k];
                        }
                        else {
                            var max = Math.Max(dp[nmask, k], dp[nmask, k - 1] + c);
                            next[i, k] = dp[i, k] * (q - p) / q + max * p / q;
                        }
                    }
                }
            }
            dp = next;
        }

        return dp[0, swords];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int swords, string[] customers) {
        return 0.0;
    }

    // CUT end
}
static public class EnumerableEX {
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester {
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run() {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
