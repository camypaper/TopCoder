using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndSouvenirTheNext
{
    public string ableToSplit(int[] value)
    {
        var n = value.Length;
        var dp = new long[55 * 55];
        dp[0] = 1;
        foreach (var x in value)
        {
            for (int i = dp.Length - 1; i >= x; i--)
                dp[i] |= dp[i - x] * 2;
        }
        var sum = value.Sum();
        if (sum % 2 != 0 || n % 2 != 0 || (dp[sum / 2] >> (n / 2) & 1) == 0) return "Impossible";
        return "Possible";
    }

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
