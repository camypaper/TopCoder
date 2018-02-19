using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using C = System.Int32;

public class SafeReturn {
    public int minRisk(int N, string[] streets) {
        var n = streets.Length;
        var g = Enumerate(n, x => new int[n]);
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                g[i][j] = g[j][i] = 1000000;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (streets[i][j] != '-') g[i][j] = streets[i][j] - '0';
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    g[i][j] = Math.Min(g[i][j], g[i][k] + g[k][j]);
        var G = new MaxFlow(2 * N + 2);
        var src = 2 * N;
        var sink = src + 1;
        for (int i = 0; i < N; i++) {
            G.AddDirectedEdge(src, i, 1);
            G.AddDirectedEdge(i + N, sink, 1);
        }
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++) {
                if (i == j) continue;
                if (g[0][i + 1] == g[0][j + 1] + g[j + 1][i + 1]) G.AddDirectedEdge(j, N + i, 1);
            }
        return N - G.Execute(src, sink);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int N, string[] streets) {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX {
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester {
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run() {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end

#region MaxFlow
public partial class MaxFlow {
    public readonly List<Edge>[] G;
    readonly int[] lv, iter;
    public MaxFlow(int V) {
        G = new List<Edge>[V];
        lv = new int[V];
        iter = new int[V];
        for (int i = 0; i < G.Length; i++)
            G[i] = new List<Edge>();
    }

    public void AddDirectedEdge(int from, int to, C cap) {
        addEdge(from, to, cap, 0);
    }

    public void AddUndirectedEdge(int from, int to, C cap) {
        addEdge(from, to, cap, cap);
    }
    void addEdge(int f, int t, C c1, C c2) {
        var a = new Edge(t, c1);
        var b = new Edge(f, c2);
        Edge.Link(a, b);
        G[f].Add(a);
        G[t].Add(b);
    }


    public C Execute(int src, int sink, C f = -1) {
        C flow = 0;
        if (f < 0) f = C.MaxValue;
        while (f > 0) {
            bfs(src);
            if (lv[sink] == 0) return flow;
            Array.Clear(iter, 0, iter.Length);
            C df;
            while ((df = dfs(src, sink, f)) > 0) { flow += df; f -= df; }
        }
        return flow;
    }

    void bfs(int s) {
        Array.Clear(lv, 0, lv.Length);
        var q = new Queue<int>();
        lv[s] = 1;
        q.Enqueue(s);
        while (q.Count > 0) {
            var v = q.Dequeue();
            foreach (var e in G[v])
                if (e.Cap > 0 && lv[e.To] == 0) {
                    lv[e.To] = lv[v] + 1;
                    q.Enqueue(e.To);
                }
        }

    }
    C dfs(int v, int t, C f) {
        if (v == t) return f;
        C ret = 0;
        for (; iter[v] < G[v].Count; iter[v]++) {
            var e = G[v][iter[v]];
            if (e.Cap <= 0 || lv[v] >= lv[e.To]) continue;
            C df = dfs(e.To, t, Math.Min(f, e.Cap));
            if (df <= 0) continue;
            e.Cap -= df;
            e.Rev.Cap += df;
            ret += df; f -= df;
            if (f == 0) break;
        }
        return ret;

    }
}
public class Edge {
    public static void Link(Edge e1, Edge e2) {
        e1.Rev = e2; e2.Rev = e1;
    }
    public int To { get; private set; }
    public Edge Rev { get; private set; }
    public C Cap { get; set; }
    public Edge(int t, C c) {
        To = t;
        Cap = c;
    }
    public override string ToString() {
        return string.Format("to: {0}, cap: {1}", To, Cap);
    }
}
#endregion