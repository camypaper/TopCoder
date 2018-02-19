using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndBusiness
{
    public double minimumCost(int K, int totalWork, int[] a, int[] p)
    {
        const int MAX = 100000 * 50 + 1;

        var n = a.Length;

        var l = 0.0; var r = 1e18;
        for (int _ = 0; _ < 500; _++)
        {

            var x = (l + r) / 2;
            var A = new double[n];
            for (int i = 0; i < n; i++)
                A[i] = -x * a[i] + 1L * a[i] * p[i] * totalWork;
            Array.Sort(A);
            var sum = 0.0;
            for (int i = 0; i < K; i++)
                sum += A[i];
            if (totalWork * 1.0 * (3600 * K) + sum <= 0) r = x;
            else l = x;


        }
        Debug.WriteLine(l);
        Debug.WriteLine(r);


        return r;
    }

}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        var K = 50;
        var T = 100000;
        var rand = new Random(0);
        var a = Enumerate(50, x => rand.Next(1, 100000));
        var b = Enumerate(50, x => rand.Next(1, 100000));
        test.ManualTest(K, T, a, b);
    }
}
// CUT end
