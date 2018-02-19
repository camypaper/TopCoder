using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RabbitNumber
{
    public int theCount(int low, int high)
    {
        var cnt = 0;
        for (int i = 0; i < 1 << 20; i++)
        {
            long v = 0;
            for (int j = 0; j < 20; j += 2)
            {
                v = v * 10 + (i >> j & 3);
            }
            if (v < low || high < v) continue;
            if (F(v) * F(v) == F(v * v)) cnt++;
        }
        return cnt;
    }
    public int F(long i)
    {
        return i.ToString().Select(x => x - '0').Sum();
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
