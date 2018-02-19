using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MaxMinTreeGame
{
    public int findend(int[] edges, int[] costs)
    {
        var n = edges.Length + 1;
        var cnt = new int[n];
        for (int i = 0; i < n - 1; i++)
        {
            var to = edges[i];
            cnt[to]++; cnt[i + 1]++;
        }
        var max=0;
        for (int i = 0; i < n; i++)
        {
            if (cnt[i] == 1)
                max = Math.Max(max, costs[i]);
        }

        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
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
