using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int32;
public class StoryFromTCO
{
    public int minimumChanges(int[] places, int[] cutoff)
    {
        Array.Sort(cutoff, places);
        var n = places.Length;
        var G = Enumerate(3 * n + 2, x => new List<Edge<int, int>>());
        var s = 3 * n;
        var t = s + 1;
        for (int i = 0; i < places.Length; i++)
        {
            G.AddDirectedEdge(s, i, 1, 0);
            G.AddDirectedEdge(n + i, 2 * n + i, 1, 0);
            G.AddDirectedEdge(2 * n + i, t, 1, 0);
            if (i + 1 < n) G.AddDirectedEdge(n + i, n + i + 1, 100000, 0);
            if (places[i] <= cutoff[i]) G.AddDirectedEdge(i, 2 * n + i, 1, 0);
            for (int j = 0; j < n; j++)
                if (places[i] <= cutoff[j]) { G.AddDirectedEdge(i, n + j, 1, 1); break; }
        }
        var f = Flow.PrimalDual(G, s, t, n);
        if (f.y != n) return -1;

        return f.x;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] places, int[] cutoff)
    {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        var a = Enumerate(1000, x => x + 1);
        var b = Enumerate(1000, x => x + 1);
        //Tests.Add(() => ManualTest(a, b));
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
public struct Pair<FT, ST>: IComparable<Pair<FT, ST>>
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
#region Integer MinCostFlow
static public partial class Flow
{
    /// <summary>
    /// 最小費用流をprimal-dual法でやる
    /// </summary>
    /// <param name="G">グラフ</param>
    /// <param name="s">始点</param>
    /// <param name="t">終点</param>
    /// <param name="f">流す最大流量</param>
    /// <param name="INF">適当な最大値</param>
    /// <returns>(コスト，流量)</returns>
    static public Pair<int, int> PrimalDual(List<Edge<int, int>>[] G, int s, int t, int f, int INF = 1 << 20)
    {
        var n = G.Length;
        var dist = new int[n];
        var prev = new int[n];
        var prevEdge = new int[n];
        var total = new Pair<int, int>(0, 0);
        var potential = new int[n];
        while (f > 0)
        {
            for (int i = 0; i < n; i++)
                dist[i] = INF;

            {
                var vis = new bool[n];
                var pq = new RadixHeapPriorityQueue<Pair<int, int>>(x => x.x);
                pq.Enqueue(new Pair<int, int>(0, s));
                dist[s] = 0;
                while (pq.Count > 0)
                {
                    var p = pq.Dequeue().y;
                    if (vis[p]) continue;
                    vis[p] = true;
                    for (int i = 0; i < G[p].Count; i++)
                    {
                        var e = G[p][i];
                        if (e.cap <= 0) continue;
                        var j = e.to;
                        var d = dist[p] + e.cost + potential[p] - potential[j];
                        if (dist[j] > d)
                        {
                            dist[j] = d; prev[j] = p; prevEdge[j] = i;
                            pq.Enqueue(new Pair<int, int>(d, j));
                        }
                    }
                }


            }


            //update
            {
                if (dist[t] == INF) break;
                for (int i = 0; i < n; i++)
                    potential[i] += dist[i];
                var d = f; var distt = 0;
                for (var v = t; v != s;)
                {
                    var u = prev[v]; var e = G[u][prevEdge[v]];
                    d = Math.Min(d, e.cap); distt += e.cost; v = u;
                }
                f -= d; total.x += d * distt; total.y += d;
                for (var v = t; v != s; v = prev[v])
                {
                    var e = G[prev[v]][prevEdge[v]];
                    e.cap -= d; G[e.to][e.rev].cap += d;
                }
            }

        }
        return total;
    }
}
#endregion
#region CostEdge
static public class Edge
{
    static public Edge<C, V> Create<C, V>(int t, int r, C _cap, V _cost) { return new Edge<C, V>(t, r, _cap, _cost); }
}
public class Edge<C, V>
{
    public int to, rev;
    public C cap;
    public V cost;
    public Edge(int t, int r, C _cap, V _cost) { to = t; rev = r; cap = _cap; cost = _cost; }
    public override string ToString() { return string.Format("{0}: Capacity {1}, Cost{2}", to, cap, cost); }
}
#endregion

#region AddCostEdge
static public partial class Flow
{
    static public void AddDirectedEdge(this List<Edge<int, int>>[] G, int from, int to, int cap, int cost)
    {
        G[from].Add(Edge.Create(to, G[to].Count, cap, cost));
        G[to].Add(Edge.Create(from, G[from].Count - 1, 0, -cost));
    }
    static public void AddDirectedEdge(this List<Edge<int, double>>[] G, int from, int to, int cap, double cost)
    {
        G[from].Add(Edge.Create(to, G[to].Count, cap, cost));
        G[to].Add(Edge.Create(from, G[from].Count - 1, 0, -cost));
    }

}
#endregion
#region RadixHeap<T>
/// <summary>
/// 突っ込むのが整数でないとき用
/// </summary>
public class RadixHeapPriorityQueue<T>
{
    /// <summary>
    /// コストがlongのときは64
    /// </summary>
    const int SIZE = 32;
    Number last;
    Func<T, Number> get;
    public RadixHeapPriorityQueue(Func<T, Number> f)
    {
        Debug.Assert(
            (sizeof(Number) == sizeof(long) && SIZE == 64) ||
            (sizeof(Number) == sizeof(int) && SIZE == 32));
        Debug.Assert(f != null);
        for (int i = 0; i <= SIZE; i++)
            v[i] = new FastLinkedList<T>();
        get = f;
    }


    static int bsr(long x)
    {
        if (x == 0) return -1;
        else
        {
            var n = 0;
            if (x >> (n + 32) > 0) n += 32;
            if (x >> (n + 16) > 0) n += 16;
            if (x >> (n + 8) > 0) n += 8;
            if (x >> (n + 4) > 0) n += 4;
            if (x >> (n + 2) > 0) n += 2;
            if (x >> (n + 1) > 0) n += 1;
            return n;
        }
    }

    FastLinkedList<T>[] v = new FastLinkedList<T>[SIZE + 1];
    int size;


    public void Enqueue(T item)
    {
        var x = get(item);
        Debug.Assert(last <= x);
        size++;
        v[bsr(x ^ last) + 1].Add(item);
    }
    public T Dequeue()
    {
        if (v[0].Count == 0)
        {
            var i = 1;
            while (v[i].Count == 0) i++;
            var nlast = Number.MaxValue;
            for (FastLinkedList<T>.Node n = v[i].last; n != null; n = n.par)
            {
                var val = get(n.val);
                if (val < nlast) nlast = val;
            }

            while (v[i].Count > 0)
            {
                var val = v[i].Pop();
                v[bsr(get(val) ^ nlast) + 1].Add(val);
            }
            last = nlast;
        }
        size--;
        return v[0].Pop();
    }
    public int Count { get { return size; } }
    public bool Any() { return size > 0; }


    #region FastLinkedList<T>
    private class FastLinkedList<TT>
    {
        int size;
        public Node last;
        public int Count { get { return size; } }
        public void Add(TT item) { last = new Node(item, last); size++; }
        public TT Pop() { var ret = last.val; last = last.par; size--; return ret; }
        public class Node
        {
            public readonly TT val;
            public readonly Node par;
            public Node(TT v, Node p) { val = v; par = p; }
        }
    }
    #endregion
}
#endregion