using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DerangementsStrikeBack
{
    public int count(int n, int m)
    {
        var P = new ModInt[m + 50];
        P[0] = 1;
        P[1] = 0;
        P[2] = 1;
        for (int i = 3; i < m + 50; i++)
            P[i] = (i - 1) * (P[i - 1] + P[i - 2]);
        var table = new ModTable(n + m + 50);
        var ans = 0L;
        for (int i = 1; i <= m; i++)
        {
            ModInt x = 0;
            for (int j = 0; j <= i; j++)
                x += P[i - j] * table.Combination(n, j) * table.Combination(i, i - j);
            Debug.WriteLine(x);
            ans ^= x.num;
        }
        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int n, int m)
    {
        return 0;
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
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
#region ModInt
public struct ModInt
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInt(long n) { num = n; }
    public override string ToString() { return num.ToString(); }
    public static ModInt operator +(ModInt l, ModInt r) { l.num += r.num; if (l.num >= Mod) l.num -= Mod; return l; }
    public static ModInt operator -(ModInt l, ModInt r) { l.num -= r.num; if (l.num < 0) l.num += Mod; return l; }
    public static ModInt operator *(ModInt l, ModInt r) { return new ModInt(l.num * r.num % Mod); }
    public static implicit operator ModInt(long n) { n %= Mod; if (n < 0) n += Mod; return new ModInt(n); }
    public static ModInt Pow(ModInt v, long k)
    {
        k %= Mod - 1;
        ModInt ret = 1;
        var n = k;
        for (; n > 0; n >>= 1, v *= v)
            if ((n & 1) == 1) ret = ret * v;
        return ret;
    }
    public static ModInt Inverse(ModInt v)
    {
        return Pow(v, Mod - 2);
    }
}
#endregion

#region ModTable
public class ModTable
{
    public ModInt[] fact, ifact;
    public ModTable(int n)
    {
        fact = new ModInt[n + 1];
        ifact = new ModInt[n + 1];
        fact[0] = 1;
        for (int i = 1; i <= n; i++)
            fact[i] = fact[i - 1] * i;
        ifact[n] = ModInt.Inverse(fact[n]);
        for (int i = n - 1; i >= 0; i--)
            ifact[i] = ifact[i + 1] * (i + 1);
        ifact[0] = ifact[1];
    }
    public ModInt Permutation(int n, int k)
    {
        if (n < 0 || n >= fact.Length) return 0;
        if (k < 0 || k > n) return 0;
        return fact[n] * ifact[n - k];
    }
    public ModInt Combination(int n, int r)
    {
        if (n < 0 || n >= fact.Length || r < 0 || r > n) return 0;
        return fact[n] * ifact[n - r] * ifact[r];
    }
    public ModInt RepeatedCombination(int n, int k)
    {
        if (k == 0) return 1;
        return Combination(n + k - 1, k);
    }
}
#endregion