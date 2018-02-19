using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;
public class LotsOfLines
{
    public long countDivisions(int A, int B)
    {
        long ans = 1;
        var dp = new long[1250, 1250];
        for (int i = 1; i < 1220; i++)
            for (int j = 1; j < 1220; j++)
            {
                if (MathEx.GCD(i, j) == 1) dp[i, j] += 1;
                dp[i, j] += dp[i - 1, j] + dp[i, j - 1] - dp[i - 1, j - 1];
            }

        for (int a = 0; a < A; a++)
            for (int b = 0; b < B; b++)
            {
                ans++;
                if (a != 0)
                    ans += 1 + dp[a, b] + dp[a, B - b - 1];
            }
        return ans;
    }

    // CUT begin
    public long Naive_Test(int A, int B)
    {
        return 0;
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
#region gcd
static public partial class MathEx
{

    static public Number GCD(Number x, Number y)
    {
        byte i = 0;
        while (x != 0 && y != 0)
        {
            if (i == 0)
                y %= x;
            else x %= y;
            i ^= 1;
        }
        return x == 0 ? y : x;
    }
}
#endregion