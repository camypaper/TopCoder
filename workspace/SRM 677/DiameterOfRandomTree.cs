using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DiameterOfRandomTree
{
    public double getExpectation(int[] a, int[] b)
    {
        var n = a.Length + 1;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < a.Length; i++)
        {
            G[a[i]].Add(b[i]);
            G[b[i]].Add(a[i]);
        }
        var pre = 0.0;
        var E = 0.0;
        for (int d = 0; d <= 2 * n + 1; d++)
        {
            var p = f(n, G, d);
            E += d * (p - pre);

            pre = p;
        }
        return E;
    }
    double f(int n, List<int>[] G, int d)
    {
        var dp = Enumerate(n, x => new double[d + 2]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < d + 2; j++)
                dp[i][j] = -1;
        Func<int, int, int> dfs = null;
        dfs = (pre, cur) =>
          {
              var ret = new double[d + 2];
              ret[0] = 1;
              foreach (var to in G[cur])
              {
                  if (pre == to) continue;
                  dfs(cur, to);
                  var next = new double[d + 2];
                  for (int i = 0; i <= d; i++)
                      for (int j = 0; j <= d; j++)
                      {
                          for (int v = 1; v <= 2; v++)
                          {
                              if (i + j + v <= d)
                                  next[Math.Max(i, j + v)] += ret[i] * dp[to][j] * 0.5;
                          }
                      }
                  ret = next;
              }
              dp[cur] = ret;
              return 0;
          };
        dfs(-1, 0);
        var sum = 0.0;
        for (int i = 0; i <= d; i++)
            sum += dp[0][i];
        return sum;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
