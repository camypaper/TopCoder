using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CuttingGrass
{
    public int theMin(int[] init, int[] grow, int H)
    {
        var n = init.Length;
        if (init.Sum() <= H) return 0;
        var a = new Pair<int, int>[n];
        for (int i = 0; i < n; i++)
        {
            a[i].x = grow[i];
            a[i].y = init[i];
        }
        Array.Sort(a);
        for (int d = 1; d <= n; d++)
        {
            var dp = Enumerate(n + 1, x => new long[d + 2]);
            for (int i = 0; i <= n; i++)
                for (int j = 0; j < d + 2; j++)
                    dp[i][j] = 1L << 60;
            dp[0][0] = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= d; j++)
                {
                    dp[i + 1][j + 1] = Math.Min(dp[i + 1][j + 1], dp[i][j] + (d - 1 - j) * a[i].x);
                    dp[i + 1][j] = Math.Min(dp[i + 1][j], dp[i][j] + d * a[i].x + a[i].y);
                }
            }

            if (dp[n][d] <= H) return d;
        }
        return -1;
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