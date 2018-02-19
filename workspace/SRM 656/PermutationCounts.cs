using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PermutationCounts
{
    public int countPermutations(int N, int[] pos)
    {
        var table = new ModTable(N + 1);
        Debug.WriteLine(table.RepeatedCombination(4, 2) - 1);
        var P = pos.ToList(); P.Add(0); P.Add(N);
        P.Sort();
        var dp = new ModInteger[P.Count];
        dp[0] = 1;
        for (int i = 0; i < P.Count; i++)
            for (int j = 0; j < i; j++)
            {
                var p = dp[j] * table.inv[P[i] - P[j]];
                if ((i - j) % 2 == 1) dp[i] += p;
                else dp[i] -= p;
            }


        return (int)(dp.Last() * table.perm[N]).num;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
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
#region ModTable
public class ModTable
{
    public ModInteger[] perm, inv;
    public ModTable(int n)
    {
        perm = new ModInteger[n + 1];
        inv = new ModInteger[n + 1];
        perm[0] = 1;
        for (int i = 1; i <= n; i++)
            perm[i] = perm[i - 1] * i;
        inv[n] = ModInteger.Inverse(perm[n]);
        for (int i = n - 1; i >= 0; i--)
            inv[i] = inv[i + 1] * (i + 1);
        inv[0] = inv[1];
    }
    public ModInteger Inverse(int k) { return inv[k]; }
    public ModInteger Permutation(int n, int k)
    {
        if (n < 0 || n >= perm.Length)
            return 0;
        if (k < 0 || k >= n)
            return 0;
        return perm[n] * inv[n - k];
    }
    public ModInteger Combination(int n, int r)
    {
        if (n < 0 || n >= perm.Length || r < 0 || r > n) return 0;
        return perm[n] * inv[n - r] * inv[r];
    }
    public ModInteger RepeatedCombination(int n, int k)
    {
        if (k == 0) return 1;
        return Combination(n + k - 1, k);
    }
}
#endregion