using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RandomGCD
{
    public int countTuples(int N, int K, int low, int high)
    {
        var xs = new List<int>();
        for (int i = low; i <= high; i++)
        {
            if (i % K != 0) continue;
            xs.Add(i / K);
        }
        if (xs.Count == 0) return 0;
        ModInteger ans = 0;
        var dp1 = new ModInteger[100050];
        var dp2 = new ModInteger[xs.Count];
        for (int i = xs.Count - 1; i >= 0; i--)
        {
            var x = xs[i];
            if (x <= 100000) continue;
            var sum = 1;
            for (int j = i + x; j < xs.Count; j += x)
            {
                sum++;
                dp2[i] -= dp2[j];
            }
            dp2[i] += ModInteger.Pow(sum, N);
        }
        for (int i = 100000; i >= 1; i--)
        {
            var sum = 0;
            var p = 0;
            if (xs[0] % i != 0) p += i - (xs[0] % i);
            for (; p < xs.Count; p += i)
            {
                sum++; dp1[i] -= dp2[p];
            }
            for (int j = i * 2; j <= 100000; j += i)
                dp1[i] -= dp1[j];
            dp1[i] += ModInteger.Pow(sum, N);
        }
        return (int)dp1[1].num;
    }

}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(3, 1, 6, 8);
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