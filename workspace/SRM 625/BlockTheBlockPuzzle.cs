using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BlockTheBlockPuzzle
{
    public int minimumHoles(string[] board)
    {
        var n = board.Length;
        var m = board[0].Length;
        var G = Enumerate(2 * n * m + 2, x => new List<Edge<int>>());
        var src = 2 * n * m;
        var sink = src + 1;
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        int px = -1, py = -1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (board[i][j] == '$') { px = i; py = j; }

        for (int i = 0; i < n; i++)
        {
            if (Math.Abs(i - px) % 3 != 0) continue;
            for (int j = 0; j < m; j++)
            {
                if (Math.Abs(j - py) % 3 != 0) continue;

                switch (board[i][j])
                {
                    case 'b':
                        G.AddDirectedEdge(src, i * m + j, 100000);
                        G.AddDirectedEdge(i * m + j, n * m + i * m + j, 100000);
                        break;
                    case '$':
                        G.AddDirectedEdge(n * m + i * m + j, sink, 100000);
                        G.AddDirectedEdge(i * m + j, n * m + i * m + j, 100000);
                        break;
                    case '.':
                        G.AddDirectedEdge(i * m + j, n * m + i * m + j, 1);
                        break;
                    case 'H': break;
                    default:
                        break;
                }
                for (int d = 0; d < 4; d++)
                {
                    var nx = i + dx[d] * 3;
                    var ny = j + dy[d] * 3;
                    if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
                    var a = board[i][j];
                    var b = board[nx][ny];
                    if (a == 'H' || b == 'H') continue;
                    var bcnt = 0;
                    var hcnt = 0;
                    for (int nnx = Math.Min(i, nx); nnx <= Math.Max(i, nx); nnx++)
                        for (int nny = Math.Min(j, ny); nny <= Math.Max(j, ny); nny++)
                        {
                            if (board[nnx][nny] == 'b') bcnt++;
                            if (board[nnx][nny] == 'H') hcnt++;
                        }
                    if (a == 'b') bcnt--;
                    if (b == 'b') bcnt--;

                    var cap = 2 - hcnt;
                    if (bcnt > 0) cap = 100000;
                    G.AddDirectedEdge(n * m + i * m + j, nx * m + ny, cap);


                }
            }
        }

        var ans = Flow.GetMaxFlow(G, src, sink);
        if (ans > 1000) return -1;
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] board)
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
    }
}
// CUT end

#region Edge
public class Edge<T>
{
    public int to, rev;
    public T cap;
    public Edge(int t, int r, T _cap) { to = t; rev = r; cap = _cap; }
    public override string ToString() { return string.Format("{0}: Capacity {1}", to, cap); }
}
#endregion
#region AddEdge
static public partial class Flow
{
    static public void AddDirectedEdge(this List<Edge<int>>[] G, int from, int to, int cap)
    {
        G[from].Add(new Edge<int>(to, G[to].Count, cap));
        G[to].Add(new Edge<int>(from, G[from].Count - 1, 0));
    }
    static public void AddUndirectedEdge(this List<Edge<int>>[] G, int from, int to, int cap)
    {
        G[from].Add(new Edge<int>(to, G[to].Count, cap));
        G[to].Add(new Edge<int>(from, G[from].Count - 1, cap));
    }
    static public void AddDirectedEdge(this List<Edge<long>>[] G, int from, int to, long cap)
    {
        G[from].Add(new Edge<long>(to, G[to].Count, cap));
        G[to].Add(new Edge<long>(from, G[from].Count - 1, 0));
    }
    static public void AddUndirectedEdge(this List<Edge<long>>[] G, int from, int to, long cap)
    {
        G[from].Add(new Edge<long>(to, G[to].Count, cap));
        G[to].Add(new Edge<long>(from, G[from].Count - 1, cap));
    }
}
#endregion


//MaxFlow
#region Dinic
static public partial class Flow
{
    static public int GetMaxFlow(List<Edge<int>>[] G, int s, int t, int INF = -1)
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
            while (q.Any())
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


        Func<int, int, int, int> dfs = null;
        dfs = (v, u, f) =>
        {
            if (v == t) return f;
            for (; iter[v] < G[v].Count; iter[v]++)
            {
                var e = G[v][iter[v]];
                if (e.cap <= 0 || level[v] >= level[e.to]) continue;
                var d = dfs(e.to, u, Math.Min(f, e.cap));
                if (d <= 0) continue;
                e.cap -= d;
                G[e.to][e.rev].cap += d;
                return d;
            }
            return 0;
        };


        var flow = 0;
        if (INF == -1)
        {
            while (true)
            {
                bfs(s);
                if (level[t] == 0) return flow;
                Array.Clear(iter, 0, iter.Length);
                int f;
                while ((f = dfs(s, t, 1 << 30)) > 0) { flow += f; }
            }
        }
        else
        {
            while (INF > 0)
            {
                bfs(s);
                if (level[t] == 0) return flow;
                Array.Clear(iter, 0, iter.Length);
                int f;
                while ((f = dfs(s, t, 1 << 30)) > 0) { flow += f; INF -= f; }
            }
            return flow;
        }
    }
}
#endregion