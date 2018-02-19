using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Nine
{
    public int count(int N, int[] D)
    {
        var A = new int[1 << N];
        foreach (var x in D) A[x]++;

        var dp = new ModInteger[9, 9, 9, 9, 9];
        dp[0, 0, 0, 0, 0] = 1;
        for (int mask = 0; mask < 1 << N; mask++)
        {
            if (A[mask] == 0) continue;
            var next = new ModInteger[9, 9, 9, 9, 9];
            var dpdp = new ModInteger[10];
            dpdp[0] = 1;
            for (int K = 0; K < A[mask]; K++)
            {
                var ndp = new ModInteger[9];
                for (int j = 0; j < 9; j++)
                    for (int v = 0; v < 10; v++)
                        ndp[(j + v) % 9] += dpdp[j];
                dpdp = ndp;
            }
            for (int a = 0; a < 9; a++)
                for (int b = 0; b < 9; b++)
                    for (int c = 0; c < 9; c++)
                        for (int d = 0; d < 9; d++)
                            for (int e = 0; e < 9; e++)
                                for (int v = 0; v < 9; v++)
                                {
                                    var p = new int[5] { a, b, c, d, e };
                                    for (int i = 0; i < 5; i++)
                                        if ((mask >> i & 1) == 1) p[i] = (p[i] + v) % 9;
                                    next[p[0], p[1], p[2], p[3], p[4]] += dp[a, b, c, d, e] * dpdp[v];
                                }

            dp = next;
        }

        return (int)dp[0, 0, 0, 0, 0].num;
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