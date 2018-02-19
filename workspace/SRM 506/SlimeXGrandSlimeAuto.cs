using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using C = System.Int32;
using V = System.Int64;
public class SlimeXGrandSlimeAuto
{
    public int travel(int[] cars, int[] districts, string[] roads, int inverseWalkSpeed, int inverseDriveSpeed)
    {
        var n = roads.Length;
        var g = Enumerate(n, x => new int[n]);
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                g[i][j] = g[j][i] = 1000000;
        var val = new List<char>() { '$' };
        for (char i = '0'; i <= '9'; i++)
            val.Add(i);
        for (char i = 'a'; i <= 'z'; i++)
            val.Add(i);
        for (char i = 'A'; i <= 'Z'; i++)
            val.Add(i);

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < val.Count; k++)
                    if (roads[i][j] == val[k]) g[i][j] = k;
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    g[i][j] = Math.Min(g[i][j], g[i][k] + g[k][j]);
        var vs = districts.ToList(); vs.Insert(0, 0);
        return solve(cars, vs, g, inverseWalkSpeed, inverseDriveSpeed);
    }
    int solve(int[] ca, List<int> di, int[][] g, long u, long v)
    {
        var m = di.Count - 1;
        var n = ca.Length;
        var G = new MinCostFlow(n + m + 2);
        var src = n + m;
        var sink = src + 1;
        for (int i = 0; i < n; i++)
            G.AddDirectedEdge(src, i, 1, 0);
        for (int i = 0; i < m; i++)
            G.AddDirectedEdge(n + i, sink, 1, 0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                var f = di[j];
                var t = di[j + 1];
                var c = ca[i];
                G.AddDirectedEdge(i, n + j, 1, g[f][c] * u + g[c][t] * v);
            }
        }
        for (int j = 0; j < m; j++)
        {
            var f = di[j];
            var t = di[j + 1];
            G.AddDirectedEdge(src, n + j, 1, g[f][t] * u);
        }
        var res = G.Execute(src, sink);
        return (int)res.Value;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] cars, int[] districts, string[] roads, int inverseWalkSpeed, int inverseDriveSpeed)
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
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end


#region MinCostFlow
public class MinCostFlow
{
    bool hasng;
    public readonly List<Edge>[] G;
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

    public KeyValuePair<C, V> Execute(int src, int sink, C f = C.MaxValue, V inf = V.MaxValue / 2)
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

            {
                var vis = new bool[n];
                var pq = new PriorityQueue<KeyValuePair<int, V>>((l, r) => l.Value.CompareTo(r.Value));
                pq.Enqueue(new KeyValuePair<int, V>(src, 0));
                dist[src] = 0;
                while (pq.Count > 0)
                {
                    var p = pq.Dequeue().Key;
                    if (vis[p]) continue;
                    //Debug.WriteLine(p);
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
                    potential[i] = Math.Min(inf, potential[i] + dist[i]);
                C df = f;
                V d = 0;
                for (var v = sink; v != src; v = prev[v])
                {
                    var e = prevEdge[v];
                    df = Math.Min(df, e.Cap); d += e.Cost;
                }
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
    public class Edge
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
#endregion
#region BinaryHeap
public class PriorityQueue<T>
{
    readonly List<T> heap = new List<T>();
    readonly Comparison<T> compare;
    public PriorityQueue() { compare = Comparer<T>.Default.Compare; }

    public PriorityQueue(Comparison<T> comparison) { compare = comparison; }
    public PriorityQueue(IComparer<T> comparer) { compare = comparer.Compare; }

    public void Enqueue(T item)
    {
        var pos = heap.Count;
        heap.Add(item);
        while (pos > 0)
        {
            var par = (pos - 1) / 2;
            if (compare(heap[par], item) <= 0)
                break;
            heap[pos] = heap[par];
            pos = par;
        }
        heap[pos] = item;

    }

    public T Dequeue()
    {
        var ret = heap[0];
        var pos = 0;
        var x = heap[heap.Count - 1];

        while (pos * 2 + 1 < heap.Count - 1)
        {
            var lch = pos * 2 + 1;
            var rch = pos * 2 + 2;
            if (rch < heap.Count - 1 && compare(heap[rch], heap[lch]) < 0) lch = rch;
            if (compare(heap[lch], x) >= 0)
                break;
            heap[pos] = heap[lch];
            pos = lch;
        }
        heap[pos] = x;
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
            Array.Sort(ret, compare);
            return ret;
        }
    }
}
#endregion