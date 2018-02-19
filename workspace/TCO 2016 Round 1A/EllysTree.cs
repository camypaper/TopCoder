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
        var go = Enumerate(n, x => new bool[n]);
        for (int i = 0; i < n - 1; i++)
            go[i + 1][parent[i]] = true;

        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    go[i][j] |= go[i][k] && go[k][j];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (go[i][j])
                    go[j][i] = true;
        int[] ord;
        {
            var G = Enumerate(n, x => new List<int>());
            for (int i = 0; i < n - 1; i++)
            {
                G[i + 1].Add(parent[i]);
            }
            ord = Graph.TopologicalSort(G);
        }
        var used = new bool[n];
        Debug.WriteLine(ord.AsJoinedString());
        var ans = new List<int>();
        Func<int, bool> check = (cur) =>
            {
                var otaku = used.Clone() as bool[];
                int k = otaku.Count(x => x);
                while (k < n)
                {
                    var ok = false;
                    for (int i = 0; i < n; i++)
                    {
                        var id = ord[i];
                        if (otaku[id]) continue;
                        if (!go[cur][id]) continue;
                        cur = id;
                        otaku[id] = true;
                        ok = true;
                        k++;
                        break;
                    }
                    if (ok) continue;
                    return false;
                }
                return true;
            };
        used[0] = true;
        if (!check(0)) return new int[] { };
        int pos = 0;
        while (ans.Count < n - 1)
        {
            for (int i = 0; i < n; i++)
            {
                if (used[i]) continue;
                if (!go[pos][i]) continue;
                used[i] = true;
                if (check(i))
                {
                    pos = i;
                    ans.Add(i);
                    break;
                }
                used[i] = false;
            }
        }
        return ans.ToArray();
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
       // test.ManualTest(new int[] { 0, 1, 1 });
    }
}
// CUT end
#region TopologicalSort
static partial class Graph
{
    //‡˜‚ð‚¢‚¶‚è‚½‚¢ê‡‚ÍQueue‚©‚ç•Ï‚¦‚é
    //Žg‚í‚È‚¢“z‚ª‚ ‚éê‡‚Ícount‚Ì‚»‚ÌˆÊ’u‚É—\‚ß-1‚ð“ü‚ê‚Ä“n‚·
    static public int[] TopologicalSort(List<int>[] G, int[] count = null)
    {
        const int Capacity = 0;//—LŒü‚È‚ç‚Î0–³Œü‚È‚ç‚Î1
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
