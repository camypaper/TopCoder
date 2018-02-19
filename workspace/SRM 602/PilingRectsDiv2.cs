using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PilingRectsDiv2
{
    public int getmax(int[] X, int[] Y, int limit)
    {
        var n = X.Length;
        for (int i = 0; i < n; i++)
        {
            if (X[i] < Y[i])
                Swap(ref X[i], ref Y[i]);
        }
        var max = -1;
        for (int x = 0; x <= 200; x++)
        {
            for (int y = 0; y <= 200; y++)
            {
                if (x * y < limit)
                    continue;
                var cnt=0;
                for (int i = 0; i < n; i++)
                {
                    if (X[i] >= x && Y[i] >= y) cnt++;
                    
                }
                if (cnt > 0) max = Math.Max(cnt, max);
            }
        }
        return max;
    }

    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
// CUT begin
public class Tester : AbstractTester
{
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
