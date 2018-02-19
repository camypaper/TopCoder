using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int32;
public class CowsMooing
{
    public int[] getDistribution(string[] patterns)
    {
        var n = patterns.Length;
        const int MOD = 10007;
        const int L = 16 * 9 * 5 * 7;
        var a = new byte[L, 51, 50];
        foreach (var s in patterns)
        {
            var l = s.Length;
            var k = l / MathEx.GCD(l, L);
            for (int i = 0; i < L * k; i++)
                if (s[i % l] == 'M')
                    a[i % L, k, i / L]++;
        }
        var ans = new int[n + 1];
        for (int i = 0; i < L; i++)
        {
            var dp = new int[n + 2];
            dp[0] = 1;
            for (int j = 1; j <= 50; j++)
            {
                var next = new int[n + 2];
                for (int k = n; k >= 0; k--)
                    if (dp[k] != 0)
                    {
                        for (int l = 0; l < j; l++)
                            next[k + a[i, j, l]] = (next[k + a[i, j, l]] + dp[k]) % MOD;
                    }
                dp = next;
            }
            for (int k = 0; k <= n; k++)
                ans[k] = (ans[k] + dp[k]) % MOD;
        }
        var inv = (int)BigInteger.ModPow(L, MOD - 2, MOD);
        for (int i = 0; i <= n; i++)
            ans[i] = (ans[i] * inv) % MOD;
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int[] Naive_Test(string[] patterns)
    {
        return new int[] { };
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
#region gcd,lcm
static public partial class MathEx
{

    static public Number GCD(Number n, Number m)
    {
        bool f = true;
        for (; n != 0 && m != 0; f ^= true)
        {
            if (f)
                m %= n;
            else n %= m;
        }
        return n == 0 ? m : n;
    }
    static public Number LCM(Number n, Number m)
    {
        return (n / GCD(n, m)) * m;
    }
    static public Number GCD(params Number[] a)
    {
        var gcd = a[0];
        foreach (var x in a)
            gcd = GCD(gcd, x);
        return gcd;
    }

}
#endregion