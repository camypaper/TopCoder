using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheKingsRoadsDiv2
{
    public string getAnswer(int h, int[] a, int[] b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            a[i]--;
            b[i]--;
        }
        return f(h, a, b) ? "Correct" : "Incorrect";
    }
    bool f(int h, int[] from, int[] to)
    {
        var n = (1 << h) - 1;
        for (int eid = 0; eid < n; eid++)
        {
            var G = Enumerate(n, x => new List<int>());
            var d = new int[n];

            var ok = true;
            for (int i = 0; i < n; i++)
            {
                if (eid == i) continue;
                if (from[i] == to[i]) ok = false;
                G[from[i]].Add(to[i]);
                G[to[i]].Add(from[i]);
                d[from[i]]++;
                d[to[i]]++;
            }
            if (!ok) continue;
            if (d.Count(x => x == 2) != 1) continue;



            var r = -1;
            for (int i = 0; i < n; i++)
                if (d[i] == 2) r = i;
            var s = new HashSet<int>();
            var vis = new bool[n];
            Func<int, int, int, bool> dfs = null;
            dfs = (prev, cur, val) =>
              {

                  Debug.WriteLine("{0} {1}", prev, cur);
                  vis[cur] = true;
                  var can = 0;
                  s.Add(val);
                  foreach (var next in G[cur])
                  {
                      if (vis[next]) continue;
                      can++;
                  }
                  if (can == 0) return true;
                  if (can != 2) return false;
                  can = 0;
                  foreach (var next in G[cur])
                  {
                      if (next == prev) continue;
                      dfs(cur, next, val * 2 + can);
                      can++;
                  }
                  return true;
              };

            if (dfs(-1, r, 1) == false || s.Count != n) continue;
            for (int i = 1; i <= n; i++)
                ok &= s.Contains(i);
            if (ok) return true;
        }
        return false;
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
        test.ManualTest(3, new int[] { 4, 7, 7, 1, 1, 1, 4 }, new int[] { 6, 5, 1, 7, 4, 3, 2 });
    }
}
// CUT end
