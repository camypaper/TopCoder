using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SingingEasy
{
    public int solve(int[] pitch)
    {
        var n = pitch.Length;
        if (n <= 2) return 0;
        var dp = Enumerate(n + 1, x => 1L << 40);
        dp[0] = 0;
        dp[n] = 0;
        for (int i = 1; i < pitch.Length; i++)
        {
            var next = Enumerate(n + 1, x => 1L << 40);
            for (int j = 0; j <= n; j++)
            {
                if (dp[j] >= 1L << 40) continue;
                if (j == n) next[i - 1] = Math.Min(next[i - 1], dp[n]);
                else next[i - 1] = Math.Min(next[i - 1], dp[j] + Math.Abs(pitch[i] - pitch[j]));

                next[j] = Math.Min(next[j], dp[j] + Math.Abs(pitch[i] - pitch[i - 1]));
            }

            dp = next;
        }
        return (int)(dp.Min());
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int Naive_Test(int[] pitch)
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
