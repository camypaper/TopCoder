using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TreesAnalysis
{
    public long treeSimilarity(int[] tree1, int[] tree2)
    {
        var n = tree1.Length + 1;
        var G = Enumerate(2, x => Enumerate(n, y => new List<int>()));
        for (int i = 0; i < n - 1; i++)
        {
            G[0][i].Add(tree1[i]);
            G[0][tree1[i]].Add(i);
            G[1][i].Add(tree2[i]);
            G[1][tree2[i]].Add(i);
        }
        int[] ordl = new int[n], ordr = new int[n], size = new int[n];
        {
            var ptr = 0;
            dfs(-1, 0, G[0], ref ptr, ordl, ordr, size);
        }
        long ans = 0;
        for (int e1 = 0; e1 < n - 1; e1++)
        {
            var u = e1;
            if (ordl[u] < ordl[tree1[e1]]) u = tree1[e1];

            var l = ordl[u]; var r = ordr[u];
            Func<int, int, KeyValuePair<int, int>> efs = null;
            efs = (prev, cur) =>
              {
                  var ret = 0;
                  var sz = 1;
                  if (l <= ordl[cur] && ordl[cur] < r) ret++;
                  foreach (var to in G[1][cur])
                  {
                      if (to == prev) continue;
                      var res = efs(cur, to);
                      var a = res.Key;
                      var b = res.Value - res.Key;
                      var c = size[u] - res.Key;
                      var d = n - a - b - c;
                      var max = Math.Max(a, b);
                      max = Math.Max(max, Math.Max(c, d));
                      ans += max * max;
                      ret += res.Key;
                      sz += res.Value;

                  }
                  return new KeyValuePair<int, int>(ret, sz);
              };
            efs(-1, 0);

        }
        return ans;
    }
    int dfs(int prev, int cur, List<int>[] G, ref int ptr, int[] ordl, int[] ordr, int[] size)
    {
        var ret = 1;
        ordl[cur] = ptr++;
        foreach (var to in G[cur])
        {
            if (prev == to) continue;
            ret += dfs(cur, to, G, ref ptr, ordl, ordr, size);
        }

        ordr[cur] = ptr++;
        return size[cur] = ret;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public long Naive_Test(int[] tree1, int[] tree2)
    {
        return 0;
    }

    // CUT end
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
