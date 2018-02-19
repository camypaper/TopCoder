using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PolynomialGCD
{
    public int gcd(string s)
    {
        var primes = MathEx.SieveList(10000);
        long ans = 1;
        const long MOD = (long)1e9 + 7;
        var V = new List<int>();
        foreach (var x in s) V.Add(x - '0');

        foreach (var p in primes)
        {
            var min = minExp(V, p);
            ans = (ans * ModPow(p, min, MOD)) % MOD;
        }
        return (int)ans;
    }
    int minExp(List<int> e, int p)
    {
        if (e.Count < p) return 0;
        var ans = int.MaxValue;
        for (int i = 0; i < p; i++)
        {
            var next = new List<int>();
            var x = 0;
            for (int j = i; j < e.Count; j += p)
            {
                x += e[j];
                next.Add(e[j]);
            }
            ans = Math.Min(ans, x + minExp(next, p));
        }
        return ans;
    }
    static public long ModPow(long x, long n, long mod)
    {
        long r = 1;
        while (n > 0)
        {
            if ((n & 1) == 1)
                r = r * x % mod;
            x = x * x % mod;
            n >>= 1;
        }
        return r;
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
#region sieve list
static public partial class MathEx
{
    static public List<int> SieveList(int p)
    {
        var isPrime = new bool[p + 1];
        for (int i = 2; i <= p; i++)
            isPrime[i] = true;
        for (int i = 2; i * i <= p; i++)
        {
            if (!isPrime[i])
                continue;
            for (int j = i * i; j <= p; j += i)
                isPrime[j] = false;
        }
        var ret = new List<int>();
        for (int i = 0; i <= p; i++) if (isPrime[i]) ret.Add(i);
        return ret;
    }
}
#endregion