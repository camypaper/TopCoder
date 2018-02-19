using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TwoConvexShapes {
    public int countWays(string[] grid) {
        var n = grid.Length;
        var m = grid[0].Length;
        const long MOD = (long)1e9 + 7;
        var c = "WB";
        long ans = 0;

        for (int _ = 0; _ < 2; _++) {
            var ok = Enumerate(n, x => new bool[m + 1]);
            for (int i = 0; i < n; i++)
                for (int j = 0; j <= m; j++) {
                    ok[i][j] = true;
                    for (int jj = 0; jj < m; jj++) {
                        if (grid[i][jj] == '?') continue;
                        ok[i][j] &= (jj < i) ? grid[i][jj] == c[0] : grid[i][jj] == c[1];
                    }
                }

            var dp = new long[m + 1, 3];
            dp[0, 1] = 1;
            var first = true;
            var iter = 0;
            foreach (var s in grid) {
                var next = new long[m + 1, 3];
                for (int i = 0; i <= m; i++)
                    for (int k = 0; k < 3; k++) {
                        for (int j = 0; j <= m; j++) {
                            if (i < j && k == 2) continue;
                            if (j < i && k == 0) continue;
                            if (!ok[iter][j]) continue;
                            if (first && j == 0 && _ == 0) continue;
                            var kk = k;
                            if (j < i) kk = 0;
                            if (j > i) kk = 2;
                            if (first) kk = 1;
                            next[j, kk] += dp[i, k];
                        }
                    }
                dp = next;
                first = false;
                for (int kk = 0; kk < 3; kk++) {
                    var a = new long[m + 1];
                    for (int i = 0; i < m + 1; i++) a[i] = dp[i, kk];
                    Debug.WriteLine(a.AsJoinedString());
                }

                iter++;
            }
            c = "BW";
            for (int i = 0; i <= m; i++)
                ans += dp[i, 0] + dp[i, 1] + dp[i, 2];
            ans %= MOD;
        }

        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] grid) {
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
        Test(Example5);

    }
}
// CUT end
