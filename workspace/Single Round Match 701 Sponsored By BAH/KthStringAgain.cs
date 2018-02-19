using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KthStringAgain
{
    public string getKth(string s, long k)
    {
        k--;
        var n = s.Length;
        string t = "";
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                j = 'x' - 'a';
                var sum = 0L;
                var dp = new long[n, n, 2];
                for (int l = 0; l < n; l++)
                    for (int r = 0; r < n; r++)
                        dp[l, r, 0] = dp[l, r, 1] = -1;

                var tt = t;
                tt += (char)(j + 'a');
                Func<int, int, int, int, long> dfs = null;
                dfs = (l, r, f, pos) =>
                  {
                      if (dp[l, r, f] != -1) return dp[l, r, f];
                      if (pos == i + 1) return 1;

                      long ret = 0L;

                      {
                          if (f == 0)
                          {
                              if (s[l] - 'a' == tt[pos]) ret += dfs(l + 1, r, 0, pos + 1);
                              else if (s[r] - 'a' == tt[pos]) ret += dfs(l, r - 1, 1, pos + 1);
                          }
                          else
                          {
                              if (s[l] - 'a' == tt[pos]) ret += dfs(l + 1, r, 0, pos + 1);
                              else if (s[r] - 'a' == tt[pos]) ret += dfs(l, r - 1, 1, pos + 1);
                          }
                      }
                      return dp[l, r, f] = ret;
                  };
                sum = (dfs(0, n - 1, 0, 0)) * 1L << (n - i - 1);

                if (sum < k) k -= sum;
                else { t = tt; break; }
            }
        }
        return t;
    }


    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(string s, long k)
    {
        return "";
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
