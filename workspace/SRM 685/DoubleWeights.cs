using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DoubleWeights
{
    public int minimalCost(string[] weight1, string[] weight2)
    {
        var n = weight1.Length;
        var dp = Enumerate(n, x => new int[250]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < 250; j++)
                dp[i][j] = 100000000;
        dp[0][0] = 0;
        var q = new Queue<int>();
        var r = new Queue<int>();
        var s = new Queue<int>();
        add(q, r, s, 0, 0, 0);
        while (q.Any())
        {
            var p = q.Dequeue();
            var w = r.Dequeue();
            var v = s.Dequeue();
            //Debug.WriteLine("{0} {1} {2}", p, w, v);
            for (int i = 0; i < n; i++)
            {
                if (weight1[p][i] == '.') continue;
                var nw = w + weight1[p][i] - '0';
                var nv = v + weight2[p][i] - '0';
                if (nw < 250 && dp[i][nw] > nv)
                {
                    dp[i][nw] = nv;
                    add(q, r, s, i, nw, nv);
                }
            }
        }
        var min = 1000000000;
        for (int i = 0; i < 250; i++)
            if (dp[1][i] < 100000000)
                min = Math.Min(min, i * dp[1][i]);
        if (min >= 1000000000) return -1;
        return min;
    }
    void add(Queue<int> q, Queue<int> r, Queue<int> s, int p, int w, int v)

    {
        q.Enqueue(p);
        r.Enqueue(w);
        s.Enqueue(v);
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
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
