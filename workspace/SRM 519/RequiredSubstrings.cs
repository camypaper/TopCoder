using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RequiredSubstrings {
    public int solve(string[] s, int C, int L) {
        var n = s.Length;
        var len = new int[n, 55, n];
        for (int i = 0; i < n; i++)
            for (int l = 0; l < 55; l++) {
                if (l > s[i].Length) continue;
                var ss = s[i].Substring(0, l);
                for (int j = 0; j < n; j++) {
                    for (int r = l; r >= 0; r--) {
                        if (r > s[j].Length) continue;
                        var tt = s[j].Substring(0, r);
                        if (ss.Substring(l - r, r) == tt) {
                            len[i, l, j] = r; break;
                        }
                    }
                }
            }
        //
        var golen = new int[n, 55, 26];
        var goid = new int[n, 55, 26];
        var goplus = new int[n, 55, 26];
        for (int i = 0; i < n; i++)
            for (int l = 0; l < 55; l++) {
                if (l > s[i].Length) continue;
                for (char c = 'a'; c <= 'z'; c++) {
                    var ss = s[i].Substring(0, l) + c;
                    var d = c - 'a';
                    for (int j = 0; j < n; j++) {
                        for (int r = l + 1; r >= 0; r--) {
                            if (r > s[j].Length) continue;
                            var tt = s[j].Substring(0, r);
                            if (ss.Substring(l + 1 - r, r) == tt) {
                                if (r == s[j].Length) goplus[i, l, d] |= 1 << j;
                                if (golen[i, l, d] < r) {
                                    golen[i, l, d] = r;
                                    goid[i, l, d] = j;
                                }
                                break;
                            }
                        }
                    }
                }


            }
        //
        // dp[i][j] = x
        // i: length
        // j: minimum index
        const long MOD = (long)1e9 + 9;
        var dp = new long[n, 55, (1 << n)];
        dp[0, 0, 0] = 1;
        for (int _ = 0; _ < L; _++) {
            var next = new long[n, 55, 1 << n];
            for (int i = 0; i < n; i++)
                for (int l = 0; l < 55; l++) for (int k = 0; k < 1 << n; k++) {
                        if (dp[i, l, k] == 0) continue;
                        //Debug.WriteLine($"{_} {i} {l} {k}: {dp[i, l, k]}");
                        for (int c = 0; c < 26; c++) {
                            var ni = goid[i, l, c];
                            var nl = golen[i, l, c];
                            var nc = k | goplus[i, l, c];
                            next[ni, nl, nc] += dp[i, l, k];
                            next[ni, nl, nc] %= MOD;
                        }
                    }
            dp = next;
        }

        long sum = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < 55; j++)
                for (int k = 0; k < 1 << n; k++) {
                    var cnt = 0;
                    for (int x = 0; x < n; x++)
                        if ((k >> x & 1) == 1) cnt++;
                    if (cnt == C) sum = (sum + dp[i, j, k]) % MOD;

                }
        return (int)sum;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] words, int C, int L) {
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
