using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearKRoads
{
    public int maxHappy(int[] p, int[] a, int[] b, int K)
    {
        var n = p.Length;
        var m = a.Length;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < a.Length; i++)
        {
            G[a[i]].Add(b[i]);
            G[b[i]].Add(a[i]);
        }
        var id = Enumerate(m, x => x);
        Array.Sort(id, (l, r) =>
         {
             var u = p[a[l]] + p[b[l]];
             var v = p[a[r]] + p[b[r]];
             return v.CompareTo(u);
         });
        var max = 0;
        Func<int, int[], int, int, int> dfs = null;
        dfs = (ptr, used, cnt, sum) =>
          {
              if (ptr == m || ptr == 48 || cnt == K)
              {
                  max = Math.Max(max, sum);
                  return 0;
              }
              dfs(ptr + 1, used, cnt, sum);
              var u = a[id[ptr]];
              var v = b[id[ptr]];
              var nsum = sum;
              if (used[u] == 0) nsum += p[u];
              if (used[v] == 0) nsum += p[v];
              used[u]++; used[v]++;
              dfs(ptr + 1, used, cnt + 1, nsum);
              used[u]--;used[v]--;
              return 0;
          };
        dfs(0, new int[n], 0, 0);
        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        var n = 1000;
        var m = 999;
        var rand = new Random(0);
        var p = Enumerate(n, x => rand.Next(0, 1000));
        var a = Enumerate(n - 1, x => x);
        var b = Enumerate(n - 1, x => x + 1);
        test.ManualTest(p, a, b, 7);
    }
}
// CUT end
