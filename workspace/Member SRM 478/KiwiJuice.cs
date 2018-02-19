using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KiwiJuice
{
    public int theProfit(int C, int[] bottles, int[] prices)
    {
        var n = bottles.Length;
        var dp = Enumerate(1 << n, x => -1);
        Func<int, int> dfs = null;
        dfs = (mask) =>
          {
              if (dp[mask] >= 0) return dp[mask];
              //Debug.WriteLine(mask);
              var max = 0;
              {
                  var sum = 0;
                  var cnt = 0;
                  for (int i = 0; i < n; i++)
                      if ((mask >> i & 1) == 1) { sum += bottles[i]; cnt++; }
                  var score = 0;
                  score += (sum / C) * prices[C];
                  score += ((cnt * C - sum) / C) * prices[0];
                  if (sum % C > 0)
                      score += prices[sum % C];
                  max = score;
              }
              var enu = new SubMaskEnumerator(mask);
              do
              {
                  if (enu.sub == mask) continue;
                  if (enu.sub == 0) continue;
                  max = Math.Max(max, dfs(enu.sub) + dfs(mask ^ enu.sub));
              } while (enu.HasNext());
              return dp[mask] = max;
          };

        return dfs((1 << n) - 1);
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
#region SubMaskEnumerator
public class SubMaskEnumerator
{
    int mask;
    public int sub;
    public SubMaskEnumerator(int mask)
    {
        this.mask = mask;
        sub = mask;
    }
    public bool HasNext()
    {
        if (sub == 0) return false;
        sub = (sub - 1) & mask;
        return true;
    }

}
#endregion