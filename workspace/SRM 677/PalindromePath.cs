using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PalindromePath
{
    public int shortestLength(int n, int[] a, int[] b, string s)
    {
        var dp = Enumerate(n, x => new int[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                dp[i][j] = (i != j) ? 100000 : 0;
        var G = new bool[n, n, 26];
        for (int i = 0; i < a.Length; i++)
        {
            var f = a[i];
            var t = b[i];
            var c = s[i] - 'a';
            G[f, t, c] = G[t, f, c] = true;
            dp[f][t] = dp[t][f] = 1;
        }
        var vis = new bool[n, n];
        Func<int, int, int> dfs = null;
        dfs = (f, t) =>
          {
              if (dp[f][t] != 100000) return dp[f][t];
              var ret = 100000;
              vis[f, t] = true;
              for (int i = 0; i < n; i++)
                  for (int j = 0; j < n; j++)
                  {
                      if (i == f || t == j) continue;
                      for (int c = 0; c < 26; c++)
                      {
                          if (G[f, i, c] && G[t, j, c] && !vis[i, j])
                          {
                              ret = Math.Min(ret, dfs(i, j) + 2);
                          }
                      }
                  }


              return dp[f][t] = ret;
          };
        var ans = dfs(0, 1);
        if (ans >= 100000) return -1;
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
