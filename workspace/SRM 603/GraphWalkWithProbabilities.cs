using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GraphWalkWithProbabilities
{
    public double findprob(string[] graph, int[] winprob, int[] looseprob, int Start)
    {
        const int limit = 2000;
        var n = graph.Length;
        var p = new double[n];
        for (int i = 0; i < n; i++)
            p[i] = 1.0 * winprob[i] / 100;
        var q = new double[n];
        for (int i = 0; i < n; i++)
            q[i] = 1.0 * looseprob[i] / 100;
        var dp = Enumerate(n, x => new double[limit]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < limit; j++)
                dp[i][j] = -1;
        Func<int, int, double> dfs = null;
        dfs = (u, k) =>
            {
                if (dp[u][k] >= 0)
                    return dp[u][k];
                if (k + 1 == limit)
                    return p[u] / (p[u] + q[u]);
                dp[u][k] = p[u] / (p[u] + q[u]);
                for (int i = 0; i < n; i++)
                {
                    if (i == u)
                        continue;
                    if (graph[u][i] == '1')
                        dp[u][k] = Math.Max(dp[u][k], p[i] + (1 - p[i] - q[i]) * dfs(i, k + 1));
                }
                return dp[u][k];
            };

        return dfs(Start, 0);
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
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
