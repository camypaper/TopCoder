using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SilverDistance
{
    public int minSteps(int sx, int sy, int gx, int gy)
    {
        var dx = gx - sx;
        var dy = gy - sy;
        if (dy > 0)
        {

            if (Math.Abs(dx) <= dy) return dy;
            if (Math.Abs((sx + sy) % 2) == Math.Abs((gx + gy) % 2))
                return Math.Max(Math.Abs(dx), Math.Abs(dy));
            else return Math.Max(Math.Abs(dx), Math.Abs(dy)) + 1;
        }
        else if (dy == 0)
        {
            dx = Math.Abs(dx);
            if (dx % 2 == 1) return dx + 1;
            else return dx;
        }
        else
        {
            dx = Math.Abs(dx);
            dy = Math.Abs(dy);
            if (Math.Abs((sx + sy) % 2) == Math.Abs((gx + gy) % 2))
                return Math.Max(Math.Abs(dx), Math.Abs(dy));
            else return Math.Max(Math.Abs(dx), Math.Abs(dy)) + ((dx > dy) ? 1 : 2);
        }
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
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(168858, 569210, 997844, 997385);
    }
}
// CUT end
