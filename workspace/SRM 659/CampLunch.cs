using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CampLunch
{
    public int count(int N, int M, string[] a)
    {
        var p = Enumerate(N, x => new int[M]);
        var q = Enumerate(N, x => new int[M]);
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
                p[i][j] = a[i][j] - 'A';
            for (int j = 0; j < M; j++)
                q[i][p[i][j]] = j;
        }
        var ans = f(N, M, p, q);
        return (int)ans.num;
    }
    public ModInteger f(int K, int n, int[][] cur, int[][] per)
    {
        foreach (var x in cur)
            IOEx.Dump(x, nameof(x));
        var dp = Enumerate(K * n + 2, x => new ModInteger[1 << n]);
        dp[0][0] = 1;
        for (int k = 0; k < K; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int mask = 0; mask < 1 << n; mask++)
                {
                    if ((mask >> i & 1) == 1)
                    {
                        dp[k * n + i + 1][mask ^ (1 << i)] += dp[k * n + i][mask];
                    }
                    else
                    {
                        dp[k * n + i + 1][mask] += dp[k * n + i][mask];
                        dp[k * n + i + 1][mask ^ (1 << i)] += dp[k * n + i][mask];
                        if (i + 1 < n && (mask >> (i + 1) & 1) == 0)
                        {
                            dp[k * n + i + 2][mask] += dp[k * n + i][mask];
                        }
                    }
                }
            }
            if (k + 1 < K)
            {
                var next = new ModInteger[1 << n];
                for (int mask = 0; mask < 1 << n; mask++)
                {
                    var nm = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if ((mask >> i & 1) == 1)
                        {
                            nm |= 1 << (per[k + 1][cur[k][i]]);

                        }
                    }

                    //Debug.WriteLine("{0}->{1}: {2}", Convert.ToString(mask, 2), Convert.ToString(nm, 2), dp[(k + 1) * n][mask]);
                    next[nm] += dp[(k + 1) * n][mask];
                }
                dp[(k + 1) * n] = next;
            }
        }
        return dp[K * n][0];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        //test.ManualTest(5, 3, new string[] { "ACB", "ACB", "BAC", "CBA", "BCA" });
        int n = 2;
        //var s = new string[] { "BA", "BA", "BA", "AB", "AB", "BA" };
        //var s = Enumerable.Repeat("A", 16).ToArray();
        //var s = new string[] { "ACB", "ACB", "BAC", "CBA", "BCA" };
        var s = new string[] { "CDBFGAE", "CBDFEGA" };
        test.ManualTest(n, s[0].Length, s);
    }
}
// CUT end
#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static ModInteger operator ^(ModInteger l, long r) { return ModInteger.Pow(l, r); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
    public static ModInteger Pow(ModInteger v, long k)
    {
        ModInteger ret = 1;
        var n = k;
        for (; n > 0; n >>= 1, v *= v)
        {
            if ((n & 1) == 1)
                ret = ret * v;
        }
        return ret;
    }
}
#endregion