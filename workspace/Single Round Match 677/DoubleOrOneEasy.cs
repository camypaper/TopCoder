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

        return solve(a, b, newA, newB);
    }
    public int solve(long a, long b, long newA, long newB)
    {
        var q = new Queue<Triplet<long, long, int>>();
        q.Enqueue(new Triplet<long, long, int>(newA, newB, 0));
        var vis = new HashSet<KeyValuePair<long, long>>();
        while (q.Any())
        {
            var p = q.Dequeue();
            var ta = p.I;
            var tb = p.J;
            var cnt = p.K;
            if (a == ta && b == tb) return cnt;
            if (a > ta || b > tb || vis.Contains(new KeyValuePair<long, long>(ta, tb))) continue;
            vis.Add(new KeyValuePair<long, long>(ta, tb));
            cnt++;
            if (ta % 2 == 0 && tb % 2 == 0)
            {
                q.Enqueue(new Triplet<long, long, int>(ta - 1, tb - 1, cnt));
                q.Enqueue(new Triplet<long, long, int>(ta / 2, tb / 2, cnt));
            }
            else
            {

                q.Enqueue(new Triplet<long, long, int>(ta - 1, tb - 1, cnt));
            }
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
        test.ManualTest(1, 2, 10000000, 1000000000);
    }
}
// CUT end
#region Triplet<ST,FT,TT>
static public class Triplet
{
    static public Triplet<FT, ST, TT> Create<FT, ST, TT>(FT f, ST s, TT t)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
        where TT : IComparable<TT>
    { return new Triplet<FT, ST, TT>(f, s, t); }

    static public Triplet<FT, ST, TT> Max<FT, ST, TT>(Triplet<FT, ST, TT> p, Triplet<FT, ST, TT> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
        where TT : IComparable<TT>
    {
        return p.CompareTo(q) >= 0 ? p : q;
    }
    static public Triplet<FT, ST, TT> Min<FT, ST, TT>(Triplet<FT, ST, TT> p, Triplet<FT, ST, TT> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
        where TT : IComparable<TT>
    {
        return p.CompareTo(q) <= 0 ? p : q;
    }
}
public struct Triplet<FT, ST, TT> : IComparable<Triplet<FT, ST, TT>>
    where FT : IComparable<FT>
    where ST : IComparable<ST>
    where TT : IComparable<TT>
{
    public FT I;
    public ST J;
    public TT K;
    public Triplet(FT i, ST j, TT k) : this() { I = i; J = j; K = k; }
    public int CompareTo(Triplet<FT, ST, TT> other)
    {
        var cmp = I.CompareTo(other.I);
        if (cmp != 0) return cmp;
        cmp = J.CompareTo(other.J);
        if (cmp != 0) return cmp;
        return K.CompareTo(other.K);
    }
    public override string ToString() { return string.Format("{0} {1} {2}", I, J, K); }
}
#endregion