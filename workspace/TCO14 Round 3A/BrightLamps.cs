using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BrightLamps
{
    public int maxBrightness(string init, int[] a, int K)
    {
        var ans = new int[2];
        var n = init.Length;
        for (int i = 0; i < K; i++)
        {
            var cnt = 0;
            var min = 1000000000;
            for (int j = i; j < n; j += K)
            {
                min = Math.Min(min, a[j]);
                if (init[j] == '0') cnt ^= 1;
            }
            ans[cnt] += min;
        }
        return a.Sum() - ans.Min();
    }

    // CUT begin
    public int Naive_Test(string init, int[] a, int K)
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
        //Tests.Add(null);
    }
}
// CUT end
