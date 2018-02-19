using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EllysTree
{
    public int[] getMoves(int[] parent)
    {
        var n = parent.Length + 1;
        var G = new TreeGraph(n);
        {
            for (int i = 0; i < n - 1; i++)
                G.AddEdge(i + 1, parent[i]);
            G.Build(0);
        }
        var deg = new int[n];
        foreach (var x in parent)
            deg[x]++;
        var cur = 0;
        var ans = new List<int>();
        var used = new bool[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (used[j]) continue;
                var lca = G.GetLCA(cur, j);
                if (lca == cur || lca == j)
                {
                    if (deg[j] <= 1)
                    {
                        ans.Add(j);
                        used[j] = true;
                        if (j > 0)
                            deg[parent[j - 1]]--;
                        break;
                    }
                }
            }
        }
        if (ans.Count < n) return new int[] { };
        return ans.Skip(1).ToArray();
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

#region TreeEdge
public struct Edge
{
    public int from, to;
    public Edge(int f, int t)
    {
        from = f; to = t;
    }
    public override string ToString()
    {
        return string.Format("{0}->{1}", from, to);
    }
}
#endregion
//Tree
#region Treegraph
public class TreeGraph
{
    int n;
    List<Edge>[] G;
    public int[] par;
    public int[] d;
    public int[] ord, ordl, ordr;
    public TreeGraph(int N)
    {
        n = N;
        G = new List<Edge>[N];
        for (int i = 0; i < N; i++)
            G[i] = new List<Edge>();
        par = new int[N];
        d = new int[N];
        ord = new int[2 * N - 1];
        ordl = new int[N];
        ordr = new int[N];
    }
    public void AddEdge(int f, int t)
    {
        G[f].Add(new Edge(f, t));
        G[t].Add(new Edge(t, f));
    }
    void Walk(int root)
    {
        var stack = new Stack<int>();
        var iter = new int[n];
        stack.Push(root);
        par[root] = -1;
        d[root] = 0;
        var ptr = 0;

        while (stack.Any())
        {
            var p = stack.Peek();
            ord[ptr] = p;
            ptr++;
            if (iter[p] < G[p].Count && G[p][iter[p]].to == par[p]) iter[p]++;
            if (iter[p] == G[p].Count)
            {
                stack.Pop();
                ordr[p] = ptr;
            }
            else
            {
                var to = G[p][iter[p]].to;
                iter[p]++;
                stack.Push(to);
                par[to] = p;
                d[to] = d[p] + 1;
                ordl[to] = ptr;
            }
        }
    }
    sparseTable rmq;
    void BuildLCA()
    {
        var dep = new int[2 * n - 1];
        for (int i = 0; i < 2 * n - 1; i++)
            dep[i] = d[ord[i]];
        rmq = new sparseTable(dep);
    }
    public void Build(int root)
    {
        Walk(root);
        BuildLCA();
    }

    public int GetLCA(int u, int v)
    {
        //ordl: u<v
        if (ordl[u] > ordl[v]) { var tmp = u; u = v; v = tmp; }
        return ord[rmq.Query(ordl[u], ordl[v])];
    }
    #region SparseTable
    class sparseTable
    {
        int n;
        int[] A;
        int[] id;
        public sparseTable(int[] a)
        {
            var k = 1;
            n = a.Length;
            for (int i = 1; i < n; i <<= 1) k++;
            A = a;
            id = new int[n * k];
            for (int i = 0; i < n; i++)
                id[i] = i;
            var d = 0;
            for (int i = 1; i < n; i <<= 1)
            {
                for (int j = 0; j < n; j++)
                    id[d + n + j] = id[d + j];
                d += n;
                for (int j = 0; j < n - i; j++)
                    if (A[id[d + j]] > A[id[d + j + i]]) id[d + j] = id[d + j + i];
            }
        }
        /// <summary>
        /// value of [l,r)
        /// </summary>
        public int Query(int l, int r)
        {
            int z = r - l, k = 0, e = 1, s;
            s = ((z & 0xffff0000) != 0 ? 1 : 0) << 4; z >>= s; e <<= s; k |= s;
            s = ((z & 0x0000ff00) != 0 ? 1 : 0) << 3; z >>= s; e <<= s; k |= s;
            s = ((z & 0x000000f0) != 0 ? 1 : 0) << 2; z >>= s; e <<= s; k |= s;
            s = ((z & 0x0000000c) != 0 ? 1 : 0) << 1; z >>= s; e <<= s; k |= s;
            s = ((z & 0x00000002) != 0 ? 1 : 0) << 0; z >>= s; e <<= s; k |= s;
            var x = id[l + n * k];
            var y = id[r - e + 1 + (n * k)];

            if (A[x] <= A[y])
                return x;
            else return y;
        }
    }
    #endregion
}
#endregion