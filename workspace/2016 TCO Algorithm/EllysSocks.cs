using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EllysSocks
{
    public int getDifference(int[] S, int P)
    {
        Array.Sort(S);
        var n = S.Length;
        var dp = Enumerate(n + 2, x => new int[n + 1]);
        for (int i = 0; i < n + 2; i++)
            for (int j = 0; j <= n; j++)
                dp[i][j] = int.MaxValue;
        dp[0][0] = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i + 1][j] = Math.Min(dp[i + 1][j], dp[i][j]);
                if (i < n - 1)
                    dp[i + 2][j + 1] = Math.Min(dp[i + 2][j + 1], Math.Max(dp[i][j], S[i + 1] - S[i]));
            }
        }
        return Math.Min(dp[n][P], dp[n + 1][P]);
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
