using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KingXMagicSpells
{
    public double expectedNumber(int[] ducks, int[] spellOne, int[] spellTwo, int K)
    {
        double ans = 0.0;
        var n = ducks.Length;
        var dp = Enumerate(n, x => Enumerate(K + 1, y => new double[2]));
        var rev = new int[n];
        for (int i = 0; i < n; i++)
            rev[spellTwo[i]] = i;

        for (int k = 0; k < 30; k++)
        {
            Func<int, int, int, double> dfs = null;
            for (int i = 0; i < n; i++)
                for (int j = 0; j <= K; j++)
                    for (int u = 0; u < 2; u++)
                        dp[i][j][u] = -1;
            dfs = (cur, rem, bit) =>
              {
                  if (rem == 0) return dp[cur][rem][bit] = (ducks[cur] >> k & 1) == bit ? 1.0 : 0;
                  if (dp[cur][rem][bit] >= 0) return dp[cur][rem][bit];
                  var flip = (spellOne[cur] >> k & 1);
                  var ret = 0.0;
                  ret += 0.5 * dfs(cur, rem - 1, bit ^ flip);
                  ret += 0.5 * dfs(rev[cur], rem - 1, bit);
                  return dp[cur][rem][bit] = ret;
              };
           
            ans += (1 << k) * dfs(0, K, 1);
        }
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
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
