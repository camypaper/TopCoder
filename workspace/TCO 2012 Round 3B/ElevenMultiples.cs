using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ElevenMultiples
{
    public int countMultiples(string[] pieces)
    {
        var odd = new List<int>();
        var even = new List<int>();
        foreach (var x in pieces)
        {
            var v = 0;
            foreach (var d in x)
                v = (v * 10 + d - '0') % 11;
            if (x.Length % 2 == 0)
                even.Add(v);
            else odd.Add(v);
        }
        var n = odd.Count;
        var dp = new ModInteger[n + 2, n + 2, 12];
        dp[0, 0, 0] = 1;
        foreach (var x in odd)
        {
            var next = new ModInteger[n + 2, n + 2, 12];
            for (int i = 0; i <= n; i++)
                for (int j = 0; j <= n; j++)
                {
                    for (int mod = 0; mod < 11; mod++)
                    {
                        next[i + 1, j, (mod + x) % 11] += (i + 1) * dp[i, j, mod];
                        next[i, j + 1, (mod + x * 10) % 11] += (j + 1) * dp[i, j, mod];
                    }
                }
            dp = next;
        }
        var N = pieces.Length;
        var dp2 = new ModInteger[N + 5, N + 5, 12];
        for (int i = 0; i < 12; i++)
            dp2[(n + 2) / 2, (n + 1) / 2, i] = dp[(n + 1) / 2, n / 2, i];
        foreach (var x in even)
        {
            var next = new ModInteger[N + 5, N + 5, 12];
            for (int i = 0; i <= N; i++)
                for (int j = 0; j <= N; j++)
                    for (int mod = 0; mod < 11; mod++)
                    {
                        next[i + 1, j, (mod + x) % 11] += i * dp2[i, j, mod];
                        next[i, j + 1, (mod + x * 10) % 11] += j * dp2[i, j, mod];
                    }
            dp2 = next;
        }
        ModInteger ans = 0;
        for (int i = 0; i <= N + 1; i++)
            for (int j = 0; j <= N + 1; j++)
                ans += dp2[i, j, 0];
        return (int)(ans.num);
    }

}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(new string[] { "22116011502323819929551566735071902177259883612205" });
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
