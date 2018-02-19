using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SkiResorts
{
    public long minCost(string[] road, int[] altitude)
    {
        var xs = altitude.Distinct().ToList();
        xs.Sort();
        var n = road.Length;
        var m = xs.Count;
        var dp = Enumerate(n, x => new long[m]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                dp[i][j] = 1L << 58;
        for (int i = 0; i < m; i++)
            dp[0][i] = Math.Abs(altitude[0] - xs[i]);
        var pq = new PriorityQueue<Triplet<long, int, int>>();
        for (int i = 0; i < m; i++)
            pq.Enqueue(new Triplet<long, int, int>(dp[0][i], 0, i));
        while (pq.Any())
        {
            var p = pq.Dequeue();
            var cost = p.I;
            var pos = p.J;
            var hei = p.K;
            if (dp[pos][hei] < cost) continue;
            for (int i = 0; i < n; i++)
            {
                if (road[pos][i] == 'N') continue;
                for (int j = 0; j <= hei; j++)
                {
                    var add = Math.Abs(altitude[i] - xs[j]);
                    if (dp[i][j] > cost + add)
                    {
                        dp[i][j] = cost + add;
                        pq.Enqueue(new Triplet<long, int, int>(dp[i][j], i, j));
                    }
                }
            }
        }
        var min = dp[n - 1].Min();
        if (min >= 1L << 58) return -1;
        return min;
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
#region PriorityQueue and PairingHeap
public class PriorityQueue<T>
{
    PairingHeap<T> top;
    Comparison<T> compare;
    int size;
    public int Count { get { return size; } }
    public PriorityQueue() : this(Comparer<T>.Default) { }
    public PriorityQueue(Comparison<T> comparison) { compare = comparison; }
    public PriorityQueue(IComparer<T> comparer) { compare = comparer.Compare; }
    public void Enqueue(T item)
    {
        var heap = new PairingHeap<T>(item);
        top = PairingHeap<T>.Merge(top, heap, compare);
        size++;
    }
    public T Dequeue()
    {
        var ret = top.Key;
        size--;
        top = PairingHeap<T>.Pop(top, compare);
        return ret;
    }
    public bool Any() { return size > 0; }
    public T Peek() { return top.Key; }
}

#region PairingHeap
public class PairingHeap<T>
{
    public PairingHeap(T k) { key = k; }
    private readonly T key;
    public T Key { get { return key; } }
    private PairingHeap<T> head;
    private PairingHeap<T> next;
    static public PairingHeap<T> Pop(PairingHeap<T> s, Comparison<T> compare)
    {
        return MergeLst(s.head, compare);
    }
    static public PairingHeap<T> Merge(PairingHeap<T> l, PairingHeap<T> r, Comparison<T> compare)
    {
        if (l == null || r == null) return l == null ? r : l;
        if (compare(l.key, r.key) > 0) Swap(ref l, ref r);
        r.next = l.head;
        l.head = r;
        return l;
    }
    static public PairingHeap<T> MergeLst(PairingHeap<T> s, Comparison<T> compare)
    {
        var n = new PairingHeap<T>(default(T));
        while (s != null)
        {
            PairingHeap<T> a = s, b = null;
            s = s.next; a.next = null;
            if (s != null) { b = s; s = s.next; b.next = null; }
            a = Merge(a, b, compare); a.next = n.next;
            n.next = a;
        }
        while (n.next != null)
        {
            var j = n.next;
            n.next = n.next.next;
            s = Merge(j, s, compare);
        }
        return s;
    }
    static void Swap(ref PairingHeap<T> l, ref PairingHeap<T> r) { var t = l; l = r; r = t; }
}
#endregion
#endregion

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