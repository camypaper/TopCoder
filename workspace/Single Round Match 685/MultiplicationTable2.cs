using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MultiplicationTable2
{
    public int minimalGoodSet(int[] table)
    {
        int n = 1;
        while (n * n < table.Length) n++;

        var min = n;
        var a = Enumerate(n, x => new int[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                a[i][j] = table[i * n + j];
        for (int s = 0; s < n; s++)
        {
            var used = new bool[n];
            var q = new Queue<int>();
            used[s] = true;
            q.Enqueue(s);
            while (q.Any())
            {
                var p = q.Dequeue();
                for (int i = 0; i < n; i++)
                {
                    if (used[i])
                    {
                        var u = a[p][i];
                        if (!used[u])
                        {
                            used[u] = true;
                            q.Enqueue(u);
                        }
                        var v = a[i][p];
                        if (!used[v])
                        {
                            used[v] = true;
                            q.Enqueue(v);
                        }
                    }
                }
            }
            min = Math.Min(min, used.Count(x => x));
        }

        return min;
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
