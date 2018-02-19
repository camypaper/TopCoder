using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class MaliciousPath
{
    public long minPath(int n, int k, int[] from, int[] to, int[] cost)
    {
        var G = Enumerate(n, x => new List<KeyValuePair<int, long>>());
        var RG = Enumerate(n, x => new List<KeyValuePair<int, long>>());
        for (int i = 0; i < from.Length; i++)
        {
            if (from[i] == n - 1) continue;
            G[from[i]].Add(new KeyValuePair<int, long>(to[i], cost[i]));
            RG[to[i]].Add(new KeyValuePair<int, long>(from[i], cost[i]));
        }
        var dp = new long[n];
        for (int i = 0; i < n; i++)
            dp[i] = 1L << 60;
        for (int t = 0; t <= k; t++)
        {
            var next = new long[n];
            for (int i = 0; i < n; i++)
                foreach (var e in G[i])
                    next[i] = Math.Max(next[i], dp[e.Key] + e.Value);
            var d = new long[n];
            for (int i = 0; i < n; i++)
                d[i] = 1L << 60;
            var pq = new PriorityQueue<KeyValuePair<int, long>>((l, r) => l.Value.CompareTo(r.Value));
            pq.Enqueue(new KeyValuePair<int, long>(n - 1, d[n - 1] = 0));
            while (pq.Any())
            {
                var p = pq.Dequeue();
                var pos = p.Key;
                var val = p.Value;
                //System.Diagnostics.Debug.WriteLine("{0} {1}", pos, val);
                if (d[pos] < val)
                    continue;
                if (t > 0)
                    val = Math.Max(next[pos], val);
                next[pos] = val;
                foreach (var e in RG[pos])
                    if (d[e.Key] > val + e.Value) pq.Enqueue(new KeyValuePair<int, long>(e.Key, d[e.Key] = val + e.Value));

            }
            dp = next;
        }
        if (dp[0] >= 1L << 60)
            return -1;
        return dp[0];

    }
    static T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }

}
public class Tester: AbstractTester
{

}
#region PriorityQueue and PairingHeap
public class PriorityQueue<T>
{
    PairingHeap<T> top;
    Comparison<T> compare;
    int size;
    public int Count { get { return size; } }
    public PriorityQueue() : this(Comparer<T>.Default) { }
    public PriorityQueue(Comparison<T> comparison) { compare = comparison; }
    public PriorityQueue(IComparer<T> comparer) { compare = comparer.Compare; }
    public void Enqueue(T item)
    {
        var heap = new PairingHeap<T>(item);
        top = PairingHeap<T>.Merge(top, heap, compare);
        size++;
    }
    public T Dequeue()
    {
        var ret = top.Key;
        size--;
        top = PairingHeap<T>.Pop(top, compare);
        return ret;
    }
    public bool Any() { return size > 0; }
    public T Peek() { return top.Key; }
}

#region PairingHeap
public class PairingHeap<T>
{
    public PairingHeap(T k) { key = k; }
    private readonly T key;
    public T Key { get { return key; } }
    private PairingHeap<T> head;
    private PairingHeap<T> next;
    static public PairingHeap<T> Pop(PairingHeap<T> s, Comparison<T> compare)
    {
        return MergeLst(s.head, compare);
    }
    static public PairingHeap<T> Merge(PairingHeap<T> l, PairingHeap<T> r, Comparison<T> compare)
    {
        if (l == null || r == null) return l == null ? r : l;
        if (compare(l.key, r.key) > 0) Swap(ref l, ref r);
        r.next = l.head;
        l.head = r;
        return l;
    }
    static public PairingHeap<T> MergeLst(PairingHeap<T> s, Comparison<T> compare)
    {
        var n = new PairingHeap<T>(default(T));
        while (s != null)
        {
            PairingHeap<T> a = s, b = null;
            s = s.next; a.next = null;
            if (s != null) { b = s; s = s.next; b.next = null; }
            a = Merge(a, b, compare); a.next = n.next;
            n.next = a;
        }
        while (n.next != null)
        {
            var j = n.next;
            n.next = n.next.next;
            s = Merge(j, s, compare);
        }
        return s;
    }
    static void Swap(ref PairingHeap<T> l, ref PairingHeap<T> r) { var t = l; l = r; r = t; }
}
#endregion
#endregion