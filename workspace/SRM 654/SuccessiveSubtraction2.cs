using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SuccessiveSubtraction2
{
    public int[] calc(int[] a, int[] p, int[] v)
    {
        var m = p.Length;
        var ans = new int[m];
        for (int i = 0; i < m; i++)
        {
            a[p[i]] = v[i];
            ans[i] = get(a);
        }
        return ans;
    }
    int get(int[] a)
    {
        var n = a.Length;
        var dp = Enumerate(n + 1, x => new int[6]);
        for (int k = 0; k < 6; k++)
            for (int j = 0; j < n + 1; j++)
                dp[j][k] = int.MinValue;

        dp[0][0] = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (dp[i][j] == int.MinValue) continue;

                if (i == 0) dp[i + 1][j] = dp[i][j] + a[i];
                else
                {
                    if (j % 2 == 0)
                    {
                        dp[i + 1][j] = Math.Max(dp[i + 1][j], dp[i][j] - a[i]);
                        dp[i + 1][j + 1] = Math.Max(dp[i + 1][j + 1], dp[i][j] - a[i]);
                    }
                    else
                    {
                        dp[i + 1][j] = Math.Max(dp[i + 1][j], dp[i][j] + a[i]);
                        dp[i + 1][j + 1] = Math.Max(dp[i + 1][j + 1], dp[i][j] + a[i]);
                    }
                }

            }
        }
        var max = int.MinValue;
        for (int i = 0; i < 5; i++)
            max = Math.Max(max, dp[n][i]);
        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int[] Naive_Test(int[] a, int[] p, int[] v)
    {
        return new int[] { };
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
