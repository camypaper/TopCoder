using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheShuttles
{
    public int getLeastCost(int[] cnt, int baseCost, int seatCost)
    {
        var min = int.MaxValue;
        for (int i = 1; i <= 100; i++)
        {
            var val = 0;
            foreach(var x in cnt)
            {
                var k = (x + i - 1) / i;
                val += k * (baseCost + i * seatCost);
            }
            min = Math.Min(val, min);

        }
        
        return min;
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
