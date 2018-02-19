using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AppleTrees
{
    public int theCount(int D, int[] r)
    {
        const int MAX = 80 * 40;
        var dp = new ModInteger[MAX + 100, 45];
        dp[0, 1] = 1;

        foreach (var x in r.OrderByDescending(x => x))
        {
            var next = new ModInteger[MAX + 100, 45];
            for (int i = 0; i < MAX; i++)
                for (int j = 1; j < 42; j++)
                {
                    next[i, j - 1] += dp[i, j] * j;
                    next[i + x - 1, j] += dp[i, j] * 2 * j;
                    next[i + 2 * (x - 1), j + 1] += dp[i, j] * j;
                }
            dp = next;
        }

        var fact = new ModInteger[200000];
        var inv = new ModInteger[200000];
        fact[0] = 1; inv[0] = 1;
        for (int i = 1; i < 200000; i++)
        {
            fact[i] = fact[i - 1] * i;
            inv[i] = ModInteger.Pow(fact[i], ModInteger.Mod - 2);
        }
        Func<int, int, ModInteger> binomial = (a, b) => a < 0 || b < 0 || b > a ? 0 : fact[a] * inv[a - b] * inv[b];

        ModInteger pat = 0;
        ModInteger ans = 0;
        for (int i = 0; i <= MAX + 80; i++)
            if (dp[i, 0].num != 0)
            {
                ans += dp[i, 0] * binomial(D - i, r.Length);
                pat += dp[i, 0];
            }
        Debug.WriteLine(pat);
        Debug.WriteLine(fact[r.Length]);
        return (int)ans.num;
    }

    // CUT begin
    public int Naive_Test(int D, int[] r)
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
        ManualTest(2, new int[] { 1, 1 });
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
    public static implicit operator ModInteger(long n) { return new ModInteger() { num = n }; }
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