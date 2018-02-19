using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ScotlandYard
{
    public int maxMoves(string[] taxi, string[] bus, string[] metro)
    {
        var n = taxi.Length;
        var G = Enumerate(3, x => new long[n]);
        var s = new string[][] { taxi, bus, metro };
        for (int k = 0; k < 3; k++)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (s[k][i][j] == 'Y') G[k][i] |= 1L << j;
        }
        return solve(n, G);
    }
    int solve(int n, long[][] g)
    {
        var map = new Dictionary<long, int>(1 << 16);
        //var G = new List<List<int>>() { new List<int>() };
        map[(1L << n) - 1] = 0;
        var q = new Queue<long>();
        q.Enqueue((1L << n) - 1);
        while (q.Count > 0)
        {
            var p = q.Dequeue();
            var cnt = 0;
            for (int i = 0; i < n; i++)
                if ((p >> i & 1) == 1) cnt++;
            if (cnt == 1) continue;

            for (int k = 0; k < 3; k++)
            {
                var to = 0L;
                for (int i = 0; i < n; i++)
                    if ((p >> i & 1) == 1) to |= g[k][i];
                if (to == 0) continue;
                if (!map.ContainsKey(to))
                {
                    //G[map[p]].Add(map.Count);
                    map[to] = map.Count;
                    //G.Add(new List<int>());
                    q.Enqueue(to);
                }
            }

        }
        var G = Enumerate(map.Count, x => new List<int>());
        foreach (var kv in map)
        {
            var p = kv.Key;
            var cnt = 0;
            for (int i = 0; i < n; i++)
                if ((p >> i & 1) == 1) cnt++;
            if (cnt == 1) continue;

            for (int k = 0; k < 3; k++)
            {
                var to = 0L;
                for (int i = 0; i < n; i++)
                    if ((p >> i & 1) == 1) to |= g[k][i];
                if (to == 0) continue;
                G[kv.Value].Add(map[to]);
            }
        }
        Debug.WriteLine(map.Count);
        return solve(map.Count, G.ToArray());
    }
    int solve(int n, List<int>[] G)
    {
        var d = new int[n];
        var deg = new int[n];
        for (int i = 0; i < n; i++)
            foreach (var t in G[i]) deg[t]++;
        var q = new Queue<int>();
        for (int i = 0; i < n; i++)
            if (deg[i] == 0) q.Enqueue(i);
        while (q.Count > 0)
        {
            var p = q.Dequeue();
            foreach (var t in G[p])
            {
                d[t] = Math.Max(d[t], d[p] + 1);
                deg[t]--;
                if (deg[t] == 0)
                    q.Enqueue(t);
            }
        }
        if (deg.Any(x => x > 0)) return -1;
        else return d.Max();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] taxi, string[] bus, string[] metro)
    {
        return 0;
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
        var str = new string[][]{
            new string[] { "NNNNNNNNNNNNNNNYNNNN", "NNNYNNNNNNNNNNNNNNNN", "NNNNNNNYNNNNNNNNNNNN", "NNNNNNNNNNNNNYNNNNNN", "NNNNNYNNNNNNNNNNNNNN", "NNNNNNNNYNNNNNNNNNNN", "NNNNNNNNNNYNNNNNNNNN", "NNNNNNNNNYNNNNNNNNNN", "NNYNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNYNNN", "NNNNNNNNNNNNYNNNNNNN", "NNNNNNNNNNNNNNNNNNNY", "NNNNNNNNNNNNNNNNNNYN", "NNNNNNNNNNNNNNNNNNNN", "NYNNNNNNNNNNNNNNNNNN", "NNNNYNNNNNNNNNNNNNNN", "NNNNNNYNNNNNNNNNNNNN", "NNNNNNNNNNNNNNYNNNNN", "NNNNNNNNNNNYNNNNNNNN", "NNNNNNNNNNNNNNNNNYNN" },
            new string[] { "NNNNNYNNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNYNN", "NNNNYNNNNNNNNNNNNNNN", "NNNNNNNYNNNNNNNNNNNN", "NNNNNNNNNNNNNNNNNNNN", "NNNYNNNNNNNNNNNNNNNN", "NNNNNNNNYNNNNNNNNNNN", "NNNNNNNNNNNNNYNNNNNN", "NNNNNNNNNNNNNNYNNNNN", "NYNNNNNNNNNNNNNNNNNN", "NNNNNNNNNYNNNNNNNNNN", "NNNNNNNNNNNNNNNYNNNN", "NNNNNNNNNNNNNNNNNNNY", "NNNNNNNNNNYNNNNNNNNN", "NNYNNNNNNNNNNNNNNNNN", "NNNNNNYNNNNNNNNNNNNN", "YNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNNYNNNNNNN", "NNNNNNNNNNNNNNNNYNNN", "NNNNNNNNNNNYNNNNNNNN" },
            new string[] { "NYNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNYNNNNNNNNN", "NNNNNNNNNNNNNYNNNNNN", "NNNNNNNNYNNNNNNNNNNN", "YNNNNNNNNNNNNNNNNNNN", "NNNNNNNNNNNYNNNNNNNN", "NNNNNNNNNNNNNNYNNNNN", "NNNNNNNNNNNNYNNNNNNN", "NNNNNNNNNNNNNNNNNNNN", "NNNNNNNYNNNNNNNNNNNN", "NNYNNNNNNNNNNNNNNNNN", "NNNNNNNNNYNNNNNNNNNN", "NNNNNNNNNNNNNNNNNYNN", "NNNNNYNNNNNNNNNNNNNN", "NNNNYNNNNNNNNNNNNNNN", "NNNNNNYNNNNNNNNNNNNN", "NNNNNNNNNNNNNNNYNNNN", "NNNNNNNNNNNNNNNNNNYN", "NNNNNNNNNNNNNNNNNNNY", "NNNYNNNNNNNNNNNNNNNN" } }
        ;

        ManualTest(str[0], str[1], str[2]);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
