using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;
public class LongLongTripDiv1
{
    public string isAble(int n, int[] from, int[] to, int[] cost, long T)
    {
        var G = Enumerate(n, x => new List<KeyValuePair<int, int>>());
        for (int i = 0; i < from.Length; i++)
        {
            G[from[i]].Add(new KeyValuePair<int, int>(to[i], cost[i]));
            G[to[i]].Add(new KeyValuePair<int, int>(from[i], cost[i]));
        }
        return f(n, G, T) ? "Possible" : "Impossible";
    }
    bool f(int n, List<KeyValuePair<int, int>>[] G, long T)
    {
        if (G[0].Count == 0) return false;
        var mod = G[0][0].Value * 2;
        var dp = Enumerate(n, x => new long[mod]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < mod; j++)
                dp[i][j] = long.MaxValue;

        var pq = new RadixHeapPriorityQueue<KeyValuePair<int, long>>(x => x.Value);
        pq.Enqueue(new KeyValuePair<int, long>(0, 0));
        while (pq.Count > 0)
        {
            var p = pq.Dequeue();
            var u = p.Key / mod;
            var v = p.Key % mod;
            var c = p.Value;
            foreach (var e in G[u])
            {
                var to = e.Key;
                var nv = (v + e.Value) % mod;
                var nc = c + e.Value;
                if (dp[to][nv] > nc)
                {
                    dp[to][nv] = nc;
                    pq.Enqueue(new KeyValuePair<int, long>(to * mod + nv, nc));
                }
            }
        }
        return dp[n - 1][T % mod] <= T;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
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


#region RadixHeap<T>
/// <summary>
/// 突っ込むのが整数でないとき用
/// </summary>
public class RadixHeapPriorityQueue<T>
{
    /// <summary>
    /// コストがlongのときは64
    /// </summary>
    const int SIZE = 32;
    Number last;
    Func<T, Number> get;
    public RadixHeapPriorityQueue(Func<T, Number> f)
    {
        Debug.Assert(
            (sizeof(Number) == sizeof(long) && SIZE == 64) ||
            (sizeof(Number) == sizeof(int) && SIZE == 32));
        Debug.Assert(f != null);
        for (int i = 0; i <= SIZE; i++)
            v[i] = new FastLinkedList<T>();
        get = f;
    }


    static int bsr(long x)
    {
        if (x == 0) return -1;
        else
        {
            var n = 0;
            if (x >> (n + 32) > 0) n += 32;
            if (x >> (n + 16) > 0) n += 16;
            if (x >> (n + 8) > 0) n += 8;
            if (x >> (n + 4) > 0) n += 4;
            if (x >> (n + 2) > 0) n += 2;
            if (x >> (n + 1) > 0) n += 1;
            return n;
        }
    }

    FastLinkedList<T>[] v = new FastLinkedList<T>[SIZE + 1];
    int size;


    public void Enqueue(T item)
    {
        var x = get(item);
        Debug.Assert(last <= x);
        size++;
        v[bsr(x ^ last) + 1].Add(item);
    }
    public T Dequeue()
    {
        if (v[0].Count == 0)
        {
            var i = 1;
            while (v[i].Count == 0) i++;
            var nlast = Number.MaxValue;
            for (FastLinkedList<T>.Node n = v[i].last; n != null; n = n.par)
            {
                var val = get(n.val);
                if (val < nlast) nlast = val;
            }

            while (v[i].Count > 0)
            {
                var val = v[i].Pop();
                v[bsr(get(val) ^ nlast) + 1].Add(val);
            }
            last = nlast;
        }
        size--;
        return v[0].Pop();
    }
    public int Count { get { return size; } }
    public bool Any() { return size > 0; }


    #region FastLinkedList<T>
    private class FastLinkedList<TT>
    {
        int size;
        public Node last;
        public int Count { get { return size; } }
        public void Add(TT item) { last = new Node(item, last); size++; }
        public TT Pop() { var ret = last.val; last = last.par; size--; return ret; }
        public class Node
        {
            public readonly TT val;
            public readonly Node par;
            public Node(TT v, Node p) { val = v; par = p; }
        }
    }
    #endregion
}
#endregion
