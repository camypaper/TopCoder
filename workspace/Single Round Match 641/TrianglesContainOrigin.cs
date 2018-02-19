using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using Point = System.Numerics.Complex;
public class TrianglesContainOrigin
{
    public long count(int[] x, int[] y)
    {
        return 0;
    }
    static public double Cross(Point a, Point b)
    {
        return (Point.Conjugate(a) * b).Imaginary;
    }
    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new TrianglesContainOrigin();
        var u = new TrianglesContainOriginTest();
        try
        {
            var r = new Random();
            var X = new int[2500];
            var Y = new int[2500];
            for (int i = 0; i < 2500; i++)
            {
                X[i] = i - 1250;
            }
            Y = Enumerable.Range(-10000, 10000).OrderBy(x => r.Next()).Take(2500).ToArray();
            var str = X.AsJoinedString(",");
            var strY = Y.AsJoinedString(",");
            u.Example0();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            System.Diagnostics.Debug.Close();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }

    public void ManualTest(int[] x, int[] y)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x))); Console.WriteLine(string.Format("y:{0}", string.Join(" ", y))); sw.Start();
        var ret = count(x, y);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ")
    {
        return string.Join(s, e);
    }
}

static partial class Graph
{
    static public int BipartiteMatching(List<int>[] G)
    {
        var n = G.Length;
        var match = new int[n];
        var used = new bool[n];
        var res = 0;
        for (int i = 0; i < n; i++)
            match[i] = -1;
        Func<int, bool> dfs = null;
        dfs = v =>
        {
            used[v] = true;
            foreach (var u in G[v])
            {
                var w = match[u];
                if (w < 0 || !used[w] && dfs(w))
                {
                    match[v] = u;
                    match[u] = v;
                    return true;
                }
            }
            return false;
        };
        for (int v = 0; v < n; v++)
        {
            if (match[v] >= 0) continue;
            Array.Clear(used, 0, n);
            if (dfs(v)) res++;
        }
        return res;

    }
}