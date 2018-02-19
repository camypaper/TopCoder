using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class OrderedProduct
{
    const long MOD = (long)1e9 + 7;
    public int count(int[] a)
    {
        var sum = a.Sum();
        var comb = Enumerate(2600, x => new long[2600]);
        comb[0][0] = 1;
        for (int i = 0; i < 2580; i++)
            for (int j = 0; j < 2580; j++)
            {
                comb[i][j] %= MOD;
                comb[i + 1][j] += comb[i][j];
                comb[i + 1][j + 1] += comb[i][j];
            }
        long ans = 0;
        var dp = new long[sum + 1];
        for (int i = 1; i <= sum; i++)
        {
            dp[i] = 1;
            foreach (var x in a)
                dp[i] = dp[i] * comb[i + x - 1][x] % MOD;
            for (int j = 1; j < i; j++)
            {
                var sub = dp[j] * comb[i][j] % MOD;
                dp[i] = (dp[i] + MOD - sub) % MOD;
            }
            ans = (ans + dp[i]) % MOD;
        }
        Debug.WriteLine(dp.AsJoinedString());
        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] a)
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
