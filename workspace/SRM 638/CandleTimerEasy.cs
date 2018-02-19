using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class CandleTimerEasy
{
    public int differentTime(int[] A, int[] B, int[] len)
    {
        var n = A.Length + 1;
        var G = new List<KeyValuePair<int, int>>[n];
        for (int i = 0; i < n; i++)
            G[i] = new List<KeyValuePair<int, int>>();
        for (int i = 0; i < n - 1; i++)
        {
            G[A[i]].Add(new KeyValuePair<int, int>(B[i], len[i]));
            G[B[i]].Add(new KeyValuePair<int, int>(A[i], len[i]));
        }
        var set = new HashSet<int>();
        var dist = new int[n];

        Func<int, int, int> dfs = null;
        dfs = (prev, cur) =>
        {
            var ret = dist[cur];
            foreach (var to in G[cur])
            {
                if (to.Key == prev) continue;
                var diff = Math.Abs(dist[cur] - dist[to.Key]);
                if (diff < to.Value)
                    ret = Math.Max(Math.Max(dist[cur], dist[to.Key]) + (to.Value - diff) / 2, ret);
                ret = Math.Max(ret, dfs(cur, to.Key));
            }

            return ret;
        };

        for (int i = 1; i < 1 << n; i++)
        {
            var pq = new MergeablePriorityQueue<KeyValuePair<int, int>>((l, r) => l.Value.CompareTo(r.Value));
            var count = 0;
            for (int k = 0; k < n; k++)
            {
                if (((i >> k) & 1) == 1 && G[k].Count == 1)
                {
                    pq.Enqueue(new KeyValuePair<int, int>(k, 0));
                    dist[k] = 0;
                    count++;
                }
                else dist[k] = 1 << 30;
            }
            if (count == 0) continue;
            while (pq.Any())
            {
                var p = pq.Dequeue();
                if (dist[p.Key] < p.Value) continue;
                foreach (var next in G[p.Key])
                {
                    if (p.Value + next.Value < dist[next.Key])
                    {
                        dist[next.Key] = p.Value + next.Value;
                        pq.Enqueue(new KeyValuePair<int, int>(next.Key, dist[next.Key]));
                    }
                }
            }
            var max = dfs(-1, 0);
            set.Add(max);
        }


        return set.Count;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new CandleTimerEasy();
        var u = new CandleTimerEasyTest();
        try
        {
            t.ManualTest(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, new int[] { 0, 1, 1, 3, 2, 4, 6, 6, 1, 6, 2, 11, 7 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            System.Diagnostics.Debug.Close();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }

    public void ManualTest(int[] A, int[] B, int[] len)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A))); Console.WriteLine(string.Format("B:{0}", string.Join(" ", B))); Console.WriteLine(string.Format("len:{0}", string.Join(" ", len))); sw.Start();
        var ret = differentTime(A, B, len);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
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
    static public T[] Enumerate<T>(this int n, Func<int, T> f)
    {
        var a = new T[n];
        for (int i = 0; i < n; i++)
            a[i] = f(i);
        return a;
    }
}
#region PriorityQueue and PairingHeap
public class MergeablePriorityQueue<T>
{
    PairingHeap<T> top;
    Comparison<T> compare;
    int size;
    public int Count { get { return size; } }
    public MergeablePriorityQueue() : this(Comparer<T>.Default) { }
    public MergeablePriorityQueue(Comparison<T> comparison) { compare = comparison; }
    public MergeablePriorityQueue(IComparer<T> comparer) { compare = comparer.Compare; }
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