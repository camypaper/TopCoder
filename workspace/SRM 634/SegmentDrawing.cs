using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using C = System.Int32;
using Point = System.Numerics.Complex;

public class SegmentDrawing
{
    public int maxScore(int[] x, int[] y, int[] redScore, int[] blueScore)
    {
        var n = x.Length;
        var G = Enumerate(n * n * 2 + 2, t => new List<Edge>());
        var src = n * n * 2;
        var sink = src + 1;
        var p = Enumerate(n, i => new Point(x[i], y[i]));
        var sum = 0;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                sum += redScore[i * n + j] + blueScore[i * n + j];
                G.AddDirectedEdge(src, i * n + j, redScore[i * n + j]);
                G.AddDirectedEdge(i * n + j, n * n + i * n + j, 1000000000);
                G.AddDirectedEdge(n * n + i * n + j, sink, blueScore[i * n + j]);

                var u = new Line(p[i], p[j]);
                for (int k = 0; k < n; k++)
                    for (int l = k + 1; l < n; l++)
                    {
                        if (i == k && j == l) continue;
                        var v = new Line(p[k], p[l]);
                        if (Geometry.InterSect.IntersectSegmentSegment(u, v))
                            G.AddDirectedEdge(i * n + j, n * n + k * n + l, 1000000000);
                    }

            }
        var ans = sum - Flow.GetMaxFlow(G, src, sink);
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] x, int[] y, int[] redScore, int[] blueScore)
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
#region Line
public struct Line
{
    public Point P, Q;
    public Point this[int index]
    {
        get
        {
            if (index == 0) return P;
            if (index == 1) return Q;
            throw new IndexOutOfRangeException("0 or 1");
        }
        set
        {
            if (index == 0) P = value;
            if (index == 1) Q = value;
            throw new IndexOutOfRangeException("0 or 1");
        }
    }
    public Line(Point a, Point b) : this() { P = a; Q = b; }
}
#endregion

#region Functions
static public partial class Geometry
{
    public const double EPS = 1e-8;
    static public double Cross(Point a, Point b)
    {
        return (Point.Conjugate(a) * b).Imaginary;
    }
    static public double Dot(Point a, Point b)
    {
        return (Point.Conjugate(a) * b).Real;
    }
    static public int CCW(Point a, Point b, Point c)
    {
        b -= a; c -= a;
        if (Cross(b, c) > 0) return 1;//CCW
        if (Cross(b, c) < 0) return -1;//CW
        if (Dot(b, c) < 0) return 2;//C-A-B
        if (b.Magnitude < c.Magnitude) return -2;//A-B-C
        return 0;
    }
    static public int Compare(Point a, Point b)
    {
        if (a.Real != b.Real)
            return (a.Real > b.Real) ? 1 : -1;
        else if (a.Imaginary != b.Imaginary)
            return a.Imaginary > b.Imaginary ? 1 : -1;
        return 0;
    }
    static public double Norm(Point p)
    {
        return p.Magnitude * p.Magnitude;
    }
}
#endregion
#region Intersect
static public partial class Geometry
{
    static public partial class InterSect
    {
        static public bool IntersectLineLine(Line a, Line b)
        {
            return Math.Abs(Cross(a.Q - a.P, b.Q - b.P)) > EPS ||
                Math.Abs(Cross(a.Q - a.P, b.Q - b.P)) < EPS;
        }
        static public bool IntersectLineSegment(Line l, Line s)
        {
            return Cross(l.Q - l.P, s.P - l.P) * Cross(l.Q - l.P, s.Q - l.P) < EPS;
        }
        static public bool IntersectSegmentSegment(Line a, Line b)
        {
            return CCW(a.P, a.Q, b.P) * CCW(a.P, a.Q, b.Q) <= 0 && CCW(b.P, b.Q, a.P) * CCW(b.P, b.Q, a.Q) <= 0;
        }
        static public bool IntersectSegmentPoint(Line s, Point p)
        {
            return (s.P - p).Magnitude + (s.Q - p).Magnitude - (s[1] - s[0]).Magnitude < EPS;
        }
    }
}
#endregion