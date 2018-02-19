using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class Revmatching
{
    public int smallest(string[] A)
    {
        var n = A.Length;
        var G = new List<Edge<int, int>>[2 * n + 2];
        for (int i = 0; i < 2 * n + 2; i++)
            G[i] = new List<Edge<int, int>>();
        var sum = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                var t = A[i][j] - '0';
                if (t == 0) continue;
                sum += t;
                G.AddDirectedEdge(i, n + j, 1, t);
            }
        for (int i = 0; i < n; i++)
        {
            G.AddDirectedEdge(2 * n, i, 100, 0);
            G.AddDirectedEdge(n + i, 2 * n + 1, 100, 0);
        }
        var ret = Flow.GetMinCostFlow(G, 2 * n, 2 * n + 1, n - 1);
      
        //var cost = Flow.GetMinCostFlow(G, 2 * n, 2 * n + 1, n - 1);
        //var cost2 = Flow.GetMinCostFlow(G, 2 * n, 2 * n + 1, 1);

        return sum - ret;
    }
}
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

//O(|F||V||E|)
#region Integer MinCostFlow
static public partial class Flow
{
    static public int GetMinCostFlow(List<Edge<int, int>>[] G, int s, int t, int f, int INF = 1<<30)
    {
        var res = 0;
        var n = G.Length;
        var dist = new int[n];
        var prevV = new int[n];
        var prevE = new int[n];
        while (f > 0)
        {
            for (int i = 0; i < n; i++)
                dist[i] = INF;
            dist[s] = 0;
            var update = true;
            while (update)
            {
                update = false;
                for (int v = 0; v < n; v++)
                {
                    if (dist[v] == INF) continue;
                    for (int i = 0; i < G[v].Count; i++)
                    {
                        var e = G[v][i];
                        if (e.cap <= 0 || dist[e.to] <= dist[v] + e.cost)
                            continue;
                        dist[e.to] = dist[v] + e.cost;
                        prevV[e.to] = v;
                        prevE[e.to] = i;
                        update = true;

                    }
                }
            }
            if (dist[t] == INF)
                return -1;
            var d = f;
            for (int v = t; v != s; v = prevV[v])
                d = Math.Min(d, G[prevV[v]][prevE[v]].cap);
            f -= d;
            res += d * dist[t];
            for (int v = t; v != s; v = prevV[v])
            {
                var e = G[prevV[v]][prevE[v]];
                e.cap -= d;
                G[v][e.rev].cap += d;
            }
        }
        return res;
    }
}
#endregion