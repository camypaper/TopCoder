using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RabbitAndTable
{
    public int count(int[] a)
    {
        const long MOD = (long)1e9 + 7;
        Array.Sort(a);
        var n = a.Length;
        var dp = new long[n + 50];
        dp[0] = 1;
        var cnt = new int[n + 50];
        foreach (var x in a) for (int i = 1; i <= x; i++) cnt[i]++;


        var comb = Enumerate(n + 5, x => new long[n + 5]);
        comb[0][0] = 1;
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= n; j++)
            {
                comb[i][j] %= MOD;
                comb[i + 1][j] += comb[i][j];
                comb[i + 1][j + 1] += comb[i][j];
            }


        for (int i = n; i > 0; i--)
        {
            var next = new long[n + 50];
            var v = 1L;
            for (int k = 0; k <= n; k += i)
            {
                for (int j = 0; j + k <= n; j++)
                {
                    var rem = cnt[i] - j;
                    if (rem < 0) continue;
                    var coef = v;
                    coef = coef * comb[rem][k] % MOD;
                    next[j + k] = (next[j + k] + coef * dp[j]) % MOD;
                }
                if (k + i <= n)
                    v = comb[k + i - 1][i - 1] * v % MOD;
            }

            dp = next;
        }

        return (int)dp[n];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] x)
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
