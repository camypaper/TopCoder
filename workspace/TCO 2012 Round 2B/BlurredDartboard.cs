using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BlurredDartboard
{
    public int minThrows(int[] points, int P)
    {
        var v = points.Max();
        var a = Enumerable.Range(1, points.Length).Except(points).OrderBy(x => x).ToArray();
        var n = a.Length;

        var cum = new int[n + 1];
        for (int i = 0; i < n; i++)
            cum[i + 1] = cum[i] + a[i];

        var dp = new int[100000];
        for (int i = 1; i < 100000; i++)
            dp[i] = 50000000;
        if (v > 0)
        {
            for (int i = v; i < 100000; i++)
                dp[i] = Math.Min(dp[i], dp[i - v] + 1);
        }
        for (int i = 1; i <= n; i++)
        {
            for (int j = 100000 - 1; j >= cum[i]; j--)
            {
                dp[j] = Math.Min(dp[j], dp[j - cum[i]] + i);
            }
        }
        var min = 1 << 30;
        var MAX = Math.Min(99999, P);
        for (int i = 0; i <= MAX; i++)
        {
            var rem = P - i;
            if (v > 0) min = Math.Min(min, dp[i] + (rem + v - 1) / v);
            for (int j = 1; j <= n; j++)
            {
                min = Math.Min(min, dp[i] + ((rem + cum[j] - 1) / cum[j]) * j);
            }
        }
        return min;
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
        test.ManualTest(new int[] { 1, 2, }, 1);
    }
}
// CUT end
