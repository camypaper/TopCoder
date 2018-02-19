using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Softmatchd2
{
    public int count(string s, string t)
    {
        var n = s.Length;
        var m = t.Length;
        var dp = Enumerate(m + 1, x => -1000000000);
        dp[0] = 0;
        Func<char, char, bool> same = (x, y) =>
          {
              if (x == 'a' || x == 'A')
              {
                  if (y == '0' || y == '1') return x == 'a';
                  else return x == 'A';
              }
              else
              {
                  if (y == '0' || y == '2') return x == 'b';
                  else return x == 'B';
              }
          };
        for (int i = 0; i < n; i++)
        {
            var next = Enumerate(m + 1, x => -1000000000);
            for (int j = 0; j <= m; j++)
            {
                if (dp[j] < 0) continue;
                for (int k = 0; k < 2; k++)
                {
                    var pat = "";
                    for (int p = j - 1, q = i - 1; p >= 0; p--, q--)
                    {
                        if (same(s[q], t[p])) pat = s[q] + pat;
                        else pat = char.ToUpper(s[q]) + pat;
                    }

                    if (k == 0) pat += s[i];
                    else pat += char.ToUpper(s[i]);
                    if (i != 0 && j == 0)
                    {
                        if (same(s[i - 1], t[0])) pat = char.ToUpper(s[i - 1]) + pat;
                        else pat = s[i - 1] + pat;
                    }
                    var to = 0;
                    var v = dp[j];
                    for (int l = 0; l <= m; l++)
                    {
                        if (l > pat.Length) break;
                        var ok = true;
                        for (int p = l - 1, q = pat.Length - 1; p >= 0; p--, q--)
                            if (!same(pat[q], t[p])) ok = false;

                        if (ok)
                        {
                            to = l;
                            if (l == m) v++;
                        }
                    }
                    next[to] = Math.Max(next[to], v);
                }
            }
            dp = next;

        }
        return dp.Max();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string S, string pattern)
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
