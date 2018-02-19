using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BracketSequenceDiv1
{
    public long count(string s)
    {
        var n = s.Length;
        var dp = Enumerate(n, x => new long[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                dp[i][j] = -1;
        Func<int, int, long> dfs = null;
        dfs = (l, r) =>
          {
              if (l > r) return 1;
              var ok = s[l] == '(' && s[r] == ')';
              ok |= s[l] == '[' && s[r] == ']';
              if (l + 1 == r)
              {
                  return dp[l][r] = ok ? 2 : 1;
              }


              long ret = dfs(l + 1, r);
              if (l == 0 && r == 3)
              {

              }
              if (s[l] == '(')
              {
                  for (int j = l + 1; j <= r; j++)
                  {
                      if (s[j] != ')') continue;
                      var L = dfs(l + 1, j - 1);
                      var R = dfs(j + 1, r);
                      ret += L * R;
                  }
              }
              if (s[l] == '[')
              {
                  for (int j = l + 1; j <= r; j++)
                  {
                      if (s[j] != ']') continue;
                      var L = dfs(l + 1, j - 1);
                      var R = dfs(j + 1, r);
                      ret += L * R;
                  }
              }
              return dp[l][r] = ret;
          };
        dfs(0, n - 1);
        var ans = dfs(0, n - 1);


        return dfs(0, n - 1) - 1;
    }
    private long otaku(string s)
    {
        var a = Enumerate(100, x => new long[100]);
        var n = s.Length;
        long l1, r1;
        int l, r;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                l = j;
                r = j + 1;
                a[l][r] = 0;
                if (l + 1 <= r) a[l][r] += a[l + 1][r];
                for (int m = l; m <= r; m++)
                {
                    if ((s[l] == '(' && s[m] == ')') || (s[l] == '[' && s[r] == ']'))
                    {
                        l1 = r1 = 1;
                        if (l + 1 <= m - 1) l1 += a[l + 1][m - 1];
                        if (m + 1 <= r) r1 += a[m + 1][r];
                        a[l][r] += l1 * r1;
                    }
                }
            }
        }
        return a[0][n - 1];
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
        test.ManualTest("(())");
    }
}
// CUT end
