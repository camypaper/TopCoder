using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BiconnectedDiv1
{
    public int minimize(int[] w1, int[] w2)
    {
        var n = w1.Length + 1;
        var dp1 = new int[n];//i-1,ini

        var dp2 = new int[n];
        for (int i = 0; i < n; i++)
            dp1[i] = dp2[i] = -1000000000;
        dp1[1] = 0;
        for (int i = 2; i < n; i++)
        {
            dp1[i] = Math.Max(dp1[i], dp2[i - 1] + w1[i - 1]);
            dp1[i] = Math.Max(dp1[i], dp2[i - 1] + w2[i - 2]);
            dp1[i] = Math.Max(dp1[i], dp1[i - 1] + w1[i - 1]);
            dp2[i] = Math.Max(dp2[i], dp1[i - 1]);
            dp2[i] = Math.Max(dp2[i], dp2[i - 1]);
        }
        return w1.Sum() + w2.Sum() - dp2[n - 1];
    }

}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        var rand = new Random(0);
        var n = 100;
        var a = Enumerate(n - 1, x => rand.Next(0, 10000 + 1));
        var b = Enumerate(n - 2, x => rand.Next(0, 2));
        a[0] = 0;a[n - 2] = 0;
        test.ManualTest(a, b);
        
    }
}
// CUT end
