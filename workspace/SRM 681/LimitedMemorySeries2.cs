using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class LimitedMemorySeries2
{
    public int getSum(int n, long x, long a, long b)
    {
        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            var p = x;
            var q = x;
            var r = i;
            var l = i;
            while (l - 1 >= 0 && r + 1 < n)
            {
                p = f(p, a, b);
                q = invf(q, a, b);
                if (p >= x || q >= x) break;
                ans++;
                l--; r++;

            }
            if (ans >= 1000000007) ans -= 1000000007;
            x = f(x, a, b);
        }
        return ans;
    }
    long invf(long x, long a, long b)
    {
        x -= b;
        if (x < 0) x += 1L << 50;
        return (x ^ a) & mask;
    }
    const long mask = (1L << 50) - 1;
    long f(long x, long a, long b)
    {
        return ((x ^ a) + b) & mask;
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
