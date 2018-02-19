using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FleaCircus
{
    public int countArrangements(string[] afterFourClicks)
    {
        var k = 4;
        var a = 5;
        var b = 8;
        long res = 0;
        long l = k;
        long r = k % 2 == 1 ? k : k + 1;
        while (true)
        {
            if (b < l) break;
            var L = Math.Max(l, a);
            var R = Math.Min(r, b);
            res += Math.Max(0, r - l + 1);
            l <<= 1;
            if (l <= r) l = r + 1;
            r <<= 1; r++;

        }
        Debug.WriteLine(res);
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
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
