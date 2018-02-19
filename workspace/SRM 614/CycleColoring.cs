using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CycleColoring
{
    public int countColorings(int[] size, int[] from, int[] to, int K)
    {
        //dp(i,0) i番目の色と1番目の色が同じ 通り数
        //dp(i,1) i番目の色と1番目の色が違う 通り数
        var dp = Enumerate(1000050, x => new ModInteger[2]);
        dp[1][0] = 1;
        dp[1][1] = 0;

        for (int i = 2; i <= 1000010; i++)
        {
            var all = (dp[i - 1][0] + dp[i - 1][1]) * (K - 1);
            dp[i][0] = dp[i - 1][1];
            dp[i][1] = all - dp[i][0];
        }
        var n = size.Length;
        var dp2 = new ModInteger[2] { K, 0 };
        for (int i = 0; i < n; i++)
        {
            var f = from[i];
            var t = to[(i + n - 1) % n];
            var m = size[i];
            var a = Math.Abs(t - f);
            var b = m - a;
            Debug.WriteLine("{0} {1}", a, b);
            var all = dp[m][1];
            var sa = dp[a + 1][0] * dp[b + 1][0];
            var di = all - sa;

            var next = new ModInteger[2];
            next[0] = dp2[0] * sa + dp2[1] * di * ModInteger.Inverse(K - 1);
            next[1] = (dp2[0] + dp2[1]) * all - next[0];
            dp2 = next;
        }



        return (int)dp2[0].num;
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
        test.ManualTest(new int[] { 1000000 }, new int[] { 0 }, new int[] { 0 }, 1000000000);
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
#region Inverse
public partial struct ModInteger
{
    static public ModInteger Inverse(ModInteger v)
    {
        long p, q;
        ExGCD(v.num, Mod, out p, out q);
        return new ModInteger(p % Mod + Mod);
    }
    static public long ExGCD(long a, long b, out long x, out long y)
    {
        var u = new long[] { a, 1, 0 };
        var v = new long[] { b, 0, 1 };
        while (v[0] != 0)
        {
            var t = u[0] / v[0];
            for (int i = 0; i < 3; i++)
            {
                var tmp = u[i] - t * v[i];
                u[i] = v[i];
                v[i] = tmp;
            }
        }
        x = u[1];
        y = u[2];
        if (u[0] > 0)
            return u[0];
        for (int i = 0; i < 3; i++)
            u[i] = -u[i];
        return u[0];

    }
}
#endregion

