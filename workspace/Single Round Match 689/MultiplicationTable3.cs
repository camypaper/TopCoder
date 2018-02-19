using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MultiplicationTable3
{
    public int[] construct(int x)
    {

        var use = new int[]
        {
    1,
    2,
    2,
    3,
    3,
    3,
    4,
    4
        };
        for (int y = 1; y <= 1000; y++)
        {
            var ok = false;
            for (int n = 1; n < 20; n++)
            {
                Func<int, int[], int, int> dfs = null;
                dfs = (cur, val, sum) =>
                  {
                      if (ok) return 0;

                      if (cur == n)
                      {
                          var v = 0;
                          for (int j = 1; j < 1 << n; j++)
                          {
                              var add = 1;
                              for (int k = 0; k < n; k++)
                              {
                                  if ((j >> k & 1) == 1) add *= val[k] + 1;
                              }
                              v += add;
                          }
                          if (v == y)
                          {
                              ok = true;
                          }
                          return 0;
                      }
                      for (int i = 0; i < use.Length; i++)
                      {
                          val[cur] = i;
                          var u = sum + use[i];
                          if (u > 20) continue;
                          dfs(cur + 1, val, sum + use[i]);
                      }
                      return 0;
                  };

                dfs(0, new int[n], 0);
            }
            if (!ok) throw new Exception();
            Debug.WriteLine(y);
        }
        return new int[] { };
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
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
