using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearPlays
{
    public int pileSize(int A, int B, int K)
    {
        var mod = A + B;
        var ans = (A * ModPow(2, K, mod)) % mod;
        return (int)Math.Min(ans, mod - ans);
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
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
