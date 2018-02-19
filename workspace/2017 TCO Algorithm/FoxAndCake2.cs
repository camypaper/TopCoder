using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndCake2
{
    public string isPossible(int c, int s)
    {
        if (f(Math.Min(c, s), Math.Max(c, s))) return "Possible";
        else return "Impossible";
    }
    bool f(long a, long b)
    {
        if (a == 1) return false;
        var dp = new int[30, 30];
        for (int i = 0; i < 30; i++)
            for (int j = 0; j < 30; j++)
                dp[i, j] = -1;
        dp[0, 0] = 0;
        for (int i = 0; i < 30; i++)
            for (int j = 0; j < 30; j++)
            {
                if (dp[i, j] == -1) continue;
                for (int k = 1; k < 30; k++)
                    for (int l = 1; l < 30; l++)
                    {
                        if (MathEx.GCD(k, l) == 1) continue;
                        if (i + k >= 30 || j + l >= 30) continue;
                        dp[i + k, j + l] = 1;
                    }
            }
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                if (dp[i, j] == 1) Debug.WriteLine("{0} {1}", i, j);
        if (a < 30 && b < 30) return dp[a, b] == 1;
        if (a % 2 == 0)
        {
            if (b % 2 == 1)
            {
                if (a > 6) return true;
                else
                {
                    if (a == 6) return b % 3 == 0;
                    else return false;
                }
            }
            else return true;
        }
        else
        {
            if (a == 3) return b % 3 == 0;
            if (b % 2 == 0) return true;
            else return true;
        }
    }

    // CUT begin
    public string Naive_Test(int c, int s)
    {
        if (g(c, s)) return "Possible";
        else return "Impossible";
    }
    bool g(int a, int b)
    {
        return false;
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);

    }
}
// CUT end
#region gcd,lcm
static public partial class MathEx
{
    static public int GCD(int n, int m) { return (int)GCD((long)n, m); }
    static public long GCD(long n, long m)
    {
        if (Math.Sign(n) != Math.Sign(m))
        {
            n = Math.Abs(n); m = Math.Abs(m);
        }
        while (n != 0)
        {
            m %= n;
            if (m == 0) return n;
            n %= m;
        }
        return m;
    }

}
#endregion