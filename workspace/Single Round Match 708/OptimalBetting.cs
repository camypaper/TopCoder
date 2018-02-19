using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class OptimalBetting
{
    public double findProbability(int a, int b, int k)
    {
        var dp = Enumerate(2 * b + 1, x => new double[k + 1]);
        var ep = Enumerate(2 * b + 1, x => new int[k + 1]);
        for (int i = 0; i < 2 * b + 1; i++)
            for (int j = 0; j <= k; j++)
                dp[i][j] = ep[i][j] = -100;

        Func<int, int, int> canwin = null;
        canwin = (m, j) =>
          {
              if (m >= b) return 1;
              if (j == 0) return 0;
              if (ep[m][j] >= 0) return ep[m][j];
              var ret = 0;
              for (int i = 0; i <= a; i++)
                  if (canwin(m + i, j - 1) == 1) ret |= 1;
              return ep[m][j] = ret;
          };
        Func<int, int, double> dfs = null;
        dfs = (m, j) =>
        {
            if (m >= b) return 1.0;
            if (j == 0) return 1.0;
            if (dp[m][j] > -1) return dp[m][j];
            if (canwin(m, j) == 0) return 1.0;
            var ret = 0.0;
            var p = 1.0 / (m + 1);
            var ok = Math.Min(m, b - m);
            for (int i = 0; i <= m; i++)
            {
                if (j != 1 && i > ok) continue;
                if (canwin(m + i, j - 1) == 0) continue;
                ret += p * (dfs(m + i, j - 1) + dfs(m - i, j - 1)) / 2;
            }
            return dp[m][j] = ret;
        };
        return dfs(a, k);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int a, int b, int k)
    {
        return 0.0;
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
