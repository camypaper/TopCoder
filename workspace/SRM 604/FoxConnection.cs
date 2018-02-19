using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxConnection
{
    public int minimalDistance(int[] A, int[] B, string haveFox)
    {
        var n = A.Length + 1;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < n - 1; i++)
        {
            G[A[i] - 1].Add(B[i] - 1);
            G[B[i] - 1].Add(A[i] - 1);
        }
        var m = haveFox.Count(x => x == 'Y');
        if (m == 0) return 0;
        var has = haveFox.Select(x => x == 'Y').ToArray();
        var min = 1000000000;
        int ZERO = 2 * m;
        for (int r = 0; r < n; r++)
        {
            Func<int, int, int[,]> dfs = null;
            dfs = (prev, cur) =>
              {
                  //Debug.WriteLine("{0} {1}", prev, cur);
                  //i個親に送って，0:非連結，1:連結
                  var ret = new int[4 * m + 1, 2];
                  for (int i = 0; i <= 4 * m; i++)
                      ret[i, 0] = ret[i, 1] = 100000000;
                  if (has[cur]) { ret[ZERO, 1] = 0; ret[ZERO + 1, 0] = 0; }
                  else { ret[ZERO, 0] = 0; ret[ZERO - 1, 1] = 0; }
                  foreach (var to in G[cur])
                  {
                      if (prev == to) continue;
                      var res = dfs(cur, to);
                      var next = new int[4 * m + 1, 2];
                      for (int i = 0; i <= 4 * m; i++)
                          next[i, 0] = next[i, 1] = 1000000000;
                      for (int i = -m; i <= m; i++)
                      {
                          for (int j = -m; j <= m; j++)
                          {
                              if (i + j < -m || m < i + j) continue;
                              next[i + j + ZERO, 0] = Math.Min(next[i + j + ZERO, 0], ret[i + ZERO, 0] + res[j + ZERO, 0] + Math.Abs(j));
                              next[i + j + ZERO, 1] = Math.Min(next[i + j + ZERO, 1], ret[i + ZERO, 1] + res[j + ZERO, 1] + Math.Abs(j));
                              next[i + j + ZERO, 1] = Math.Min(next[i + j + ZERO, 1], ret[i + ZERO, 1] + res[j + ZERO, 0] + Math.Abs(j));
                          }
                      }
                      ret = next;
                  }
                  return ret;
              };
            var ans = dfs(-1, r);
            Debug.WriteLine(ans[ZERO, 1]);
            min = Math.Min(min, ans[ZERO, 1]);
        }
        return min;
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
    }
}
// CUT end
