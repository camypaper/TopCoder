using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CliqueCuts
{
    public int sum(int N, int[] a, int[] b, int[] c)
    {
        var g = Enumerate(N, x => 1L << x);
        var v = new ModInteger[N];
        for (int i = 0; i < a.Length; i++)
        {
            g[a[i]] |= 1L << b[i];
            g[b[i]] |= 1L << a[i];
            v[a[i]] += c[i];
            v[b[i]] += c[i];
        }
        var n = N / 2;
        var m = N - n;

        var sum = new ModInteger[1 << n];
        var pat = new ModInteger[1 << n];
        for (int mask = 0; mask < 1 << n; mask++)
        {
            long ok = mask;
            ModInteger u = 0;
            for (int i = 0; i < n; i++)
            {
                if ((mask >> i & 1) == 0) { u -= v[i]; continue; }
                u += v[i];
                ok &= g[i];
            }
            if (ok != mask) continue;
            sum[mask] += u;
            pat[mask] += 1;
        }
        for (int i = 0; i < n; i++)
            for (int mask = 0; mask < 1 << n; mask++)
                if ((mask >> i & 1) == 1)
                {
                    sum[mask] += sum[mask ^ (1 << i)];
                    pat[mask] += pat[mask ^ (1 << i)];
                }
        ModInteger ans = 0;
        for (long mask = 0; mask < 1L << N; mask += 1L << n)
        {
            long ok = mask;
            long fmask = (1L << n) - 1;
            ModInteger u = 0;
            for (int i = n; i < N; i++)
            {
                if ((mask >> i & 1) == 0) { u -= v[i]; continue; }
                u += v[i];
                ok &= g[i];
                fmask &= g[i];
            }
            if (ok != mask) continue;
            ans += pat[fmask] * u + sum[fmask];
        }
        foreach (var x in v) ans += x;
        ans *= (ModInteger.Mod + 1) / 2;
        return (int)ans.num;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int Naive_Test(int n, int[] a, int[] b, int[] c)
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