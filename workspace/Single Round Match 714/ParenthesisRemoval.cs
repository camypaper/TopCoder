using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ParenthesisRemoval
{
    const long MOD = (long)1e9 + 7;
    public int countWays(string s)
    {
        var cnt = 0;
        long ans = 1;
        foreach (var x in s)
        {
            if (x == '(') cnt++;
            else
            {
                ans *= cnt;
                ans %= MOD;
                cnt--;
            }

        }
        Debug.WriteLine(ans);
        var res = Naive_Test(s);
        Debug.WriteLine(res);
        if (ans != res)
        {

        }
        return (int)ans;
    }
    public long f(int i, int l, string s)
    {
        if (s.Length == i) return l == 0 ? 1 : 0;
        if (dp[i, l] != -1) return dp[i, l];

        long ret = 0;
        if (s[i] == '(') ret = f(i + 1, l + 1, s);
        else ret = l * f(i + 1, l - 1, s) % MOD;
        return dp[i, l] = ret;
    }
    long[,] dp = new long[2550, 2550];
    // CUT begin
    public int Naive_Test(string s)
    {
        for (int i = 0; i < 2550; i++)
            for (int j = 0; j < 2550; j++)
                dp[i, j] = -1;
        var ans = 1L;var cnt = 0L;
        foreach(var x in s)
        {
            if (x == '(') { cnt++; ans = (ans * cnt) % MOD; }
            else cnt--;
        }
        return (int)ans;
        //return (int)f(0, 0, s);
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
        var s = "((())())";

        ManualTest(s);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
