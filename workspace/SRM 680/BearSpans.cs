using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearSpans
{
    public int[] findAnyGraph(int n, int m, int k)
    {
        if (k > 10 || (1 << k) > n) return new int[] { };

        var E = new List<int>();
        var q = new Queue<int>();
        for (int i = 0; i < 1 << k; i++)
            q.Enqueue(i + 1);
        var used = new bool[n + 1, n + 1];
        while (q.Count > 1)
        {
            var nq = new Queue<int>();
            while (q.Any())
            {
                var u = q.Dequeue();
                var v = q.Dequeue();
                E.Add(u); E.Add(v);
                used[u, v] = used[v, u] = true;
                nq.Enqueue(u);
            }
            q = nq;
        }
        for (int i = 1 << k; i < n; i++)
        {
            E.Add(1);
            E.Add(i + 1);
            used[1, i + 1] = used[i + 1, 1] = true;
        }
        for (int i = 1; i <= n; i++)
            for (int j = i + 1; j <= n && E.Count < 2 * m; j++)
            {
                if (!used[i, j])
                {
                    E.Add(i); E.Add(j);
                    used[i, j] = used[j, i] = true;
                }
            }
        Debug.WriteLine(E.AsJoinedString());
        if (E.Count < 2 * m) return new int[] { };

        return E.ToArray();
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
