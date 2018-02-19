using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DengklekBuildingRoads {
    public int numWays(int N, int M, int K) {
        //dp[bitmask][K][M]
        const long MOD = (long)1e9 + 7;
        var DP = new long[1 << K, M + 5];
        DP[0, 0] = 1;
        for (int pos = 0; pos < N; pos++) {
            var dp = new long[1 << K, M + 5, 2];
            for (int ii = 0; ii < 1 << K; ii++)
                for (int jj = 0; jj <= M; jj++) {
                    //if (DP[ii, jj] > 0) Debug.WriteLine($"{pos} {ii} {jj}");
                    dp[ii, jj, 0] = DP[ii, jj];
                }

            for (int pre = 0; pre < K; pre++) {//æ“ªpre”Ô–Ú
                var next = new long[1 << K, M + 5, 2];
                for (int k = 0; k <= M; k++) {
                    if (pos - K + pre < 0 && k > 0) continue;
                    for (int i = 0; i < 1 << K; i++)
                        for (int j = 0; j + k <= M; j++)
                            for (int f = 0; f < 2; f++) {
                                if (dp[i, j, f] == 0) continue;
                                var ni = i;
                                if (k % 2 == 1) ni ^= 1 << pre;
                                next[ni, j + k, (f + k) & 1] += dp[i, j, f];
                                next[ni, j + k, (f + k) & 1] %= MOD;
                            }
                }

                dp = next;
            }
            var NDP = new long[1 << K, M + 5];
            for (int i = 0; i < 1 << K; i++)
                for (int j = 0; j <= M; j++)
                    for (int k = 0; k < 2; k++) {
                        if (i % 2 == 1) continue;
                        if (dp[i, j, k] == 0) continue;
                        var ni = i;
                        if (k % 2 == 1) ni |= 1 << K;
                        ni /= 2;
                        NDP[ni, j] += dp[i, j, k];
                        NDP[ni, j] %= MOD;

                    }
            DP = NDP;
        }
        return (int)DP[0, M];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int N, int M, int K) {
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
        Test(Example1);
        Test(Example0);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
