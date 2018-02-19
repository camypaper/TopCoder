using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class OddEvenTree
{
    int[] invalid = { -1 };
    public int[] getTree(string[] x)
    {
        x = new string[] { "EE", "EE" };
        var n = x.Length;
        for (int i = 0; i < n; i++)
            if (x[i][i] == 'O')
                return invalid;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (x[i][j] != x[j][i])
                    return invalid;
        var dist = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (i != j) dist[i, j] = (x[i][j] == 'O') ? 1 : 2;
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (dist[i, j] % 2 != (dist[i, k] + dist[j, k]) % 2)
                        return invalid;
                }
        var set = new DisjointSet(n);
        var es = new List<int>();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                if (set.IsUnited(i, j))
                    continue;
                if (dist[i, j] == 1)
                {
                    var ok = true;
                    for (int k = 0; k < n; k++)
                    {
                        if (k == i || k == j)
                            continue;
                        if ((dist[i, j] + dist[j, k]) % 2 == dist[i, k] % 2)
                            continue;
                        ok = false;
                    }
                    if (ok)
                    {
                        es.Add(i);
                        es.Add(j);
                        set.Unite(i, j);
                    }
                }
            }

        if (es.Count < 2 * n - 2)
            return invalid;
        //System.Diagnostics.Debug.WriteLine(es.AsJoinedString());
        return es.ToArray();
    }
}
#region DisjointSet
public class DisjointSet
{
    int[] par, ranks, count;
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