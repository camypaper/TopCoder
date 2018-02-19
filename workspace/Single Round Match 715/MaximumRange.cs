using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MaximumRange
{
    public int findMax(string s)
    {
        var n = s.Length;
        var max = 0;
        var dp = new bool[5500];
        dp[2800] = true;
        foreach (var c in s)
        {
            var next = new bool[5500];
            for (int i = 0; i < 5500; i++)
            {
                if (!dp[i]) continue;
                if (c == '+') next[i + 1] |= true;
                else next[i - 1] |= true;
                next[i] |= true;
            }
            dp = next;

        }
        for (int i = 0; i < 5500; i++)
        {
            if (dp[i])
            {
                max = Math.Max(max, Math.Abs(i - 2800));
            }
        }
        var otaku = Naive_Test(s);
        if (otaku != max)
        {

        }
        return max;
    }

    // CUT begin
    public int Naive_Test(string s)
    {
        var n = s.Length;
        var ans = 0;
        for (int i = 0; i <= n; i++)
        {
            int p1 = 0, m1 = 0, p2 = 0, m2 = 0;
            for (int j = 0; j < n; j++)
            {
                if (j < i)
                {
                    p1 += (s[j] == '+') ? 1 : 0;
                    m1 += (s[j] == '-') ? 1 : 0;
                }
                else
                {
                    p2 += (s[j] == '+') ? 1 : 0;
                    m2 += (s[j] == '-') ? 1 : 0;

                }
            }
            ans = Math.Max(ans, p1 - Math.Min(0, p1 - m2));
            ans = Math.Max(ans, Math.Max(0, -m1 + p2) - m1);

        }
        return ans;
    }
    int f(int a, int b)
    {
        if (a > b) { var tmp = b; b = a; a = tmp; }
        if (a > 0) a = 0;
        if (b < 0) b = 0;
        return b - a;
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
        ManualTest(new string('+', 2500), false);
        ManualTest(new string('-', 2500), false);
        for (int i = 0; i < 5; i++)
        {
            var s = new StringBuilder();
            if (i == 0)
            {
                for (int j = 0; j < 1250; j++)
                    s.Append("+-");
            }
            else
            {
                for (int j = 0; j < 2500; j++)
                    if (rand.Next() % 2 == 0) s.Append('+');
                    else s.Append('-');
            }
            ManualTest(s.ToString(), false);
        }
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
