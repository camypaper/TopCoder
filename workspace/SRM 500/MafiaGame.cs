using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MafiaGame
{
    public double probabilityToLose(int N, int[] decisions)
    {
        var a = new int[N];
        foreach (var x in decisions) a[x]++;
        var max = a.Max();
        if (max == 1) return 0;
        var cnt = a.Count(x => x == max);
        while (cnt != 1)
        {
            var ncnt = 0;
            var rem = N - cnt * max;
            ncnt = rem % cnt;
            if (ncnt == 0) return 0;
            cnt = ncnt;
        }

        return 1.0 / a.Count(x => x == max);
    }

    // CUT begin
    public double Naive_Test(int N, int[] decisions)
    {
        return 0.0;
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
        Test(Example3);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);

    }
}
// CUT end
