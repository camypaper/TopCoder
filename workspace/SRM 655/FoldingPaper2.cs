using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoldingPaper2
{
    public int solve(int W, int H, int A)
    {
        var min = int.MaxValue;
        for (int _ = 0; _ < 2; _++)
        {
            for (int i = 1; i * i <= A; i++)
            {
                if (A % i != 0) continue;
                if (i <= W && (A / i) <= H)
                {
                    var a = W;
                    var b = H;
                    var cnt = 0;
                    while (a > i)
                    {
                        a = (a + 1) / 2;
                        cnt++;
                    }
                    while (b > A / i)
                    {
                        b = (b + 1) / 2;
                        cnt++;
                    }
                    min = Math.Min(min, cnt);
                }
            }
            { var tmp = H; H = W; W = tmp; }
        }
        if (min == int.MaxValue) return -1;
        return min;
    }

    // CUT begin
    public int Naive_Test(int W, int H, int A)
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
