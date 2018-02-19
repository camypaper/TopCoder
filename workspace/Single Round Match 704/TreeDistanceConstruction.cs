using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;

public class TreeDistanceConstruction
{
    public int[] construct(int[] dist)
    {
        var n = dist.Length;

        var a = Enumerate(55, x => new Queue<int>());
        for (int i = 0; i < n; i++)
            a[dist[i]].Enqueue(i);

        var E = new List<int>();
        var id = Enumerate(55, x => new Queue<int>());
        var dia = -1;
        for (int D = 0; D <= 50; D++)
        {
            if (a[D].Count == 1)
            {
                id[D].Enqueue(a[D].Peek());
                id[D].Enqueue(a[D].Dequeue());
                dia = D;
                break;
            }
            else if (a[D].Count == 2)
            {
                var p = a[D].Dequeue();
                var q = a[D].Dequeue();

                id[D].Enqueue(p);
                id[D].Enqueue(q);
                E.Add(p);
                E.Add(q);
                dia = D;
                break;
            }
            else if (a[D].Count > 2) return new int[] { };
        }
        var max = dist.Max();
        for (int i = dia + 1; i <= max; i++)
        {
            if (a[i].Count < 2) return new int[] { };
            var par = id[i - 1].Dequeue();
            var par2 = id[i - 1].Dequeue();
            var p = a[i].Dequeue();
            var q = a[i].Dequeue();
            E.Add(par);
            E.Add(p);
            E.Add(par2);
            E.Add(q);
            id[i].Enqueue(p);
            id[i].Enqueue(q);
            while (a[i].Count > 0)
            {
                var r = a[i].Dequeue();
                E.Add(par);
                E.Add(r);
            }
        }
        var ret = E.ToArray();

        var dd = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                dd[i, j] = dd[j, i] = 1000;
        for (int i = 0; i < ret.Length; i += 2)
            dd[ret[i], ret[i + 1]] = dd[ret[i + 1], ret[i]] = 1;
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dd[i, j] = Math.Min(dd[i, j], dd[i, k] + dd[k, j]);
        for (int i = 0; i < n; i++)
        {
            var v = -1;
            for (int j = 0; j < n; j++)
                v = Math.Max(v, dd[i, j]);
            if (v != dist[i])
                return new int[] { };
        }



        if (ret.Length == 2 * (n - 1))
            return ret;
        else return new int[] { };
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int[] Naive_Test(int[] d)
    {
        return new int[] { };
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
