using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PowerEquation
{
    public int count(int n)
    {
        long ans = 0;

        for (int a = 1; a < 32; a++)
            for (int b = 1; b < 32; b++)
            {
                if (GCD(a, b) != 1) continue;
                var x = get(n, a);
                var y = get(n, b);
                if (x == 1 || y == 1) continue;
                var max = Math.Min(x, y) - 1;
                ans += max * (n / Math.Max(a, b));
                ans %= 1000000007;
            }
        ans += Math.BigMul(n, n);
        ans %= 1000000007;
        return (int)ans;
    }
    long get(long n, int k)
    {

        long l = 1; long r = n + 1;
        for (int i = 0; i < 40; i++)
        {
            var m = (l + r) / 2;
            long x = 1;
            for (int t = 0; t < k; t++)
                x = Math.Min(x * m, n + 1);
            if (x <= n) l = m;
            else r = m;
        }
        return l;
    }
    static public int GCD(int n, int m)
    {
        bool f = true;
        for (; n != 0 && m != 0; f ^= true)
        {
            if (f) m %= n;
            else n %= m;
        }
        return n == 0 ? m : n;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int n)
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
