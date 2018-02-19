using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DiameterOfRandomTree
{
    public double getExpectation(int[] a, int[] b)
    {
        var n = a.Length + 1;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < n - 1; i++)
        {
            var f = a[i];
            var t = b[i];
            G[f].Add(t);
            G[t].Add(f);
        }

        //cur,most,diff_to_dia
        var dp = Enumerate(n, x => Enumerate(120, y => new double[120]));
        var most = Enumerate(n, x => 0);
        Func<int, int, double[][]> dfs = null;
        dfs = (cur, prev) =>
          {
              var ret = Enumerate(120, x => new double[120]);
              ret[0][0] = 1;
              var d = 0;

              foreach (var to in G[cur])
              {
                  if (to == prev) continue;
                  var res = dfs(to, cur);
                  var nd = Math.Max(d, most[to] + 2);
                  var next = Enumerate(120, x => new double[120]);
                  for (int i = 0; i <= d; i++)
                      for (int j = 0; j <= i; j++)
                          for (int k = 0; k <= most[to]; k++)
                              for (int l = 0; l <= k; l++)
                                  for (int add = 1; add <= 2; add++)
                                  {
                                      var x = i;
                                      var y = k + add;
                                      var max = Math.Max(x, y);
                                      var dia = Math.Max(i + j, k + l);
                                      dia = Math.Max(dia, x + y);
                                      next[max][dia - max] += ret[i][j] * res[k][l] * 0.5;
                                  }


                  d += most[to] + 2;
                  ret = next;
              }
              most[cur] = d;
              return dp[cur] = ret;
          };
        var ans = 0.0;
        var pat = dfs(0, -1);
        for (int j = 0; j < pat.Length; j++)
            for (int k = 0; k < pat[j].Length; k++)
            {
                var d = j + k;
                ans += d * pat[j][k];
            }

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
        var n = 50;
        var par = new int[50];
        for (int i = 1; i < 50; i++)
        {
            par[i] = rand.Next() % i;
        }
        var a = new int[n - 1];
        var b = new int[n - 1];
        for (int i = 1; i < n; i++)
        {
            a[i - 1] = i;
            b[i - 1] = par[i];
        }
        Action hoge = () => test.ManualTest(a, b);
        test.Tests.Insert(0, hoge);

    }
}
// CUT end
