using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;
public class FromToDivisible
{
    public int shortest(int N, int S, int T, int[] a, int[] b)
    {
        var m = a.Length;
        var G = Enumerate(2 * m + 2, x => new List<KeyValuePair<int, int>>());
        var s = 2 * m;
        var t = 2 * m + 1;
        for (int i = 0; i < m; i++)
        {
            if (S % a[i] == 0) G[s].Add(new KeyValuePair<int, int>(i, 0));
            if (T % b[i] == 0) G[i + m].Add(new KeyValuePair<int, int>(t, 0));
            G[i].Add(new KeyValuePair<int, int>(m + i, 1));
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == j) continue;
                var lcm = MathEx.LCM(b[i], a[j]);
                if (lcm > N) continue;
                G[m + i].Add(new KeyValuePair<int, int>(j, 0));
            }
        }
        var used = new bool[2 * m + 2];
        var dist = new int[2 * m + 2];
        for (int i = 0; i < 2 * m + 2; i++)
            dist[i] = 1 << 30;
        dist[s] = 0;
        var q = new Queue<int>(); q.Enqueue(s);
        while (q.Count > 0)
        {
            var nq = new Queue<int>();
            while (q.Count > 0)
            {
                var p = q.Dequeue();
                if (used[p]) continue;
                used[p] = true;

                foreach (var to in G[p])
                {
                    var nd = dist[p] + to.Value;
                    if (dist[to.Key] > nd)
                    {
                        dist[to.Key] = nd;
                        if (to.Value == 0) q.Enqueue(to.Key);
                        else nq.Enqueue(to.Key);
                    }

                }
            }
            q = nq;
        }
        if (dist[t] != 1 << 30) return dist[t];
        return -1;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int Naive_Test(int N, int S, int T, int[] a, int[] b)
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
        //Tests.Add(null);
    }
}
// CUT end
#region gcd,lcm
static public partial class MathEx
{

    static public Number GCD(Number x, Number y)
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
    static public Number LCM(Number x, Number y)
    {
        return (x / GCD(x, y)) * y;
    }
    static public Number GCD(params Number[] a)
    {
        var gcd = a[0];
        foreach (var x in a)
            gcd = GCD(gcd, x);
        return gcd;
    }

}
#endregion

