using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CandidatesSelection
{
    public string possible(string[] score, int[] Q)
    {
        var n = score.Length;
        var m = score[0].Length;
        var ss = Enumerate(n, x => new int[m]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                ss[i][j] = score[i][j] - 'A';
        return f(ss, Q) ? "Possible" : "Impossible";
    }
    bool f(int[][] score, int[] Q)
    {
        var n = score.Length;
        var m = score[0].Length;
        Func<List<List<int>>, bool> dfs = null;
        dfs = qs =>
          {
              //Debug.WriteLine(string.Join("|", qs.Select(x => x.AsJoinedString())));

              //check
              {
                  var ok = true;
                  foreach (var p in qs)
                  {
                      for (int i = 1; i < p.Count; i++)
                          ok &= p[i] > p[i - 1];
                  }
                  if (ok) return true;
              }
              for (int id = 0; id < m; id++)
              {
                  var ok = true;
                  var good = false;
                  foreach (var p in qs)
                  {
                      for (int i = 1; i < p.Count; i++)
                      {
                          ok &= score[p[i]][id] >= score[p[i - 1]][id];
                          good |= score[p[i]][id] > score[p[i - 1]][id];
                      }
                  }
                  if (!ok) continue;
                  if (!good) continue;
                  var nqs = new List<List<int>>();
                  foreach (var p in qs)
                  {
                      var nl = new List<int>() { p[0] };
                      var v = score[p[0]][id];
                      for (int i = 1; i < p.Count; i++)
                      {
                          if (v == score[p[i]][id]) nl.Add(p[i]);
                          else
                          {
                              if (nl.Count > 0)
                                  nqs.Add(nl);
                              nl = new List<int>() { p[i] };
                              v = score[p[i]][id];
                          }
                      }
                      if (nl.Count > 0) nqs.Add(nl);
                  }
                  return dfs(nqs);
              }

              return false;
          };
        return dfs(new List<List<int>>() { Q.ToList() });
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
