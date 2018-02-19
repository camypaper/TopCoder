using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RailroadSwitchOperator
{
    public int minEnergy(int N, int[] to, int[] from)
    {
        var n = to.Length;
        var k = 0;
        while (1 << (k + 1) <= N) k++;

        for (int i = 0; i < n; i++)
            to[i]--;
        var go = new int[1 << 19];
        var f = Enumerate(1 << 19, x => -1);
        var task = new List<Pair<int, int>>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                var pos = (1 << j) + (to[i] >> (k - j));
                var ns = (to[i] >> (k - j - 1)) & 1;
                if (go[pos] != ns)
                {
                    task.Add(new Pair<int, int>(from[i] + j, f[pos] + 1));
                }
                go[pos] = ns;
                f[pos] = from[i] + j;
            }
        }
        task.Sort();
        var cnt = 0;
        var last = -1;
        foreach (var x in task)
        {
            Debug.WriteLine(x);
            if (x.y > last)
            {
                Debug.WriteLine(x.y);
                last = x.x; cnt++;

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