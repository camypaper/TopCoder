using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CutSticks
{
    public double maxKth(int[] sticks, int C, int K)
    {
        var n = sticks.Length;
        Array.Sort(sticks);
        var l = 0.0;
        var r = 1.0 * sticks.Max();
        for (int _ = 0; _ < 1000; _++)
        {
            var m = (l + r) / 2;
            //Debug.WriteLine(m);
            long cnt = 0;
            long cut = 0;
            for (int i = 0, f = -1; i < n; i++)
            {
                var x = sticks[i];
                if (x < m) continue;
                if (f == -1) { f = 1; cnt += n - i; }
                var k = (long)(x / m);
                k = Math.Min(C - cut + 1, k);
                if (k >= 2)
                {
                    cut += k - 1;
                    cnt += k - 1;
                }
            }
            if (cnt >= K)
                l = m;
            else r = m;
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
    public Random rand = new Random(0);
    public Tester()
    {
        var a = new int[] { 143390929, 318898992, 266622897, 238365222, 190390123, 230811619, 314177179, 105670876, 145037137, 165923677, 190448664, 146741075, 155353105, 256935984, 266137225, 253246171, 268523450, 279465868, 313745987, 141339613, 144849754, 175511177, 152245416, 85994088, 294720623, 161705459, 188664745, 297565936, 239317020, 227662286, 208607463, 275719209, 207571577, 309832216, 323931223, 208358559, 290673479, 153688272, 150866307, 169409223, 292538026, 291778754, 328031346, 185781719, 112696907, 177725277, 316552332, 294026947 };
        var b = 442877594;
        var c = 302017126;
        //test.ManualTest(a, b, c);
        test.Example3();
    }
}
// CUT end
