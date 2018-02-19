using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DoubleOrOneEasy
{
    public int minimalSteps(int a, int b, int newA, int newB)
    {
        if (a > b) { Swap(ref a, ref b); Swap(ref newA, ref newB); }
        return solve(a, b, newA, newB);
    }
    public int solve(long a, long b, long U, long V)
    {
        var ret = long.MaxValue;
        for (int i = 0; i < 30; i++)
        {
            long cost = 0;
            var u = a; var v = b;
            if ((U >> i) < u) break;
            cost += ((U >> i) - u);
            v += cost;
            u = U >> i;
            for (int j = i - 1; j >= 0; j--)
            {
                u *= 2;
                v *= 2;
                cost += 1;
                if ((U >> j & 1) == 1)
                {
                    u += 1;
                    v += 1;
                    cost += 1;
                }
            }
            if (u != U) throw new Exception();
            if (v == V) ret = Math.Min(ret, cost);
        }
        if (ret == long.MaxValue) return -1;
        return (int)ret;
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
