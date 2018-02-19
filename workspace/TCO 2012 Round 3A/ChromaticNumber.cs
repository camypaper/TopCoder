using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ChromaticNumber
{
    public int minColors(string[] graph)
    {
        var n = graph.Length;
        var s = new DisjointSet(n);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (graph[i][j] == 'N') s.Unite(i, j);
        var ans = 0;
        for (int r = 0; r < n; r++)
        {
            if (s[r] != r) continue;
            else
            {
                if (s.Size(r) <= 2) ans++;
                else if (s.Size(r) == 3)
                {
                    var cnt = 0;
                    for (int i = 0; i < n; i++)
                        for (int j = i + 1; j < n; j++)
                            if (s[i] == r && s[j] == r && graph[i][j] == 'N') cnt++;
                    if (cnt == 3) ans++;
                    else ans += 2;
                }
                else
                {
                    ans += (s.Size(r) + 1) / 2;
                }

            }
        }
        return ans;
    }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(new string[] { "NNYYN", "NNNYY", "YNNNY", "YYNNN", "NYYNN" });
    }
}
// CUT end
#region DisjointSet
public class DisjointSet
{
    public int[] par, ranks, count;
    public DisjointSet(int n)
    {
        par = new int[n];
        count = new int[n];
        for (int i = 0; i < n; i++)
        {
            par[i] = i;
            count[i] = 1;
        }
        ranks = new int[n];
    }
    public int this[int id] { get { return (par[id] == id) ? id : this[par[id]]; } }
    public bool Unite(int x, int y)
    {
        x = this[x]; y = this[y];
        if (x == y) return false;
        if (ranks[x] < ranks[y])
        {
            par[x] = y;
            count[y] += count[x];
        }
        else
        {
            par[y] = x;
            count[x] += count[y];
            if (ranks[x] == ranks[y])
                ranks[x]++;
        }
        return true;
    }
    public int Size(int x) { return count[this[x]]; }
    public bool IsUnited(int x, int y) { return this[x] == this[y]; }

}
#endregion