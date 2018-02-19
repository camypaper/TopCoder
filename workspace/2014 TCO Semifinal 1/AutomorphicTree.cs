using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AutomorphicTree
{
    public int[] construct(long age)
    {
        if (age == 1) { return new int[] { 1 }; }
        else if (age == 2) { return new int[] { 2, 0, 1 }; }
        var u = 0;
        var E = new List<int>();
        var k = 2;
        var fact = new long[50];
        fact[0] = 1;
        for (int i = 1; i <= 20; i++)
            fact[i] = fact[i - 1] * i;
        Func<long, int, bool> f = null; f = (x, K) =>
               {
                   if (x == 1) return true;
                   if (K == 1) return false;
                   if (x % fact[K] == 0 && f(x / fact[K], K)) return true;
                   if (f(x, K - 1)) return true;
                   return false;
               };
        var r = u;
        for (int i = 20; i >= 2; i--)
        {
            while (age % fact[i] == 0 && f(age / fact[i], i))
            {
                age /= fact[i];
                if (u != 0)
                {
                    E.Add(r);
                    E.Add(u + 1);
                    u++;
                    r = u;
                }
                else
                {
                    for (int j = 0; j < k; j++)
                    {
                        E.Add(u);
                        E.Add(u + 1);
                        u++;

                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    E.Add(r);
                    E.Add(u + 1);
                    u++;
                }
            }
        }
        if (u + 1 > 200 || age != 1) return new int[] { };
        E.Insert(0, u + 1);
        return E.ToArray();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int[] Naive_Test(long age)
    {
        return new int[] { };
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

    }
}
// CUT end
