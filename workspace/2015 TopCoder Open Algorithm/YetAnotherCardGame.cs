using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class YetAnotherCardGame
{
    public int maxCards(int[] petr, int[] snuke)
    {
        var n = petr.Length;
        Array.Sort(petr);
        Array.Sort(snuke);
        var dp = new int[2 * n + 2, 101];
        for (int i = 0; i <= 2 * n + 1; i++)
            for (int j = 0; j < 101; j++)
                dp[i, j] = -1000000;
        dp[0, 0] = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            var k = i / 2;
            if (i % 2 == 0)
            {
                for (int j = 0; j < 101; j++)
                {
                    if (dp[i, j] < 0)
                        continue;
                    dp[i + 1, j] = Math.Max(dp[i + 1, j], dp[i, j]);
                    foreach (var x in petr)
                        if (j < x)
                        {
                            dp[i + 1, x] = Math.Max(dp[i + 1, x], dp[i, j] + 1);
                        }
                }
            }
            else
            {
                for (int j = 0; j < 101; j++)
                {
                    if (dp[i, j] < 0)
                        continue;
                    dp[i + 1, j] = Math.Max(dp[i + 1, j], dp[i, j]);
                    foreach (var x in snuke)
                        if (j < x)
                        {
                            dp[i + 1, x] = Math.Max(dp[i + 1, x], dp[i, j] + 1);
                        }
                }

            }
        }
        var max = 0;
        for (int i = 0; i <= 2 * n + 1; i++)
            for (int j = 0; j < 101; j++)
                max = Math.Max(max, dp[i, j]);
        return max;
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
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
