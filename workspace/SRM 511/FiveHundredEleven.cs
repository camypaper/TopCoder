using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FiveHundredEleven
{
    public string theWinner(int[] cards)
    {
        var n = cards.Length;
        var grundy = Enumerate(512, x => new int[100]);
        for (int i = 0; i < 512; i++)
            for (int j = 0; j < 100; j++)
                grundy[i][j] = -1;
        Func<int, int, int> dfs = null;
        dfs = (mask, k) =>
          {
              if (grundy[mask][k] != -1)
                  return grundy[mask][k];
              var s = new HashSet<int>();
              if (k > 0) s.Add(dfs(mask, k - 1));
              for (int i = 0; i < n; i++)
              {
                  var x = cards[i];
                  var next = mask | x;
                  if (next == mask) continue;
                  if (next == 511) continue;
                  var cnt = 0;
                  for (int j = 0; j < n; j++)
                  {
                      if (i == j) continue;
                      var y = cards[j];
                      if ((mask | y) == mask) continue;
                      if ((next | y) == next) cnt++;
                  }
                  s.Add(dfs(next, cnt + k));
              }

              for (int i = 0; ; i++)
                  if (!s.Contains(i)) return grundy[mask][k] = i;
          };
        var ans = dfs(0, 0);
        if (ans == 0) return "Toastman";
        return "Fox Ciel";
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
