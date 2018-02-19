using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CtuRobots
{
    public double maxDist(int B, int[] cost, int[] cap)
    {
        Array.Sort(cap, cost);
        var dp = new double[B + 1];
        for (int i = 0; i < B + 1; i++)
            dp[i] = -1000000000;
        dp[0] = 0;
        for (int i = 0; i < cost.Length; i++)
        {
            var x = cost[i];
            double C = cap[i];
            for (int j = B - x; j >= 0; j--)
            {
                if (dp[j] < -1) continue;

                dp[j + x] = Math.Max(dp[j + x], C + dp[j] / 3);
            }
        }
        return dp.Max() / 2;
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
