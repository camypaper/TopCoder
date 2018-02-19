using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BlackBoxDiv2
{
    public int count(string front, string side)
    {
        var n = front.Count(x => x == 'B');
        var m = side.Count(x => x == 'B');
        var table = new ModTable(100);
        var dp = Enumerate(n + 1, x => new ModInteger[m + 1]);
        dp[0][0] = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= m; j++)
            {
                if (dp[i][j].num == 0)
                    continue;
                for (int k = 1; k <= m; k++)
                {
                    if (k > j)
                    {
                        var add = ModInteger.Pow(2, j);
                        var pat = table.Combination(m - j, k - j);
                        dp[i + 1][k] += dp[i][j] * add * pat;
                    }
                    else
                    {
                        var pat = table.Combination(j, k);
                        dp[i + 1][j] += dp[i][j] * pat;
                    }
                }
            }
        }


        return (int)(dp[n][m].num);
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
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end

#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0)num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod)n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod)n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
}
#endregion
#region ModPow
public partial struct ModInteger
{
    static public ModInteger Pow(ModInteger v, ModInteger k)
    {
        ModInteger ret = 1;
        var n = k.num;
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
#region Permutaion
public class ModTable
{
    ModInteger[] perm, inv;
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
    public ModInteger this[int k] { get { return perm[k]; } }
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
