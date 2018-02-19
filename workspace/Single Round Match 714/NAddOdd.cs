using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NAddOdd
{
    public long solve(long L, long R, int K)
    {
        var max = 0;
        Random rand = new Random();
        for (int i = 0; i < 10000; i++)
        {
            long x = rand.Next();
            long y = rand.Next();
            var v = x * 100000000 + y;
            var u = rand.Next(1, 5000) * 2 + 1;
            max = Math.Max(max, f(v, u));
        }
        Debug.WriteLine(max);
        return 0;
    }
    int f(long x, long k)
    {
        if (x <= k) return 0;
        if (x % 2 == 0) return 1 + f(x / 2, k);
        else return 1 + f(x + k, k);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(long L, long R, int K)
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
