using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearCharges
{
    public double minTime(int[] X, int[] Y)
    {
        var n = X.Length;
        var dp = Enumerate(n, x => new double[1 << n]);
        for (int i = 0; i < n; i++)
            for (int j = 1; j < 1 << n; j++)
                dp[i][j] = -100;
        var d = new double[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                long dx = X[i] - X[j];
                long dy = Y[i] - Y[j];
                d[i, j] = Math.Sqrt(dx * dx + dy * dy);
                dp[i][1 << j] = d[i, j];
            }

        Func<int, int, double> dfs = null;
        dfs = (p, godmask) =>
          {
              if (dp[p][godmask] >= -1) return dp[p][godmask];
              var ret = 1e200;
              for (int i = 0; i < n; i++)
              {
                  if ((godmask >> i & 1) == 0) continue;

                  var val = d[p, i];
                  var add = 1e200;
                  var mask = godmask ^ (1 << i);
                  for (int sub = mask; sub > 0; sub = (sub - 1) & mask)
                  {
                      {
                          var next = Math.Max(dfs(p, sub), dfs(i, mask ^ sub));
                          add = Math.Min(add, next);
                      }
                      
                  }
                  ret = Math.Min(ret, val + add);
              }

              return dp[p][godmask] = ret;
          };
        var ans = dfs(0, (1 << n) - 2);
        return ans;
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
