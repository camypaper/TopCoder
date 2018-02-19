using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class JumpDistancesOnTree
{
    public string isPossible(int[] par, int[] S)
    {
        var n = par.Length;
        var G = Enumerate(n + 1, x => new List<int>());
        for (int i = 0; i < n; i++)
        {
            G[i + 1].Add(par[i]);
            G[par[i]].Add(i + 1);
        }

        var D = dist(G);
        var m = S.Length;
        var SS = Enumerate(n + 50, x => -1);
        for (int i = 0; i < m; i++)
            SS[S[i]] = i;
        var used = new bool[m];
        var vis = new bool[n + 1];
        var q = new Queue<int>();
        q.Enqueue(0);
        vis[0] = true;
        while (q.Count > 0)
        {
            var p = q.Dequeue();
            Debug.WriteLine(p);
            for (int i = 0; i < n + 1; i++)
            {
                var d = D[p][i];
                if (SS[d] == -1) continue;
                used[SS[d]] = true;
                if (vis[i]) continue;
                vis[i] = true;
                q.Enqueue(i);
            }
        }

        if (used.All(x => x)) return "Possible";
        return "Impossible";
    }
    int[][] dist(List<int>[] G)
    {
        var n = G.Length;
        var dist = Enumerate(n, x => new int[n]);

        for (int i = 0; i < n; i++)
        {

            var q = new Queue<int>();
            q.Enqueue(i);
            var d = Enumerate(n, x => 1000000);
            d[i] = 0;
            while (q.Count > 0)
            {
                var p = q.Dequeue();
                foreach (var t in G[p])
                {
                    if (d[t] > d[p] + 1)
                    {
                        d[t] = d[p] + 1;
                        q.Enqueue(t);
                    }
                }
            }
            dist[i] = d;


        }

        return dist;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(int[] p, int[] S)
    {
        return "";
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
