using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Clicounting
{
    public int count(string[] gg)
    {

        var s1 = new HashSet<int>();
        var n = gg.Length;
        var g = Enumerate(n, x => new int[n]);
        var k = 0;
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                if (gg[i][j] == '1') g[i][j] = g[j][i] = 100000;
                else if (gg[i][j] == '0') g[i][j] = g[j][i] = -1;
                else
                {
                    g[i][j] = g[j][i] = k++;
                    s1.Add(i); s1.Add(j);
                }
            }
        var s2 = new List<int>();
        for (int i = 0; i < n; i++)
        {
            if (s1.Contains(i)) continue;
            else if (s1.Count * 2 < n) s1.Add(i);
            else s2.Add(i);
        }

        return f(s1.OrderBy(x => x).ToArray(), s2.ToArray(), g, k);
    }
    int f(int[] s1, int[] s2, int[][] g, int k)
    {
        /*
        var naive = new int[1 << k];
        var sum = 0;
        {
            for (int mask = 0; mask < 1 << g.Length; mask++)
            {
                var ok = true;
                var cnt = 0;
                var f = 0;
                for (int i = 0; i < g.Length; i++)
                {
                    if ((mask >> i & 1) == 0) continue;
                    cnt++;
                    for (int j = i + 1; j < g.Length; j++)
                    {
                        if ((mask >> j & 1) == 0) continue;
                        if (g[i][j] == -1) ok = false;
                        else if (g[i][j] != 100000) f |= 1 << g[i][j];
                    }
                }
                if (ok) naive[f] = Math.Max(naive[f], cnt);
            }
            for (int i = 0; i < 1 << k; i++)
                for (int j = 0; j < k; j++)
                    naive[i | (1 << j)] = Math.Max(naive[i | (1 << j)], naive[i]);
            sum += naive.Sum();
        }
        */
        var n = s1.Length;
        var dp = new int[1 << n];
        for (int mask = 0; mask < 1 << s2.Length; mask++)
        {
            var ok = true;
            var cnt = 0;
            var f = new bool[n];
            for (int i = 0; i < n; i++)
                f[i] = true;
            for (int i = 0; i < s2.Length; i++)
            {
                if ((mask >> i & 1) == 0) continue;
                cnt++;
                for (int j = i + 1; j < s2.Length; j++)
                {
                    if ((mask >> j & 1) == 0) continue;
                    if (g[s2[i]][s2[j]] == -1) { ok = false; break; }
                }
                for (int j = 0; j < s1.Length; j++)
                {
                    if (g[s2[i]][s1[j]] == -1)
                        f[j] = false;
                }
            }
            if (!ok) continue;
            var ff = 0;
            for (int i = 0; i < n; i++)
                if (f[i]) ff |= 1 << i;
            dp[ff] = Math.Max(dp[ff], cnt);
        }
        for (int i = (1 << n) - 1; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i] = Math.Max(dp[i | (1 << j)], dp[i]);
            }
        }
        Debug.WriteLine(dp.AsJoinedString());
        var dp2 = new int[1 << k];
        for (int mask = 0; mask < 1 << n; mask++)
        {
            var ok = true;
            var cnt = 0;
            var f = 0;
            for (int i = 0; i < n; i++)
            {
                if ((mask >> i & 1) == 0) continue;
                cnt++;
                for (int j = i + 1; j < n; j++)
                {
                    if ((mask >> j & 1) == 0) continue;
                    if (g[s1[i]][s1[j]] == -1) { ok = false; break; }
                    else if (g[s1[i]][s1[j]] != 100000) f |= 1 << g[s1[i]][s1[j]];
                }
            }
            if (!ok) continue;
            dp2[f] = Math.Max(dp2[f], cnt + dp[mask]);
        }
        for (int i = 0; i < 1 << k; i++)
        {
            for (int j = 0; j < k; j++)
                dp2[i | (1 << j)] = Math.Max(dp2[i | (1 << j)], dp2[i]);
        }
        Debug.WriteLine(dp2.AsJoinedString());
        return dp2.Sum();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] g)
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
    }
}
// CUT end
