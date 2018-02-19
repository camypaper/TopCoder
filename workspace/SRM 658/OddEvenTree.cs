using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class OddEvenTree
{
    int[] invalid = { -1 };
    public int[] getTree(string[] mat)
    {
        var n = mat.Length;
        var to = new int[n];
        var es = new List<int>();
        var visit = new bool[n];
        var from = new int[n];
        for (int i = 0; i < n; i++)
            from[i] = -1;
        while (true)
        {
            var v = -1;
            for (int u = 0; u < n; u++)
                if (!visit[u] && (v == -1 || from[u] != -1)) v = u;
            if (v == -1)
                break;
            visit[v] = true;
            if (from[v] != -1)
            {
                es.Add(v);
                es.Add(from[v]);
            }
            for (int u = 0; u < n; u++)
                if (!visit[u] && mat[v][u] == 'O')
                    from[u] = v;
        }
        var dist = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                dist[i, j] = i != j ? 1 << 20 : 0;
        for (int i = 0; i < n; i++)
            if (from[i] != -1) dist[i, from[i]] = dist[from[i], i] = 1;
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dist[i, j] = Math.Min(dist[i, j], dist[i, k] + dist[k, j]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if ((dist[i, j] % 2 == 0 ? 'E' : 'O') != mat[i][j])
                    return invalid;
        if (es.Count < 2 * n - 2)
            return invalid;
        return es.ToArray();
    }
}
// CUT begin
public class Tester : AbstractTester
{
    public override void Test()
    {
        base.Test();
    }
}
// CUT end