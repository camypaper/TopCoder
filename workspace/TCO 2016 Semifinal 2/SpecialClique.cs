using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SpecialClique
{
    public string exist(long[] s)
    {
        if (f(s)) return "Possible";
        return "Impossible";
    }
    bool f(long[] a)
    {
        foreach (var last in a)
        {
            for (int i = 0; i < 60; i++)
            {
                if ((last >> i & 1) == 1) continue;
                var flag = (1L << 62) - 1;
                foreach (var x in a)
                {
                    if ((x >> i & 1) == 0) continue;
                    if ((last & x) == 0) continue;
                    flag &= x;
                }
                if (flag == 1L << i)
                    return true;
            }
        }
        return false;
    }
    // CUT begin
    public string Naive_Test(long[] s)
    {
        return "";
    }

    // CUT end
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
