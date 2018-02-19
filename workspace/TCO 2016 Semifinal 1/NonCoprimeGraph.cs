using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NonCoprimeGraph
{
    public int distance(int n, int s, int t)
    {
        return f(n, Math.Min(s, t), Math.Max(s, t));
    }
    int f(long n, long s, long t)
    {
        if (s == t) return 0;
        if (s == 1) return -1;
        if (gcd(s, t) != 1) return 1;
        for (int i = 2; i <= 100000; i++)
            if (s % i == 0) { s = i; break; }
        for (int i = 2; i <= 100000; i++)
            if (t % i == 0) { t = i; break; }

        if (s * t <= n) return 2;
        if (Math.Max(s, t) * 2 <= n) return 3;
        return -1;

    }
    long gcd(long x, long y)
    {
        if (x == 0) return y;
        if (y == 0) return x;
        return gcd(y, x % y);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int n, int s, int t)
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

    }
}
// CUT end
