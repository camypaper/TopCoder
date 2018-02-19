using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PieOrDolphin
{
    public int[] Distribute(int[] from, int[] to)
    {
        var d = new int[50];
        var m = from.Length;
        var ans = new int[m];
        var G = Enumerate(50, x => new List<int>());
        for (int i = 0; i < m; i++)
        {
            G[from[i]].Add(i);
            G[to[i]].Add(i);
            d[from[i]]++; d[to[i]]++;
        }
        var val = new int[50];
        Func<int, int> dfs = null;
        dfs = cur =>
          {
              while (G[cur].Count > 0)
              {
                  var id = G[cur][G[cur].Count - 1];
                  G[cur].RemoveAt(G[cur].Count - 1);
                  if (ans[id] != 0) continue;
                  var f = from[id];
                  var t = to[id];
                  if (f == cur) ans[id] = 1;
                  else { ans[id] = 2; Swap(ref f, ref t); }
                  d[f]--; d[t]--;
                  return dfs(t);
              }
              return 0;
          };
        for (int i = 0; i < 50; i++)
            if (d[i] % 2 != 0) dfs(i);
        for (int i = 0; i < 50; i++)
            if (d[i] != 0) dfs(i);
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
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


