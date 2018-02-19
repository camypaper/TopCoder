using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DistinguishableSetDiv1
{
    public int count(string[] s)
    {
        var n = s.Length;
        var m = s[0].Length;
        var ans = 1 << m;
        var dp = new bool[1 << (m + 2)];
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                var mask = 0;
                for (int k = 0; k < m; k++)
                {
                    if (s[i][k] == s[j][k]) mask |= 1 << k;
                }
                dp[mask] = true;
            }
        for (int i = (1 << m) - 1; i >= 0; i--)
        {
            if (!dp[i]) continue;
            ans--;
            for (int j = 0; j < m; j++)
            {
                if ((i >> j & 1) == 1) dp[i ^ (1 << j)] = true;
            }
        }
        return ans;
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
