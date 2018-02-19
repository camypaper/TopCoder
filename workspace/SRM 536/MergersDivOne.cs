using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MergersDivOne
{
    public double findMaximum(int[] revenues)
    {
        Array.Sort(revenues);
        var n = revenues.Length;
        var dp = new double[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                dp[i, j] = -1000000000000;
        Func<int, int, double> dfs = null;
        dfs = (l, r) =>
          {
              if (dp[l, r] >= -1000000000) return dp[l, r];
              var max = 0.0;
              for (int i = l; i <= r; i++)
                  max += revenues[i];
              max /= r - l + 1;
              for (int i = l + 1; i <= r; i++)
              {
                  var L = dfs(l, i - 1);
                  var R = dfs(i, r);
                  max = Math.Max(max, (L + R) / 2);
              }
              Debug.WriteLine("{0} {1}:  {2}", l, r, max);
              return dp[l, r] = max;
          };
        return dfs(0, n - 1);
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
