using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MonsterFarm
{
    public int numMonsters(string[] transforms)
    {
        var n = transforms.Length;
        var G = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            var a = transforms[i].Split().Select(int.Parse).ToArray();
            foreach (var x in a)
                G[i, x - 1]++;
        }
        var scc = new SCCGraph(n);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (G[i, j] > 0)
                    scc.AddEdge(i, j, G[i, j]);
            }
        }
        scc.Build();
        var m = scc.Size;
        var dp = new ModInteger[m];
        for (int i = 0; i < m; i++)
            dp[i].num = -1;

        int ans = -114514;
        Func<int, ModInteger> dfs = null;
        dfs = pos =>
          {
              if (dp[pos].num >= 0)
                  return dp[pos];
              ModInteger ret = 0;
              var ok = false;
              foreach (var x in scc.G[pos])
              {
                  ret += dfs(x.to) * x.cost;
                  ok = true;
              }
              if (ok && scc.L[pos].Count > 0)
              {
                  ans = -1;
              }
              if (scc.L[pos].Count > scc.S[pos].Count)
              {
                  ans = -1;
              }
              foreach (var x in scc.L[pos])
                  if (x.cost > 1)
                      ans = -1;
              if (!ok) return dp[pos] = 1;

              return dp[pos] = ret;
          };
        for (int i = 0; i < m; i++)
        {
            if (!scc.S[i].Contains(0)) continue;
            dfs(i);
            if (ans == -1) return -1;
            return (int)dfs(i).num;
        }

        return 1145141919;
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
        var a = new string[] { "2 2 2 2 2 2 2 2 2 2 11", "3 3 3 3 3 3 3 3 3 3", "4 4 4 4 4 4 4 4 4 4", "5 5 5 5 5 5 5 5 5 5", "6 6 6 6 6 6 6 6 6 6", "7 7 7 7 7 7 7 7 7 7", "8 8 8 8 8 8 8 8 8 8", "9 9 9 9 9 9 9 9 9 9", "10 10 10 10 10 10 10 10 10 10", "10", "10 10 10 10 10 10 10" };
        test.ManualTest(a);
    }
}
// CUT end
#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
}
#endregion

#region Edge
public struct Edge : IComparable<Edge>
{
    public int from, to, id;
    public long cost;
    public Edge(int f, int t) : this() { from = f; to = t; cost = 0; id = -1; }
    public Edge(int f, int t, long v) : this() { from = f; to = t; cost = v; id = -1; }
    public Edge(int f, int t, long v, int idx) : this() { from = f; to = t; cost = v; id = idx; }
    public override string ToString() { return string.Format("{0}->{1}:{2} id:{3}", from, to, cost, id); }
    public int CompareTo(Edge other)
    {
        var cmp = cost.CompareTo(other.cost);
        if (cmp != 0) return cmp;
        cmp = to.CompareTo(other.to);
        if (cmp != 0) return cmp;
        cmp = from.CompareTo(other.from);
        return id.CompareTo(other.id);
    }
}
#endregion

#region  StronglyConnectedComponentsDecomposition
public class SCCGraph
{
    List<Edge>[] g, rg;
    int[] group;
    /// <summary>分解後の有向辺</summary>
    public List<Edge>[] G;
    /// <summary>分解後のループ</summary>
    public List<Edge>[] L;
    /// <summary>分解後の頂点に含まれる元の頂点</summary>
    public List<int>[] S;
    public int Size { get { return G.Length; } }
    public SCCGraph(int n)
    {
        g = new List<Edge>[n];
        rg = new List<Edge>[n];
        for (int i = 0; i < n; i++)
        {
            g[i] = new List<Edge>();
            rg[i] = new List<Edge>();
        }

    }
    public void AddEdge(int f, int t, long cost = 0)
    {
        g[f].Add(new Edge(f, t, cost));
        rg[t].Add(new Edge(t, f, cost));
    }
    private int Decomposite()
    {
        var n = g.Length;
        var vs = new List<int>(n);



        //dfs
        {
            var iter = new int[n];
            var used = new bool[n];

            for (int i = 0; i < used.Length; i++)
            {
                if (used[i]) continue;

                var stack = new Stack<int>();
                stack.Push(i);
                used[i] = true;
                while (stack.Any())
                {
                    var p = stack.Peek();
                    while (iter[p] < g[p].Count && used[g[p][iter[p]].to]) iter[p]++;
                    if (iter[p] < g[p].Count)
                    {
                        var to = g[p][iter[p]].to;
                        used[to] = true;
                        stack.Push(to);
                    }
                    else
                    {
                        vs.Add(p); stack.Pop();
                    }
                }
            }
        }
        //rdfs
        {
            var iter = new int[n];
            var used = new bool[n];
            group = new int[n];
            var k = 0;
            for (int i = vs.Count - 1; i >= 0; i--)
            {
                if (used[vs[i]]) continue;
                var stack = new Stack<int>();
                stack.Push(vs[i]);
                used[vs[i]] = true;
                group[vs[i]] = k;
                while (stack.Any())
                {
                    var p = stack.Peek();
                    while (iter[p] < rg[p].Count && used[rg[p][iter[p]].to]) iter[p]++;
                    if (iter[p] < rg[p].Count)
                    {
                        var to = rg[p][iter[p]].to;
                        used[to] = true;
                        group[to] = k;
                        stack.Push(to);
                    }
                    else stack.Pop();
                }
                k++;
            }
            return k;
        }


    }
    public void Distinct()
    {
        for (int i = 0; i < G.Length; i++)
        {
            G[i] = G[i].Distinct().ToList();
            L[i] = L[i].Distinct().ToList();
        }

    }
    public void Build()
    {
        var k = Decomposite();
        G = new List<Edge>[k];
        L = new List<Edge>[k];
        S = new List<int>[k];
        for (int i = 0; i < k; i++)
        {
            G[i] = new List<Edge>();
            L[i] = new List<Edge>();
            S[i] = new List<int>();
        }
        for (int i = 0; i < g.Length; i++)
        {
            var u = group[i];
            S[u].Add(i);
            foreach (var e in g[i])
            {
                var v = group[e.to];
                if (u == v)
                    L[u].Add(new Edge(u, v, e.cost));
                else G[u].Add(new Edge(u, v, e.cost));
            }
        }
    }
    public bool IsSameGroup(int u, int v)
    {
        return group[u] == group[v];
    }

}
#endregion