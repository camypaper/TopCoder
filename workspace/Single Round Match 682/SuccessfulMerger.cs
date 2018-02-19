using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SuccessfulMerger
{
    public int minimumMergers(int[] road)
    {
        var n = road.Length;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < n; i++)
        {
            G[i].Add(road[i]);
            G[road[i]].Add(i);
        }
        var isCycle = new bool[n];

        //•Â˜HŒŸo
        {
            for (int i = 0; i < n; i++)
                isCycle[i] = true;
            var notCycle = Graph.TopologicalSort(G);
            foreach (var x in notCycle)
                isCycle[x] = false;
        }

        var m = isCycle.Count(x => x);
        if (n == m) return n - 2;

        var sub = new int[n];
        var cost = new int[n];
        Func<int, int, int> dfs = null;
        dfs = (prev, cur) =>
          {
              var ret = 0;
              foreach (var to in G[cur])
              {
                  if (to == prev) continue;
                  if (G[cur].Count == 2)
                      ret += 1;
              }
              return ret;
          };
        for (int i = 0; i < n; i++)
        {
            if (!isCycle[i]) continue;
            foreach (var to in G[i])
            {
                if (isCycle[to]) continue;
                cost[i] += dfs(i, to);
            }
        }
        var min = int.MaxValue;
        //all
        {
            var v = m - 1;
            for (int i = 0; i < n; i++)
                v += cost[i];
            min = Math.Min(v, min);

        }
   
        return min;
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
        var g = new int[] { 1, 0, 1, 2, 2, 2 };
        test.ManualTest(g);
    }
}
// CUT end
#region TopologicalSort
static partial class Graph
{
    //‡˜‚ð‚¢‚¶‚è‚½‚¢ê‡‚ÍQueue‚©‚ç•Ï‚¦‚é
    //Žg‚í‚È‚¢“z‚ª‚ ‚éê‡‚Ícount‚Ì‚»‚ÌˆÊ’u‚É—\‚ß-1‚ð“ü‚ê‚Ä“n‚·
    //zŠÂ‚µ‚Ä‚é‚ÆƒTƒCƒY‚ª¬‚³‚­‚È‚é‚Í‚¸H
    static public int[] TopologicalSort(List<int>[] G, int[] count = null)
    {
        const int Capacity = 1;//—LŒü‚È‚ç‚Î0–³Œü‚È‚ç‚Î1
        var n = G.Length;
        if (count == null)
        {
            count = new int[n];
            foreach (var l in G)
                foreach (var x in l) count[x]++;
        }
        var ret = new List<int>();
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
            if (count[i] == Capacity) q.Enqueue(i);
        while (q.Any())
        {
            var p = q.Dequeue();
            ret.Add(p);
            foreach (var x in G[p])
                if (--count[x] == Capacity) q.Enqueue(x);
        }
        return ret.ToArray();
    }

}
#endregion