using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class CandleTimerEasy
{
    public int differentTime(int[] A, int[] B, int[] len)
    {
        var n = A.Length;
        if (n <= 2)
            return 2;
        var G = new List<KeyValuePair<int, int>>[n + 1];
        for (int i = 0; i <= n; i++)
            G[i] = new List<KeyValuePair<int, int>>();
        for (int i = 0; i < n; i++)
        {
            var from = A[i];
            var to = B[i];
            G[from].Add(new KeyValuePair<int, int>(to, len[i]));
            G[to].Add(new KeyValuePair<int, int>(from, len[i]));
        }
        var nodes = new List<int>();
        for (int i = 0; i <= n; i++)
            if (G[i].Count == 1)
                nodes.Add(i);
        var count = nodes.Count;
        var set =new HashSet<double>();
        depth = new int[n + 1];
        dfs(G, -1, 0, 0);

        for (int i = 1; i < 1 << count; i++)
        {
            var fast = 1 << 20;
            var length = new int[count];
            for (int j = 0; j < count; j++)
            {
                length[j] = depth[nodes[j]];
                if (((i >> j) & 1) == 1)
                    fast = Math.Min(depth[nodes[j]], fast);
                else continue;
            }
            double max = fast;
            for (int j = 0; j < count; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    length[j] -= fast;
                    var dl = length[j];
                    max = Math.Max(max, fast + dl / 2.0);
                }
                else max = Math.Max(max, length[j] + fast);
            }
            set.Add(max);
            
        }
        return set.Count;
    }
    int[] depth;
    public void dfs(List<KeyValuePair<int, int>>[] graph, int prev, int current, int length)
    {
        depth[current] = length;
        foreach (var to in graph[current])
        {
            if (to.Key == prev)
                continue;
            dfs(graph, current, to.Key, length + to.Value);
        }

    }
    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new CandleTimerEasy();
        var u = new CandleTimerEasyTest();
        try
        {
            u.Example4();
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

    public void ManualTest(int[] A, int[] B, int[] len)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A))); Console.WriteLine(string.Format("B:{0}", string.Join(" ", B))); Console.WriteLine(string.Format("len:{0}", string.Join(" ", len))); sw.Start();
        var ret = differentTime(A, B, len);
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
    static public T[] Enumerate<T>(this int n, Func<int, T> f)
    {
        var a = new T[n];
        for (int i = 0; i < n; i++)
            a[i] = f(i);
        return a;
    }
}
