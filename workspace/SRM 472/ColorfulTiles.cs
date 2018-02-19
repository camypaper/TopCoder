using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColorfulTiles
{
    const long MOD = (long)1e9 + 7;
    public int theCount(string[] room, int K)
    {
        var n = room.Length;
        var m = room[0].Length;
        var a = Enumerate(n, x => new int[m]);
        var b = Enumerate(m, x => new int[n]);
        var s = "RGBY";
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                for (int k = 0; k < 4; k++)
                    if (room[i][j] == s[k])
                        a[i][j] = b[j][i] = k;
        if (n == 1) return f(a[0], K);
        if (m == 1) return f(b[0], K);
        var ans = g(a, K) + g(b, K);
        for (int c = 0; c < 4; c++)
            for (int d = 0; d < 4; d++)
                for (int e = 0; e < 4; e++)
                    for (int r = 0; r < 4; r++)
                    {
                        if (c == d || c == e || c == r || d == e || d == r || e == r) continue;
                        var C = new int[] { c, d, e, r };
                        var k = 0;
                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < m; j++)
                            {
                                var x = C[i % 2 + 2 * (j % 2)];
                                if (a[i][j] != x) k++;
                            }
                        if (k <= K) ans += MOD - 1;

                    }
        ans %= MOD;
        return (int)ans;
    }
    int f(int[] a, int K)
    {
        var dp = new long[4, 55];
        for (int k = 0; k < 4; k++)
        {
            var v = a[0] == k ? 0 : 1;
            dp[k, v] = 1;
        }
        for (int i = 1; i < a.Length; i++)
        {
            var next = new long[4, 55];
            for (int c = 0; c < 4; c++)
            {
                var x = a[i] == c ? 0 : 1;
                for (int pc = 0; pc < 4; pc++)
                    for (int j = 0; j <= 50; j++)
                    {
                        if (pc == c) continue;
                        next[c, j + x] += dp[pc, j];
                        next[c, j + x] %= MOD;
                    }
            }
            dp = next;
        }
        var sum = 0L;
        for (int k = 0; k < 4; k++)
            for (int i = 0; i <= K; i++)
                sum += dp[k, i];
        sum %= MOD;

        return (int)sum;
    }
    long g(int[][] a, int K)
    {
        var n = a.Length;
        var m = a[0].Length;
        var dp = new long[4, 4, K + 55];
        for (int c = 0; c < 4; c++)
            for (int d = 0; d < 4; d++)
            {
                if (c == d) continue;
                var x = 0;
                for (int i = 0; i < n; i++)
                {
                    var e = i % 2 == 0 ? c : d;
                    if (a[i][0] != e) x++;
                }
                dp[c, d, x] = 1;
            }
        for (int j = 1; j < m; j++)
        {
            var next = new long[4, 4, K + 55];
            for (int c = 0; c < 4; c++)
                for (int d = 0; d < 4; d++)
                {
                    if (c == d) continue;
                    var x = 0;
                    for (int i = 0; i < n; i++)
                    {
                        var e = i % 2 == 0 ? c : d;
                        if (a[i][j] != e) x++;
                    }
                    for (int pc = 0; pc < 4; pc++)
                        for (int pd = 0; pd < 4; pd++)
                            for (int k = 0; k <= K; k++)
                            {
                                if (pc != c && pd != c && pc != d && pd != d)
                                {
                                    next[c, d, k + x] += dp[pc, pd, k];
                                    next[c, d, k + x] %= MOD;
                                }
                            }
                }

            dp = next;
        }
        var sum = 0L;
        for (int c = 0; c < 4; c++)
            for (int d = 0; d < 4; d++)
                for (int k = 0; k <= K; k++)
                    sum += dp[c, d, k];
        return sum;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] room, int K)
    {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
