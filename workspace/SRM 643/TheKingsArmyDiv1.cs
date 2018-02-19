using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheKingsArmyDiv1
{
    public int getNumber(string[] state)
    {
        if (state.SelectMany(x => x).All(x => x == 'S')) return -1;
        if (state.SelectMany(x => x).All(x => x == 'H')) return 0;
        var n = state[0].Length;
        var c = 0; var h = 0;
        var pre = -1;
        for (int i = 0; i < n; i++)
        {
            var k = 0;
            if (state[0][i] != 'S') k |= 1;
            if (state[1][i] != 'S') k |= 2;
            if (k == 0) { c++; continue; }
            if (k == 3) continue;
            if (pre == k) continue;
            pre = k; h++;
        }
        if (h == 0) return c;
        return c + h / 2 + 1;
    }

}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.Example5();
    }
}
// CUT end
