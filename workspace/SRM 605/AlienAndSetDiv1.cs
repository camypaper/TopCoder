using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AlienAndSetDiv1
{
    public int getNumber(int N, int K)
    {
        //dp(i,mask)=|A|==i && mask=’¼‘O kŒÂ‚Ì”ƒ‚¢•û0:A,1:B
        K--;
        int ALL = (1 << K) - 1;
        var dp = new ModInteger[N + 2, 1 << K];
        dp[K, 0] = dp[0, ALL] = 1;
        for (int k = K; k < 2 * N; k++)
        {
            var next = new ModInteger[N + 2, 1 << K];
            for (int i = 0; i <= N; i++)
            {
                var j = k - i;
                for (int mask = 0; mask < 1 << K; mask++)
                {
                    if (dp[i, mask].num == 0) continue;

                    {
                        var cnt = PopCount(mask);
                        var minj = -1;
                        var maxj = 100000;
                        if (cnt > 0) { minj = j - cnt + 1; maxj = j; }
                        else maxj = -1;
                        if (i + 1 < minj || maxj < i + 1)
                            next[i + 1, (mask * 2) & ALL] += dp[i, mask];
                    }
                    {

                        var cnt = K - PopCount(mask);
                        var mini = -1;
                        var maxi = 100000;
                        if (cnt > 0) { mini = i - cnt + 1; maxi = i; }
                        else maxi = -1;
                        if (j + 1 < mini || maxi < j + 1)
                            next[i, (mask * 2 + 1) & ALL] += dp[i, mask];
                    }

                }
            }
            dp = next;

        }
        ModInteger ans = 0;
        for (int i = 0; i < 1 << K; i++)
            ans += dp[N, i];
        return (int)(ans.num);
    }
    static public int PopCount(int i)
    {
#if DEBUG || TRACE
        unchecked
        {
#endif
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return ((i + (i >> 4) & 0xF0F0F0F) * 0x1010101) >> 24;
#if DEBUG || TRACE
        }
#endif
    }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(50, 10);
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