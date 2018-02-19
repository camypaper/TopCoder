using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NewCoins
{
    public int minCoins(int[] price)
    {
        var n = price.Length;
        Array.Sort(price);
        var dp = Enumerate(100050, x => -1);
        Func<int, int> dfs = null;
        dfs = (v) =>
          {
              if (dp[v] >= 0) return dp[v];
              var ret = 0;
              foreach (var x in price)
                  ret += x / v;
              for (int next = v + v; next < 100050; next += v)
              {
                  var val = dfs(next);
                  foreach (var x in price)
                  {
                      val += (x % next) / v;
                  }
                  ret = Math.Min(ret, val);
              }


              return dp[v] = ret;
          };
        return dfs(1);
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
