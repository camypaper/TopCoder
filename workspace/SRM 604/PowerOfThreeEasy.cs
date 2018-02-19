using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PowerOfThreeEasy
{
    public string ableToGet(int x, int y)
    {
        const int WIDTH = 3;
        long[] widths;
        widths = new long[30];
        widths[0] = 1;
        for (int i = 1; i < 30; i++)
            widths[i] = widths[i - 1] * WIDTH;
        var ok = true;
        for (int i = 0; i < 30; i++)
        {
            var a = new int[3];
            var p = (x / widths[i]) % 3;
            var q = (y / widths[i]) % 3;
            a[p]++; a[q]++;
            if (a[2] == 1) return "Impossible";
            if (a[1] == 2 || a[2] == 2) return "Impossible";
            if (a[0] == 2) ok = false;
            else if (!ok) return "Impossible";
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
    }
}
// CUT end
