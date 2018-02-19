using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FarmvilleDiv2
{
    public int minTime(int[] time, int[] cost, int budget)
    {

        Array.Sort(cost, time);
        for (int i = 0; i < time.Length; i++)
        {
            var c = cost[i];
            var k = Math.Min(time[i], budget / c);
            time[i] -= k;
            budget -= k * c;


        }
        return time.Sum();
    }
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
