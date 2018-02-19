using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class OneEntrance
{
    public int count(int[] a, int[] b, int s)
    {
        var n = a.Length + 1;
        var par = new int[n];
        for (int i = 0; i < n; i++)
            par[i] = -2;
        par[s] = s;
        var q = new Queue<int>();
        q.Enqueue(s);
        while (q.Any())
        {
            var p = q.Dequeue();
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] != p && b[i] != p) continue;
                var t = a[i] == p ? b[i] : a[i];
                if (par[t] == -2)
                {
                    par[t] = p;
                    q.Enqueue(t);
                }
            }
        }
        int ans = 0;
        var used = new bool[n];
        var P = new int[n];
        Func<int, int> dfs = null;
        dfs = k =>
          {
              if (k == n)
              {
                  var ok = true;
                  var mark = new bool[n];
                  for (int i = 0; i < n; i++)
                  {
                      if (mark[par[P[i]]]) ok = false;
                      mark[P[i]] = true;
                  }
                  if (ok) ans++;
              }
              else
              {
                  for (int i = 0; i < n; i++)
                      if (used[i]) continue;
                      else
                      {
                          P[k] = i; used[i] = true;
                          dfs(k + 1);
                          used[i] = false;
                      }
              }
              return 0;
          };
        dfs(0);
        return ans;
    }


    // CUT begin
    public int Naive_Test(int[] a, int[] b, int s)
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
