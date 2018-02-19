using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PowerOfThree
{
    public string ableToGet(int x, int y)
    {
        var a = new int[] { Math.Abs(x), Math.Abs(y) };
        while (a.Max() > 0)
        {
            var cnt = 0;
            for (int i = 0; i < 2; i++)
            {
                if (a[i] % 3 == 1) cnt++;
                else if (a[i] % 3 == 2) { a[i]++; cnt++; }
                a[i] /= 3;
            }
            if (cnt != 1) return "Impossible";

        }
        return "Possible";
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
        test.ManualTest(21466, -6546);
    }
}
// CUT end
