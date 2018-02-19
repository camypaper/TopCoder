using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ConsecutiveOnes
{
    public long get(long n, int k)
    {
        var min = long.MaxValue;
        var bit = new long[55];
        for (int i = 0; i < 55; i++)
            bit[i] = n >> i & 1;
        for (int i = 0; i < 55; i++)
        {
            if (i + k > 55) break;
            var a = new long[55];
            for (int j = 0; j < k; j++)
                a[i + j] = 1;
            for (int j = 55 - 1; j >= 0; j--)
            {
                if (bit[j] == 1 && a[j] == 0) a[j] = 1;
                if (bit[j] == 0 && a[j] == 1) break;
            }
            var v = 0L;
            for (int j = 55 - 1; j >= 0; j--)
                v = v * 2 + a[j];
            min = Math.Min(min, v);
        }
        return min;
    }

    // CUT begin
    public long Naive_Test(long n, int k)
    {
        return 0;
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

    }
}
// CUT end
