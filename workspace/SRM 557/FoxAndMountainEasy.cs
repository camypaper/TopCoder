using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndMountainEasy
{
    public string possible(int n, int h0, int hn, string history)
    {
        if (Math.Abs(100000000 + hn - h0) % 2 != n % 2) return "NO";
        var d = h0;
        var min = h0;
        foreach (var x in history)
        {
            if (x == 'U') d++;
            else d--;
            min = Math.Min(min, d);
        }
        Debug.WriteLine(min);
        Debug.WriteLine(d);
        n -= history.Length;
        if (min < 0)
        {
            n -= Math.Abs(min);
            d += Math.Abs(min);
            min = 0;
        }
        if (n < 0) return "NO";
        var need = Math.Abs(hn - d);
        if (need <= n) return "YES";

        return "NO";
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
