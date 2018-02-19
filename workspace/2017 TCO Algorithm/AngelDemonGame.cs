using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;

using C = System.Int32;
using V = System.Int32;

public class AngelDemonGame
{
    public string winner(string[] G, int A, int D)
    {
        var n = G.Length;
        if (D >= n - 1) return "Demon";
        var g = new MinCostFlow(n);
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                if (G[i][j] == 'Y')
                {
                    g.AddDirectedEdge(i, j, 1, 0);
                    g.AddDirectedEdge(j, i, 1, 0);
                }
                else
                {
                    g.AddDirectedEdge(i, j, 1, 1);
                    g.AddDirectedEdge(j, i, 1, 1);
                }
            }
        var fc = g.Execute(0, n - 1, A);
        if (fc.Key > D) return "Angel";
        return "Unknown";
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(string[] G, int A, int D)
    {
        return "";
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
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end



/// <summary>
/// 辺の追加を行い，最小費用流を求めることが可能なグラフです．
/// </summary>
public class MinCostFlow
{
    bool hasng;
    readonly List<Edge>[] G;
    public MinCostFlow(int V)
    {
        G = new List<Edge>[V];
        for (int i = 0; i < V; i++)
            G[i] = new List<Edge>();

    }
    public void AddDirectedEdge(int from, int to, C cap, V cost)
    {
        addEdge(from, to, cap, 0, cost);
    }

    public KeyValuePair<C, V> Execute(int src, int sink, V x, C f = C.MaxValue, V inf = V.MaxValue / 20)
    {
        var n = G.Length;
        var dist = new V[n];
        var prev = new int[n];
        var prevEdge = new Edge[n];
        var potential = new V[n];


        C flow = 0;
        V cost = 0;
        var first = hasng;
        while (f > 0)
        {
            for (int i = 0; i < G.Length; i++)
                dist[i] = inf;

            //shortest path
            if (first)//spfa
            {
                var q = new Queue<int>();
                q.Enqueue(src); dist[src] = 0;
                var inQ = new bool[n];
                while (q.Count > 0)
                {
                    var p = q.Dequeue();
                    inQ[p] = false;
                    foreach (var e in G[p])
                    {
                        var t = e.To;
                        var d = dist[p] + e.Cost;
                        if (e.Cap > 0 && d < dist[t])
                        {
                            if (!inQ[t])
                            {
                                inQ[t] = true;
                                q.Enqueue(t);
                            }
                            dist[t] = d; prev[t] = p; prevEdge[t] = e;
                        }
                    }
                }
                first = false;
            }
            else//dijkstra
            {
                var vis = new bool[n];
                var pq = new PriorityQueue<KeyValuePair<int, V>>((l, r) => l.Value.CompareTo(r.Value));
                pq.Enqueue(new KeyValuePair<int, V>(src, 0));
                dist[src] = 0;
                while (pq.Count > 0)
                {
                    var p = pq.Dequeue().Key;
                    if (vis[p]) continue;
                    vis[p] = true;
                    foreach (var e in G[p])
                    {
                        if (e.Cap <= 0) continue;
                        var t = e.To;
                        if (vis[t]) continue;
                        var d = dist[p] + e.Cost + potential[p] - potential[t];
                        if (dist[t] > d)
                        {
                            dist[t] = d; prev[t] = p; prevEdge[t] = e;
                            pq.Enqueue(new KeyValuePair<int, V>(t, d));
                        }
                    }
                }


            }


            //update
            {
                if (dist[sink] == inf) break;
                for (int i = 0; i < n; i++)
                    potential[i] += dist[i];
                C df = f;
                V d = 0;
                for (var v = sink; v != src; v = prev[v])
                {
                    var e = prevEdge[v];
                    df = Math.Min(df, e.Cap); d += e.Cost;
                }
                if (cost + df * d > x) break;
                f -= df; cost += df * d; flow += df;
                for (var v = sink; v != src; v = prev[v])
                {
                    var e = prevEdge[v];
                    e.Cap -= df; e.Rev.Cap += df;
                }
            }

        }
        return new KeyValuePair<C, V>(flow, cost);
    }
    void addEdge(int f, int t, C c1, C c2, V e)
    {
        if (e < 0) hasng = true;
        var a = new Edge(t, c1, e);
        var b = new Edge(f, c2, -e);
        Edge.Link(a, b);
        G[f].Add(a);
        G[t].Add(b);
    }
    class Edge
    {
        public static void Link(Edge e1, Edge e2)
        {
            e1.Rev = e2; e2.Rev = e1;
        }
        public int To { get; private set; }
        public Edge Rev { get; private set; }
        public V Cost { get; private set; }
        public C Cap { get; set; }
        public Edge(int t, C c, V e)
        {
            To = t;
            Cap = c;
            Cost = e;
        }
        public override string ToString()
        {
            return string.Format("to: {0}, cap: {1}", To, Cap);
        }
    }
}

class cmp<T>: IComparer<T>
{
    Comparison<T> f;
    public cmp(Comparison<T> cmp)
    {
        f = cmp;
    }
    public int Compare(T x, T y)
    {
        return f(x, y);
    }
}

#region BinaryHeap
public class PriorityQueue<T>
{
    readonly List<T> heap = new List<T>();
    readonly IComparer<T> cmp;

    public PriorityQueue() { cmp = Comparer<T>.Default; }
    public PriorityQueue(Comparison<T> f) { cmp = new cmp<T>(f); }
    public PriorityQueue(IComparer<T> c) { cmp = c; }
    public void Enqueue(T item)
    {

        var i = heap.Count;
        heap.Add(item);
        while (i > 0)
        {
            var p = (i - 1) / 2;
            if (cmp.Compare(heap[p], item) <= 0)
                break;
            heap[i] = heap[p];
            i = p;
        }
        heap[i] = item;

    }
    public T Dequeue()
    {
        var ret = heap[0];
        var i = 0;
        var x = heap[heap.Count - 1];

        while ((i * 2) + 1 < heap.Count - 1)
        {
            var a = i * 2 + 1;
            var b = i * 2 + 2;
            if (b < heap.Count - 1 && cmp.Compare(heap[b], heap[a]) < 0) a = b;
            if (cmp.Compare(heap[a], x) >= 0)
                break;
            heap[i] = heap[a];
            i = a;
        }
        heap[i] = x;
        heap.RemoveAt(heap.Count - 1);
        return ret;

    }
    public T Peek() { return heap[0]; }
    public int Count { get { return heap.Count; } }
    public bool Any() { return heap.Count > 0; }
    public T[] Items
    {
        get
        {
            var ret = heap.ToArray();
            Array.Sort(ret, cmp);
            return ret;
        }
    }
}
#endregion