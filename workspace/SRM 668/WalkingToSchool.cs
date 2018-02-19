using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class WalkingToSchool
{
    public string canWalkExactly(int n, int[] from, int[] to)
    {

        var G = Enumerate(n, x => new List<int>());
        var RG = Enumerate(n, x => new List<int>());
        for (int i = 0; i < from.Length; i++)
        {
            G[from[i]].Add(to[i]);
            RG[to[i]].Add(from[i]);
        }
        if (f(n, G, RG)) return "Freedom";
        return "Chores";
    }
    int[] bfs(int n, int s, List<int>[] G)
    {
        var ret = new int[n];
        for (int i = 0; i < n; i++)
            ret[i] = 1 << 25;
        ret[s] = 0;
        var q = new Queue<int>();
        q.Enqueue(s);
        while (q.Count > 0)
        {
            var p = q.Dequeue();
            foreach (var to in G[p])
            {
                if (ret[to] > ret[p] + 1)
                {
                    ret[to] = ret[p] + 1;
                    q.Enqueue(to);
                }
            }
        }
        return ret;
    }
    bool f(int n, List<int>[] G, List<int>[] RG)
    {
        var F0 = bfs(n, 0, G);
        var F1 = bfs(n, 1, G);
        if (F0[1] + F1[0] >= 1 << 25) return false;

        var gcd = F0[1] + F1[0];
        var dp = Enumerate(8050, x => new bool[n]);
        dp[0][0] = true;
        var q = new Queue<int>();
        q.Enqueue(0);
        while (q.Any())
        {
            var p = q.Dequeue();
            var val = p / 5000;
            var cur = p % 5000;
            if (val + 1 >= 8050) continue;
            foreach (var to in G[cur])
            {
                if (!dp[val + 1][to])
                {
                    dp[val + 1][to] = true;
                    q.Enqueue((val + 1) * 5000 + to);
                }
            }
        }
        for (int i = 0; i < 8050; i++)
            if (dp[i][0]) gcd = GCD(gcd, i);
        if (gcd == 1) return true;
        else return false;
    }
    static public int GCD(int x, int y)
    {
        byte i = 0;
        while (x != 0 && y != 0)
        {
            if (i == 0)
                y %= x;
            else x %= y;
            i ^= 1;
        }
        return x == 0 ? y : x;
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
