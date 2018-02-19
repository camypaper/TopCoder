using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class HyperKnight
{
    public long countCells(int a, int b, int numRows, int numColumns, int k)
    {
        return f(Math.Min(a, b), Math.Max(a, b), Math.Min(numRows, numColumns), Math.Max(numRows, numColumns), k);
    }
    long f(long a, long b, long R, long C, int k)
    {
        if (k == 2) return 4 * a * a;
        if (k == 3) return (b - a) * a * 8;
        if (k == 4) return a * (R - 2 * b + C - 2 * b) * 2 + (b - a) * (b - a) * 4;
        if (k == 6) return (b - a) * (R - 2 * b + C - 2 * b) * 2;
        if (k == 8) return (R - 2 * b) * (C - 2 * b);
        return 0;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
