using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NarrowPassage2
{
    public int count(int[] size, int maxSizeSum)
    {
        var n = size.Length;
        const long MOD = 1000000007;
        Func<List<int>, long> dfs = null;
        dfs = a =>
              {
                  if (a.Count <= 1) return 1;
                  var min = a.Min();
                  var max = a.Max();
                  long ret = 0;
                  if (min + max <= maxSizeSum)
                  {
                      var b = new List<int>();
                      foreach (var x in a)
                          if (x == min) min = -1; else b.Add(x);
                      ret = a.Count * dfs(b) % MOD;

                  }
                  else
                  {
                      var b = new List<int>();
                      var c = new List<int>();
                      foreach (var x in a)
                      {
                          if (x == max) max = -1;
                          else
                          {
                              if (max >= 0) b.Add(x);
                              else c.Add(x);
                          }
                      }
                      ret = dfs(b) * dfs(c) % MOD;
                  }
                  return ret;
              };
        var ans = dfs(size.ToList());
        return (int)ans;
    }
    // CUT begin
    public int Naive_Test(int[] size, int maxSizeSum)
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
