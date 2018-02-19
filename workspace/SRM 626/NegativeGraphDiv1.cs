using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NegativeGraphDiv1
{
    public long findMin(int n, int[] from, int[] to, int[] weight, int charges)
    {
        var m = from.Length;
        const long INF = 1L << 60;
        var g = Enumerate(n, x => new long[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                g[i][j] = i != j ? INF : 0;

        for (int i = 0; i < m; i++)
        {
            from[i]--; to[i]--;
            g[from[i]][to[i]] = Math.Min(g[from[i]][to[i]], weight[i]);
            //Debug.WriteLine("{0} {1} {2}", from[i], to[i], weight[i]);
        }
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    g[i][j] = Math.Min(g[i][j], g[i][k] + g[k][j]);


        var d = Enumerate(35, x => Enumerate(n, y => new long[n]));
        for (int k = 0; k < 35; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    d[k][i][j] = INF;
        for (int i = 0; i < m; i++)
        {
            for (int f = 0; f < n; f++)
                for (int t = 0; t < n; t++)
                    d[0][f][t] = Math.Min(d[0][f][t], Math.Min(g[f][t], g[f][from[i]] + g[to[i]][t] - weight[i]));
        }
        for (int k = 1; k < 35; k++)
        {
            for (int t = 0; t < n; t++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        d[k][i][j] = Math.Min(d[k][i][j], d[k - 1][i][t] + d[k - 1][t][j]);

        }
        for (int t = 0; t < 35; t++, charges /= 2)
        {
            if ((charges & 1) == 0) continue;
            var next = Enumerate(n, x => new long[n]);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    next[i][j] = INF;
            for (int k = 0; k < n; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        next[i][j] = Math.Min(next[i][j], g[i][k] + d[t][k][j]);
            g = next;
        }

        return g[0][n - 1];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public long Naive_Test(int N, int[] from, int[] to, int[] weight, int charges)
    {
        return 0;
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        Tests.Add(() => ManualTestFromInput("{50, {1, 2, 3, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 3, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48}, {2, 3, 50, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 2, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 3}, {100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000}, 9976804}"));
    }
}
// CUT end
