using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Over9000Rocks
{
    public int countPossibilities(int[] lowerBound, int[] upperBound)
    {
        var n = lowerBound.Length;
        var a = new List<Pair<int, int>>();
        for (int i = 0; i < 1 << n; i++)
        {
            var l = 0;
            var u = 0;
            for (int j = 0; j < n; j++)
            {
                if ((i >> j & 1) == 0) continue;
                l += lowerBound[j];
                u += upperBound[j];
            }
            if (u <= 9000) continue;
            l = Math.Max(l, 9001);
            a.Add(new Pair<int, int>(l, u));
            Debug.WriteLine("{0} {1}", l, u);
        }
        a.Sort();
        var cnt = 0;
        var ptr = 0;
        for (int i = 9000; i < 1000000 * 15 + 2; i++)
        {
            while (ptr < a.Count)
            {
                if (i < a[ptr].x) break;
                else if (i <= a[ptr].y) break;
                else ptr++;
            }
            if (ptr < a.Count && a[ptr].x <= i && i <= a[ptr].y)
            {
                cnt++;
            }
        }
        return cnt;
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
        var a = new int[] { 9000, 100000 };
        var b = new int[] { 9001, 1000000 };
        test.ManualTest(a, b);
    }
}
// CUT end

#region Compair
static public class Pair
{
    static public Pair<FT, ST> Create<FT, ST>(FT f, ST s)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return new Pair<FT, ST>(f, s); }
    static public Pair<FT, ST> Min<FT, ST>(Pair<FT, ST> p, Pair<FT, ST> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return (p.CompareTo(q) <= 0) ? p : q; }
    static public Pair<FT, ST> Max<FT, ST>(Pair<FT, ST> p, Pair<FT, ST> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return (p.CompareTo(q) >= 0) ? p : q; }
}
public struct Pair<FT, ST> : IComparable<Pair<FT, ST>>
    where FT : IComparable<FT>
    where ST : IComparable<ST>
{
    public FT x;
    public ST y;
    public Pair(FT f, ST s) : this() { x = f; y = s; }

    public int CompareTo(Pair<FT, ST> other)
    {
        var cmp = x.CompareTo(other.x);
        return cmp != 0 ? cmp : y.CompareTo(other.y);
    }
    public override string ToString() { return string.Format("{0} {1}", x, y); }
}
#endregion