using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ScoringSystems
{
    public string isEquivalent(int[] c, int[] s)
    {
        if (f(c, s)) return "Equivalent";
        return "Not Equivalent";
    }
    bool f(int[] c, int[] s)
    {
        var n = c.Length;
        Array.Sort(c, s);
        var dp = new int[10000 * 50 + 1];
        for (int i = 0; i < 10000 * 50 + 1; i++)
            dp[i] = -1;
        dp[0] = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = dp.Length - 1; j >= 0; j--)
            {
                if (dp[j] < 0) continue;
                if (dp[j + c[i]] < 0) dp[j + c[i]] = dp[j] + s[i];
                else if (dp[j + c[i]] != dp[j] + s[i]) return false;
            }
        }
        var max = -1;
        for (int i = 0; i < dp.Length; i++)
        {
            if (dp[i] < 0) continue;
            if (max >= dp[i])
                return false;
            max = dp[i];
        }
        return true;
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
