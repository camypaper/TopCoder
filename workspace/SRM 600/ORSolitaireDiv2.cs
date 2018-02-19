using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ORSolitaireDiv2
{
    public int getMinimum(int[] numbers, int goal)
    {
        var n = numbers.Length;
        var a = new long[n];
        for (int i = 0; i < n; i++)
            a[i] = numbers[i];
        long g = goal;
        var cnt = new int[64];
        foreach (var x in a)
        {
            var ok = true;
            for (int i = 0; i < 64; i++)
                if ((x >> i & 1) == 1 && (g >> i & 1) == 0)
                    ok = false;
            if (!ok) continue;
            Debug.WriteLine(x);
            for (int i = 0; i < 64; i++)
                if ((x >> i & 1) == 1) cnt[i]++;
        }
        var ans = 1 << 30;
        for (int i = 0; i < 64; i++)
            if ((g >> i & 1) == 1) ans = Math.Min(cnt[i], ans);

        return ans;
    }

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
