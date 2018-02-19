using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class MaliciousPath
{
    public long minPath(int N, int K, int[] from, int[] to, int[] cost)
    {
        var G = new List<KeyValuePair<int, long>>[N];
        var rG = new List<KeyValuePair<int, long>>[N];
        for (int i = 0; i < N; i++)
        {
            G[i] = new List<KeyValuePair<int, long>>();
            rG[i] = new List<KeyValuePair<int, long>>();
        }
        var m = from.Length;
        for (int i = 0; i < m; i++)
        {
            var f = from[i];
            var t = to[i];
            var e = cost[i];
            G[f].Add(new KeyValuePair<int, long>(t, e));
            rG[t].Add(new KeyValuePair<int, long>(f, e));
        }
        var dist = new long[N];
        for (int i = 0; i < N - 1; i++)
            dist[i] = 1L << 60;
        var pq = new PriorityQueue<KeyValuePair<int, long>>((l, r) => l.Value.CompareTo(r.Value));
        pq.Enqueue(new KeyValuePair<int, long>(N - 1, 0));
        while (pq.Any())
        {
            var p = pq.Dequeue();
            if (dist[p.Key] < p.Value)
                continue;
            foreach (var next in rG[p.Key])
            {
                if (dist[next.Key] > next.Value + p.Value)
                {
                    dist[next.Key] = next.Value + p.Value;
                    pq.Enqueue(new KeyValuePair<int, long>(next.Key, dist[next.Key]));
                }
            }
        }
        var dp = new long?[N, K + 1];
        Func<int, int, long> dfs = null;
        dfs = (pos, k) =>
            {
                if (k == K)
                    return dist[pos];
                if (pos == N - 1)
                    return 0;
                if (dp[pos, k].HasValue)
                    return dp[pos, k].Value;
                long max = -1;
                foreach (var next in G[pos])
                    max = Math.Max(max, next.Value + dfs(next.Key, k + 1));
                var min = 1L << 60;
                foreach (var next in G[pos])
                    min = Math.Min(min, Math.Max(next.Value + dfs(next.Key, k), max));

                dp[pos, k] = min;
                return min;
            };
        var ans = dfs(0, 0);
        if (ans == 1L << 60)
            return -1;
        return ans;
    }
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
