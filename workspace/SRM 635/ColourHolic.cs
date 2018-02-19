using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColourHolic
{
    public int countSequences(int[] A)
    {
        Array.Sort(A);
        Array.Reverse(A);
        Debug.WriteLine(A.AsJoinedString());
        var table = new ModTable(100500);
        var dp = new ModInteger[50001];
        dp[A[0] - 1] = 1;
        const int SZ = 402;
        var sum = A[0];
        for (int _ = 1; _ < 4; _++)
        {
            if (A[_] == 0) continue;
            var x = A[_];
            var next = new ModInteger[SZ];
            for (int i = 0; i < dp.Length; i++)
            {
                if (_ == 1) i = A[0] - 1;

                var n = sum + 1;
                for (int j = Math.Min(x, i); j >= 0; j--)
                {
                    if (i - j >= SZ)
                        break;

                    var c1 = table.Combination(i, j);
                    for (int k = x - j; j + k >= 0; k--)
                    {
                        if (j == 0 && k == 0) continue;
                        var rem = x - j - k;
                        if (i - j + rem >= SZ) break;
                        var c2 = table.Combination(n - i, k);
                        var c3 = table.RepeatedCombination(j + k, rem);

                        next[i - j + rem] += dp[i] * c1 * c2 * c3;
                    }
                }

                if (_ == 1) break;
            }
            sum += x;
            dp = next;
            //Debug.WriteLine(dp.AsJoinedString());
        }
        return (int)dp[0].num;
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
public class Tester : AbstractTester
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
    public const long Mod = (long)1e9 + 9;
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