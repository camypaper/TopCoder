using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class OthersXor
{
    public long minSum(int[] a)
    {
        var n = a.Length;
        var m = a.Count(x => x == -1);
        if (m == n) return 0;
        else if (m == n - 1) return a.Where(x => x != -1).First();
        long ans = 0;
        for (int k = 0; k < 30; k++)
        {
            var ok = false;
            for (int cnt = 0; cnt <= n; cnt++)
            {
                var v = 0;
                for (int i = 0; i < n; i++)
                {
                    if (a[i] == -1) continue;
                    if ((a[i] >> k & 1) == 1)
                    {
                        if (cnt % 2 == 0) v++;
                    }
                    else
                    {
                        if (cnt % 2 == 1) v++;
                    }
                }
                if (v > cnt) continue;
                if (v + m >= cnt)
                {
                    ok = true;
                    ans += cnt * (1L << k);
                    break;
                }
            }
            if (!ok) return -1;

        }
        return ans;
    }

    // CUT begin
    public long Naive_Test(int[] x)
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
        var a = new int[] { -1, 0, -1, 1, 1 };
        Tests.Add(() => ManualTest(a));
        //Tests.Add(null);
    }
}
// CUT end
