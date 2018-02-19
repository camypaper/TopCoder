using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheProgrammingContestDivOne
{
    public int find(int T, int[] maxPoints, int[] pointsPerMinute, int[] requiredTime)
    {
        var n = maxPoints.Length;
        var a = Enumerate(n, i => new { x = (long)maxPoints[i], y = (long)pointsPerMinute[i], z = (long)requiredTime[i] })
            .OrderByDescending(x => 1.0 * x.y / x.z).ToArray();
        var dp = Enumerate(T + 1, x => -1000000000L);
        dp[0] = 0;
        foreach (var x in a)
        {
            for (int i = T; i >= 0; i--)
            {
                if (i + x.z > T) continue;
                dp[i + x.z] = Math.Max(dp[i + x.z], dp[i] + x.x - x.y * (i + x.z));
            }
        }
        return (int)dp.Max();
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
