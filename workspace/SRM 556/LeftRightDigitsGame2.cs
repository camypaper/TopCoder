using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class LeftRightDigitsGame2
{
    public string minNumber(string digits, string lowerBound)
    {
        var n = digits.Length;
        var dp = Enumerate(n, x => new string[n, n, 2, 2]);
        Func<int, int, int, int, int, string> dfs = null;
        Func<string, string, string> min = (l, r) =>
                 {
                     if (l == "$") return r;
                     if (r == "$") return l;
                     if (string.CompareOrdinal(l, r) <= 0) return l;
                     return r;
                 };
        //dp[k][l,r][p,q]=k•¶Žš–Ú‚Å[l,r]‚ðì‚é‚Æ‚«‚ÉC¶‘¤‚ª‚Å‚©‚¢‚©‚Ç‚¤‚©C‰E‘¤‚ªˆÈã‚©‚Ç‚¤‚©
        dfs = (k, l, r, p, q) =>
          {
              if (dp[k][l, r, p, q] != null) return dp[k][l, r, p, q];
              var ret = "$";
              var c = digits[k] - '0';

              if (k == 0)
              {
                  var v = lowerBound[l] - '0';
                  if (c < v)
                  {
                      if (p == 1) ret = "" + c;
                  }
                  else if (c == v)
                  {
                      if (p == 0)
                      {
                          if (q == 1) ret = "" + c;
                      }
                      else return ret = "" + c;
                  }
                  else
                      ret = "" + c;
                  return dp[k][l, r, p, q] = ret;
              }


              {
                  var v = lowerBound[l] - '0';
                  if (c < v)
                  {
                      if (p == 1)
                      {
                          var x = dfs(k - 1, l + 1, r, p, q);
                          if (x != "$") ret = c + x;
                      }
                  }
                  else if (c == v)
                  {
                      var x = dfs(k - 1, l + 1, r, p, q);
                      if (x != "$") ret = c + x;
                  }
                  else
                  {
                      var x = dfs(k - 1, l + 1, r, 1, q);
                      if (x != "$") ret = c + x;
                  }

              }
              {
                  var v = lowerBound[r] - '0';
                  if (c < v)
                  {

                      var x = dfs(k - 1, l, r - 1, p, 0);
                      if (x != "$") ret = min(ret, x + c);
                  }
                  else if (c == v)
                  {
                      var x = dfs(k - 1, l, r - 1, p, q);
                      if (x != "$") ret = min(ret, x + c);
                  }
                  else
                  {
                      var x = dfs(k - 1, l, r - 1, p, 1);
                      if (x != "$") ret = min(ret, x + c);
                  }

              }
              return dp[k][l, r, p, q] = ret;
          };
        var ans = dfs(n - 1, 0, n - 1, 0, 1);
        if (ans[0] == '$') return "";
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
