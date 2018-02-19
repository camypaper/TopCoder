using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RandomAppleEasy
{
    public double theRed(int[] red, int[] green)
    {
        var dp = new long[600, 600];
        dp[0, 0] = 1;
        var n = red.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 500; j >= 0; j--)
            {
                for (int k = 500; k >= 0; k--)
                {
                    dp[j + red[i], k + green[i]] += dp[j, k];
                }
            }

        }
        long count = 0;
        var p = 0.0;
        for (int i = 0; i < 550; i++)
            for (int j = 0; j < 550; j++)
            {
                if (i == 0 && j == 0) continue;
                count += dp[i, j];
                p += 1.0 * dp[i, j] * i / (i + j);
            }
        IOEx.Dump(count, nameof(count));
        return p / count;
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
