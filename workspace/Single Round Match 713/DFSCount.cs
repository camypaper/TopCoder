using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DFSCount
{
    public long count(string[] G)
    {
        var n = G.Length;
        var dp = new long[1 << n, n];
        for (int i = 0; i < 1 << n; i++)
            for (int j = 0; j < n; j++)
                dp[i, j] = -1;
        Func<int, int, long> dfs = null;
        dfs = (mask, cur) =>
          {
              //Debug.WriteLine("{0} {1}", mask, cur);
              if (dp[mask, cur] != -1) return dp[mask, cur];
              long ret = 0;
              var none = true;
              for (int i = 0; i < n; i++)
              {
                  if ((mask >> i & 1) == 1) continue;
                  if (G[cur][i] != 'Y') continue;
                  none = false;
                  var nmask = mask | 1 << i;
                  {
                      var q = new Queue<int>();
                      q.Enqueue(i);
                      while (q.Count > 0)
                      {
                          var p = q.Dequeue();
                          for (int j = 0; j < n; j++)
                          {
                              if ((nmask >> j & 1) == 1) continue;
                              if (G[p][j] != 'Y') continue;
                              nmask |= 1 << j;
                              q.Enqueue(j);
                          }

                      }
                  }
                  var x = dfs(mask | 1 << i, i);
                  var y = dfs(nmask, cur);
                  ret += x * y;
              }
              if (none) return dp[mask, cur] = 1;
              return dp[mask, cur] = ret;
          };
        long ans = 0;
        for (int i = 0; i < n; i++) ans += dfs(1 << i, i);
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(string[] G)
    {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example1);
        Test(Example0);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
