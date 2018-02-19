using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EllysNumbers {
    public long getSubsets(long n, string[] special) {
        var sb = new StringBuilder();
        foreach (var x in special) sb.Append(x);
        var a = sb.ToString().Split().Select(int.Parse).ToArray();
        Array.Sort(a);
        //Debug.WriteLine(a.AsJoinedString());
        var p = new List<long>();
        foreach (var x in a) {
            long y = x;
            for (long i = 2; i * i <= y; i++) {
                if (y % i != 0) continue;
                p.Add(i);
                while (y % i == 0) y /= i;
            }
            if (y != 1) p.Add(y);
        }
        p = p.Distinct().ToList(); p.Sort();
        //Debug.WriteLine(p.AsJoinedString());
        var m = p.Count;
        var P = new List<long>();
        var Q = new List<long>();
        for (int i = 0; i < m; i++) {
            int k = 0;
            while (n % p[i] == 0) { n /= p[i]; k++; }
            if (k != 0) { P.Add(p[i]); Q.Add(k); }
        }
        if (n != 1) return 0;
        return solve(P, Q, a);
    }
    long solve(List<long> p, List<long> q, int[] a) {

        Debug.WriteLine(p.AsJoinedString());
        Debug.WriteLine(q.AsJoinedString());
        var n = p.Count;
        var dp = new long[1 << n];
        dp[0] = 1;
        foreach (var x in a) {
            long y = x;
            var v = 0;
            var ok = true;
            for (int i = 0; i < n; i++) {
                if (y % p[i] != 0) continue;
                var k = 0;
                while (y % p[i] == 0) { y /= p[i]; k++; }
                if (k != q[i]) { ok = false; }
                else v |= 1 << i;
            }
            if (!ok || y != 1) continue;
            Debug.WriteLine(x);
            for (int i = (1 << n) - 1; i >= 0; i--) {
                if ((i & v) == 0) dp[i | v] += dp[i];
            }
        }
        return dp.Last();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(long n, string[] special) {
        return 0;
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
