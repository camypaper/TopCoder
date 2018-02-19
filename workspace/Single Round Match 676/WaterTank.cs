using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class WaterTank
{
    public double minOutputRate(int[] t, int[] x, int C)
    {
        var l = 0.0;
        var r = 2000000.0;
        var n = t.Length;
        for (int _ = 0; _ < 200; _++)
        {
            var m = (l + r) / 2.0;
            var sum = 0.0;
            var ok = true;
            for (int i = 0; i < n; i++)
            {
                if (x[i] <= m) continue;
                sum += (x[i] - m) * t[i];
                if (sum > C)
                {
                    ok = false;
                }
            }
            if (ok) r = m;
            else l = m;
        }
        return l;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public override void Test()
    {
        var n = 50;

        var T = new int[] { 1000000, 1000000 };
        var V = new int[] { 1000000, 1 };
        var C = 1;


        test.ManualTest(T, V, C);
        base.Test();
    }
}
// CUT end
