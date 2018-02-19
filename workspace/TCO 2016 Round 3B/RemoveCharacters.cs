using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RemoveCharacters
{
    public int minimalDistinct(string A, string B)
    {
        var g = new MaximumClicue(26);
        for (int i = 0; i < 26; i++)
            for (int j = i; j < 26; j++)
            {
                var s = new StringBuilder();
                var t = new StringBuilder();
                foreach (var x in A)
                    if (x == 'a' + i || x == 'a' + j) s.Append(x);
                foreach (var x in B)
                    if (x == 'a' + i || x == 'a' + j) t.Append(x);
                if (s.ToString() != t.ToString()) continue;
                g.AddEdge(i, j);
            }
        var ans = g.Get();
        return 26 - ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string A, string B)
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
#region Clique
public class MaximumClicue
{
    int N;
    long[] g;
    public MaximumClicue(int size)
    {
        N = size;
        g = new long[N];
    }
    /// <summary>
    /// é©å»ï”Ç‡ÇøÇ·ÇÒÇ∆ì¸ÇÍÇÈÇ±Ç∆
    /// </summary>
    public void AddEdge(int f, int t)
    {
        g[f] |= 1L << t;
        g[t] |= 1L << f;
    }
    public int Get()
    {
        var n = N / 2;
        var m = N - n;
        var ans = 0;
        var dp = new int[1 << n];

        for (long mask = 0; mask < 1 << n; mask++)
        {
            var ok = mask;
            var score = 0;

            for (int i = 0; i < n; i++)
            {
                if ((mask >> i & 1) == 0) { continue; }
                score++;
                ok &= g[i];
            }
            if (ok != mask) continue;
            dp[mask] = score;
        }

        //çÇë¨É[Å[É^ïœä∑
        for (int i = 0; i < n; i++)
            for (int mask = 0; mask < 1 << n; mask++)
                if ((mask >> i & 1) == 1)
                {

                    dp[mask] = Math.Max(dp[mask], dp[mask ^ (1 << i)]);
                }


        for (long mask = 0; mask < 1L << N; mask += 1L << n)
        {
            long ok = mask;
            long fmask = (1L << n) - 1;
            var score = 0;

            for (int i = n; i < N; i++)
            {
                if ((mask >> i & 1) == 0) { continue; }
                score++;
                ok &= g[i];
                fmask &= g[i];
            }
            if (ok != mask) continue;
            ans = Math.Max(ans, dp[fmask] + score);
        }
        return ans;
    }
}
#endregion