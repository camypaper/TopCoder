using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class IncreasingSequences {
    const long MOD = 998244353;
    public int count(int[] L, int[] R) {
        var xs = new List<int>();
        var n = L.Length;
        for (int i = 0; i < n; i++)
        {
            xs.Add(L[i]);
            xs.Add(R[i] + 1);
        }
        xs = xs.Distinct().ToList(); xs.Sort();
        for (int i = 0; i < n; i++)
        {
            L[i] = xs.BinarySearch(L[i]);
            R[i] = xs.BinarySearch(R[i] + 1);

        }
        var m = xs.Count;
        var fact = Enumerate(m, x => new long[n + 5]);
        var ifac = new long[n + 5];
        ifac[0] = 1;
        for (int i = 1; i < n + 5; i++)
            ifac[i] = ifac[i - 1] * i % MOD;
        for (int i = 0; i < n + 5; i++)
            ifac[i] = ModInt.Inverse(ifac[i]).num;
        for (int i = 0; i < m - 1; i++)
        {
            var len = xs[i + 1] - xs[i];
            fact[i][0] = len % MOD;
            for (int j = 1; j < n + 5; j++)
                fact[i][j] = fact[i][j - 1] * Math.Max(1, len - j) % MOD;
        }
        Func<int, int, long> comb = (i, K) =>
        {
            var len = xs[i + 1] - xs[i];
            if (K < 0 || K > len) return 0;
            if (K == 0 || K == len) return 1;
            return fact[i][K - 1] * ifac[K] % MOD;
        };
        var dp = new long[m + 5, n + 5];
        for (int j = 0; j < m; j++)
            if (L[0] <= j && j < R[0]) dp[j, 1] = 1;
        for (int i = 1; i < n; i++)
        {
            var next = new long[m + 5, n + 5];
            var sum = 0L;
            for (int j = 0; j < m - 1; j++)
            {
                long add = 0L;
                for (int k = 0; k <= i; k++)
                {
                    //remain
                    if (L[i] <= j && j < R[i])
                        next[j, k + 1] = (next[j, k + 1] + dp[j, k]) % MOD;
                    //pass
                    add = (add + dp[j, k] * comb(j, k)) % MOD;
                }
                if (L[i] <= j && j < R[i])
                    next[j, 1] = (next[j, 1] + sum) % MOD;
                sum = (sum + add) % MOD;
            }
            dp = next;
        }
        var ans = 0L;
        for (int i = 0; i < m - 1; i++)
            for (int j = 0; j < n + 5; j++)
                ans = (ans + dp[i, j] * comb(i, j)) % MOD;
        return (int)ans;

    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] L, int[] R) {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX {
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester {
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run() {
        ManualTest(Enumerate(300, x => 1), Enumerate(300, x => 1000000000), false);
        //Tests.Add(null);
        Test(Example3);
        Test(Example1);
        Test(Example0);
        Test(Example2);
        Test(Example4);

    }
}
// CUT end


#region ModInt
public struct ModInt {
    public const long Mod = 998244353;
    public long num;
    public ModInt(long n) { num = n; }
    public override string ToString() { return num.ToString(); }
    public static ModInt operator +(ModInt l, ModInt r) { l.num += r.num; if (l.num >= Mod) l.num -= Mod; return l; }
    public static ModInt operator -(ModInt l, ModInt r) { l.num -= r.num; if (l.num < 0) l.num += Mod; return l; }
    public static ModInt operator *(ModInt l, ModInt r) { return new ModInt((int)(l.num * r.num % Mod)); }
    public static implicit operator ModInt(long n) { n %= Mod; if (n < 0) n += Mod; return new ModInt(n); }
    public static ModInt Pow(ModInt v, long k) { return Pow(v.num, k); }
    public static ModInt Pow(long v, long k) {
        long ret = 1;
        for (k %= Mod - 1; k > 0; k >>= 1, v = v * v % Mod)
            if ((k & 1) == 1) ret = ret * v % Mod;
        return new ModInt(ret);
    }
    public static ModInt Inverse(ModInt v) { return Pow(v, Mod - 2); }
}
#endregion