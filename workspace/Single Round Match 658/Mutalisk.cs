using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class Mutalisk
{
    public int minimalAttacks(int[] a)
    {
        int l = 1, r = 1000;
        var k = 0;
        while (l <= r && k < 100)
        {
            var m = (l + r) / 2;
            if (f(a, m))
                r = m;
            else l = m;
            k++;
        }
        return r;
    }
    public bool f(int[] a, int k)
    {
        var pq = new PriorityQueue<KeyValuePair<int, int>>((p, q) =>
        {
            var cmp = (q.Key + q.Value * 3).CompareTo(p.Key + p.Value * 3);
            return cmp != 0 ? cmp : q.Value.CompareTo(p.Value);
        });
        foreach (var x in a)
            pq.Enqueue(new KeyValuePair<int, int>(x, 0));
        for (int i = 0; i < k; i++)
        {
            if (!pq.Any())
                return true;
            var p = pq.Dequeue();
            System.Diagnostics.Debug.WriteLine(p);
            var np = p.Key - 9;
            if (np > 0) pq.Enqueue(new KeyValuePair<int, int>(np, p.Value + 1));
        }
        for (int i = 0; i < k; i++)
        {
            if (!pq.Any())
                return true;
            var p = pq.Dequeue();
            System.Diagnostics.Debug.WriteLine(p);
            var np = p.Key - 3;
            if (np > 0)
            {
                if (p.Value >= k)
                    return false;
                pq.Enqueue(new KeyValuePair<int, int>(np, p.Value + 1));
            }
        }
        for (int i = 0; i < k; i++)
        {
            if (!pq.Any())
                return true;
            var p = pq.Dequeue();
            System.Diagnostics.Debug.WriteLine(p);
            var np = p.Key - 1;
            if (np > 0)
            {
                if (p.Value >= k)
                    return false;
                pq.Enqueue(new KeyValuePair<int, int>(np, p.Value + 1));
            }
        }
        if (pq.Any())
            return false;
        return true;
    }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ")
    {
        return string.Join(s, e);
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