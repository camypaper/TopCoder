using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class YetAnotherORProblem
{
    public int countSequences(long[] R)
    {
        Array.Sort(R);
        var n = R.Length;
        const long MOD = (long)1e9 + 9;
        var dp = new long[1 << n];
        dp[0] = 1;
        for (int k = 60; k >= 0; k--)
        {
            //Debug.WriteLine(1L << k);
            var next = new long[1 << n];
            for (int mask = 0; mask < 1 << n; mask++)
                for (int i = 0; i <= n; i++)
                {
                    if (i == n || (mask >> i & 1) == 1 || (R[i] >> k & 1) == 1)
                    {
                        var nmask = mask;
                        for (int j = 0; j < n; j++)
                            if (i != j && (mask >> j & 1) == 0 && (R[j] >> k & 1) == 1) nmask |= 1 << j;
                        next[nmask] = (next[nmask] + dp[mask]) % MOD;
                    }
                }

            dp = next;
        }
        var ans = 0L;
        foreach (var x in dp) ans = (ans + x) % MOD;
        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(long[] R)
    {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
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
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
