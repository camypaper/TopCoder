using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Treestrat
{
    public int roundcnt(int[] tree, int[] A, int[] B)
    {
        var n = tree.Length + 1;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < tree.Length; i++)
        {
            G[i + 1].Add(tree[i]);
            G[tree[i]].Add(i + 1);
        }
        var min = 1000000000;
        foreach(var x in A)
        {
            min = Math.Min(min, go(G, x, B));
        }
        return min;
    }
    int go(List<int>[] G, int a, int[] b)
    {
        var n = G.Length;

        var d = Enumerate(2, x => new int[n]);
        for (int i = 0; i < n; i++)
            d[0][i] = d[1][i] = 1000000000;

        var q = Enumerate(2, x => new Queue<int>());
        q[0].Enqueue(a); d[0][a] = 0;
        foreach (var x in b) { q[1].Enqueue(x); d[1][x] = 0; }
        for (int k = 1; k <= 10 * n; k++)
        {
            for (int i = 0; i < 2; i++)
            {
                var nq = new Queue<int>();

                while (q[i].Any())
                {
                    var p = q[i].Dequeue();
                    foreach (var to in G[p])
                    {
                        if (d[i][to] > d[i][p] + 1)
                        {
                            d[i][to] = d[i][p] + 1;
                            nq.Enqueue(to);
                        }
                    }

                }

                foreach (var x in nq) q[i].Enqueue(x);
            }
            var ok = false;
            for (int i = 0; i < n; i++)
            {
                if (d[0][i] >= 1000000000) continue;
                if (d[1][i] >= 1000000000) ok = true;

            }
            if (!ok) return k;

        }
        return -1;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
