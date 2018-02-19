using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Ethernet
{
    public int connect(int[] parent, int[] dist, int d)
    {
        var n = parent.Length + 1;
        var G = Enumerate(n, x => new List<KeyValuePair<int, int>>());
        for (int i = 0; i < n - 1; i++)
        {
            G[parent[i]].Add(new KeyValuePair<int, int>(i + 1, dist[i]));
            G[i + 1].Add(new KeyValuePair<int, int>(parent[i], dist[i]));
        }
        Func<int, int, int[]> dfs = null;
        dfs = (prev, cur) =>
          {
              var ret = new int[d + 1];
              for (int i = 1; i <= d; i++)
                  ret[i] = 100000;
              foreach (var e in G[cur])
              {
                  if (e.Key == prev) continue;
                  var res = dfs(cur, e.Key);
                  var next = new int[d + 1];
                  for (int i = 0; i <= d; i++)
                      next[i] = 100000;
                  for (int i = 0; i <= d; i++)
                  {
                      if (ret[i] >= 100) continue;
                      for (int j = 0; j <= d; j++)
                      {
                          if (res[j] >= 100) continue;
                          if (i + j + e.Value > d)
                              next[i] = Math.Min(next[i], ret[i] + res[j] + 1);
                          else
                          {
                              next[Math.Max(i, j + e.Value)] = Math.Min(next[Math.Max(i, j + e.Value)], ret[i] + res[j]);
                              next[i] = Math.Min(next[i], ret[i] + res[j] + 1);
                          }
                      }
                  }
                  ret = next;
              }
              return ret;
          };
        var min = 100000;
        for (int i = 0; i < n; i++)
            min = Math.Min(min, dfs(-1, i).Min());
        return min + 1;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] parent, int[] dist, int maxDist)
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
        var p = new int[49];
        var dist = new int[49];
        var max = 500;
        for (int i = 0; i < 49; i++)
        {
            p[i] = rand.Next(0, i + 1);
            dist[i] = rand.Next(1, 120);
        }
        Tests.Add(() => ManualTest(p, dist, max));
    }
}
// CUT end
