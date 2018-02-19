using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using C = System.Int32;
public class DengklekGaneshAndChains
{
    public string getBestChains(string[] chains, int[] lengths)
    {
        var otaku = Naive_Test(chains.ToArray(), lengths.ToArray());
        var n = chains.Length;
        var k = chains[0].Length;
        for (int i = 0; i < n; i++)
            chains[i] += chains[i];
        var s = Enumerate(n, x => new string[k]);
        for (int i = 0; i < n; i++)
        {
            for (int l = 1; l <= k; l++)
            {
                for (int j = 0; j < k; j++)
                {
                    var t = chains[i].Substring(j, l);
                    if (s[i][l - 1] == null || string.CompareOrdinal(s[i][l - 1], t) < 0) s[i][l - 1] = t;
                }
            }
        }
        var xs = Enumerate(k, x => new List<string>());
        for (int i = 0; i < n; i++)
            for (int l = 0; l < k; l++)
                xs[l].Add(s[i][l]);

        for (int i = 0; i < k; i++)
        {
            xs[i].Sort();
        }

        var v = Enumerate(n, x => new int[k]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < k; j++)
                v[i][j] = xs[j].BinarySearch(s[i][j]);

        var m = lengths.Length;
        var ans = new int[m];
        for (int pos = 0; pos < m; pos++)
        {
            var l = 0; var r = n;
            while (r - l > 1)
            {
                var x = (l + r) / 2;
                ans[pos] = x;
                var G = Enumerate(n + m + 2, y => new List<Edge>());
                var src = n + m;
                var sink = src + 1;
                for (int i = 0; i < n; i++)
                    G.AddDirectedEdge(src, i, 1);
                for (int i = 0; i < m; i++)
                    G.AddDirectedEdge(n + i, sink, 1);
                //x = n - 1;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j <= pos; j++)
                    {
                        var len = lengths[j] - 1;
                        if (v[i][len] >= ans[j]) G.AddDirectedEdge(i, n + j, 1);
                    }
                var f = Flow.GetMaxFlow(G, src, sink);
                if (f == pos + 1) l = x;
                else r = x;

            }
            ans[pos] = l;

        }
        var anss = new string[m];
        for (int i = 0; i < m; i++)
            anss[i] = xs[lengths[i] - 1][ans[i]];
        Debug.WriteLine(anss.AsJoinedString(""));
        var ret = anss.AsJoinedString("");
        if (ret != otaku)
        {

        }
        return ret;
    }


    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(string[] chains, int[] lengths)
    {
        var ans = "";
        var s = new List<string>();
        foreach (var x in chains)
        {
            var max = x;
            var v = x;
            for (int i = 0; i < x.Length; i++)
            {
                v = v.Substring(1) + v[0];
                if (string.CompareOrdinal(max, v) < 0) max = v;
            }
            s.Add(max);
            Debug.WriteLine(max);
        }
        foreach (var x in lengths)
        {
            s.Sort((l, r) =>
            {
                var sl = l.Substring(0, x);
                var sll = l.Substring(x);
                var sr = r.Substring(0, x);
                var srr = r.Substring(x);
                var cmp = string.CompareOrdinal(sr, sl);
                if (cmp != 0) return cmp;
                return string.CompareOrdinal(sll, srr);

            });
            ans += s[0].Substring(0, x);
            s = s.Skip(1).ToList();
        }
        return ans;
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
        var n = 50;
        var k = 50;
        var s = Enumerate(n, x => "");
        for (int i = 0; i < n; i++)
            for (int j = 0; j < k; j++)
            {
                var x = rand.Next() % 26;
                s[i] += (char)(x + 'a');
            }
        var len = Enumerate(50, x => rand.Next() % k + 1);
        ManualTest(s, len);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
#region Edge
public class Edge
{
    public int to, rev;
    public C cap;
    public Edge(int t, int r, C _cap) { to = t; rev = r; cap = _cap; }
    public override string ToString() { return string.Format("{0}: Capacity {1}", to, cap); }
}
#endregion
#region AddEdge
static public partial class Flow
{
    static public void AddDirectedEdge(this List<Edge>[] G, int from, int to, C cap)
    {
        G[from].Add(new Edge(to, G[to].Count, cap));
        G[to].Add(new Edge(from, G[from].Count - 1, 0));
    }
    static public void AddUndirectedEdge(this List<Edge>[] G, int from, int to, int cap)
    {
        G[from].Add(new Edge(to, G[to].Count, cap));
        G[to].Add(new Edge(from, G[from].Count - 1, cap));
    }
}
#endregion


//MaxFlow
#region Dinic
static public partial class Flow
{
    static public C GetMaxFlow(List<Edge>[] G, int s, int t, C INF = -1)
    {
        var n = G.Length;
        var level = new int[n];
        var iter = new int[n];


        Action<int> bfs = p =>
        {
            Array.Clear(level, 0, n);
            var q = new Queue<int>();
            level[s] = 1;
            q.Enqueue(s);
            while (q.Count > 0)
            {
                var v = q.Dequeue();
                foreach (var e in G[v])
                    if (e.cap > 0 && level[e.to] == 0)
                    {
                        level[e.to] = level[v] + 1;
                        q.Enqueue(e.to);
                    }
            }
        };


        Func<int, int, C, C> dfs = null;
        dfs = (v, u, f) =>
        {
            if (v == t) return f;
            var ret = 0;
            for (; iter[v] < G[v].Count; iter[v]++)
            {
                var e = G[v][iter[v]];
                if (e.cap <= 0 || level[v] >= level[e.to]) continue;
                var d = dfs(e.to, u, Math.Min(f, e.cap));
                if (d <= 0) continue;
                e.cap -= d;
                G[e.to][e.rev].cap += d;
                ret += d; f -= d;
                if (f == 0) break;
            }
            return ret;
        };


        C flow = 0;
        if (INF == -1) INF = C.MaxValue;
        while (INF > 0)
        {
            bfs(s);
            if (level[t] == 0) return flow;
            Array.Clear(iter, 0, iter.Length);
            C f;
            while ((f = dfs(s, t, INF)) > 0) { flow += f; }
        }
        return flow;

    }
}
#endregion