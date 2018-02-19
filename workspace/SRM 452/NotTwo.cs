using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NotTwo
{
    public int maxStones(int width, int height)
    {
        var ans = 0;
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                ans += (((width + i) / 2) * ((height + j) / 2) + 1) / 2;
            }



        return ans;
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
        test.ManualTest(530, 701);
        test.ManualTest(18, 6);
        test.ManualTest(6, 6);
        test.ManualTest(998, 998);
    }
}
// CUT end
