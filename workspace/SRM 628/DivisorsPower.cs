using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DivisorsPower
{
    public long findArgument(long n)
    {

        var a = new int[1000050];
        for (int i = 1; i < 1000050; i++)
        {
            for (int j = i; j < 1000050; j += i)
                a[j] += 1;
        }
        for (int i = 1; i < 1000050; i++)
        {
            var k = a[i];
            var v = n;
            for (int j = 0; j < k; j++)
                if (v % i == 0) v /= i;
                else { v = -1; break; }
            if (v == 1) return i;

        }

        long l = 1, r = 1000000001;
        for (int i = 0; i < 50; i++)
        {
            var m = (l + r) / 2;
            if (m * m >= n) r = m;
            else l = m;
        }

        if (r * r == n)
        {
            for (long i = 2; i * i <= r; i++)
                if (r % i == 0) r = -1;

            if (r != -1) return r;
        }
        return -1;
    }

    // CUT begin
    public long Naive_Test(long n)
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
    public void OnInit()
    {
        Tests.Add(() => ManualTest(9109555799784049));
        //Tests.Add(null);
    }
}
// CUT end
