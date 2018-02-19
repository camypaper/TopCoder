using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class StrangeDictionary2 {
    public double[] getProbabilities(string[] words) {
        var n = words.Length;
        var m = words[0].Length;
        var dp = new double[1 << n];
        dp[(1 << n) - 1] = 1;
        var go = Enumerate(1 << n, x => new int[m]);
        for (int i = 0; i < 1 << n; i++) {
            for (int j = 0; j < m; j++) {
                var mask = new int[26];
                for (int k = 0; k < n; k++)
                    if ((i >> k & 1) == 1) mask[words[k][j] - 'a'] |= 1 << k;
                for (int c = 0; c < 26; c++)
                    if (mask[c] != 0) {
                        go[i][j] = mask[c];
                        break;
                    }
            }
        }
        for (int K = 0; K < m; K++) {
            var rem = m - K;
            var next = new double[1 << n];
            for (int i = 1; i < 1 << n; i++) {
                if (dp[i] == 0) continue;
                Debug.WriteLine(i);
                next[i] -= K * dp[i] / rem;
                for (int j = 0; j < m; j++) {
                    next[go[i][j]] += dp[i] / rem;
                }
            }
            dp = next;
        }

        return Enumerate(n, x => dp[1 << x]);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double[] Naive_Test(string[] words) {
        return new double[] { };
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
        Test(Example1);
        Test(Example0);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
