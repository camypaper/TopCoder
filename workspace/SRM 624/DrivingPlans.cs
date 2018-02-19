using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DrivingPlans
{
    public int count(int N, int[] A, int[] B, int[] C)
    {
        var G = Enumerate(N, x => new List<KeyValuePair<int, long>>());
        for (int i = 0; i < A.Length; i++)
        {
            A[i]--; B[i]--;
            G[A[i]].Add(new KeyValuePair<int, long>(B[i], C[i]));
            G[B[i]].Add(new KeyValuePair<int, long>(A[i], C[i]));
        }
        var dist = Enumerate(2, x => new long[N]);
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < N; j++)
                dist[i][j] = 1000000000000;
        var src = new int[] { 0, N - 1 };
        var pat = Enumerate(2, x => new int[N]);
        for (int k = 0; k < 2; k++)
        {
            dist[k][src[k]] = 0;
            pat[k][src[k]] = 1;
            var pq = new BinaryHeapPriorityQueue<KeyValuePair<int, long>>((l, r) => l.Value.CompareTo(r.Value));
            pq.Enqueue(new KeyValuePair<int, long>(src[k], 0));
            while (pq.Any())
            {
                var p = pq.Dequeue();
                var u = p.Key;
                var v = p.Value;
                if (v > dist[k][u]) continue;
                foreach (var e in G[u])
                {
                    var to = e.Key;
                    var nc = v + e.Value;
                    if (nc < dist[k][to])
                    {
                        dist[k][to] = nc;
                        pat[k][to] = pat[k][u];
                        pq.Enqueue(new KeyValuePair<int, long>(to, nc));
                    }
                    else if (nc == dist[k][to])
                        pat[k][to] = (pat[k][to] + pat[k][u]) % 1000000009;
                }
            }

        }
        for (int i = 0; i < N; i++)
        {
            if (dist[0][N - 1] != dist[0][i] + dist[1][i]) continue;
            foreach (var e in G[i]) if (e.Value == 0) return -1;
        }

        return pat[0][N - 1];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int Naive_Test(int N, int[] A, int[] B, int[] C)
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
        var n = 4;
        int[] a = { 1, 4, 3 }, b = { 4, 3, 2 }, c = { 1, 1, 0 };
        Tests.Add(() => ManualTest(n, a.ToArray(), b.ToArray(), c.ToArray()));
    }
}
// CUT end
#region PriorityQueue by BinaryHeap
public class BinaryHeapPriorityQueue<T>
{
    private readonly List<T> heap;
    private readonly Comparison<T> compare;
    private int size;
    public BinaryHeapPriorityQueue() : this(Comparer<T>.Default) { }
    public BinaryHeapPriorityQueue(IComparer<T> comparer) : this(16, comparer.Compare) { }
    public BinaryHeapPriorityQueue(Comparison<T> comparison) : this(16, comparison) { }
    public BinaryHeapPriorityQueue(int capacity, Comparison<T> comparison)
    {
        this.heap = new List<T>(capacity);
        this.compare = comparison;
    }
    public void Enqueue(T item)
    {

        this.heap.Add(item);
        var i = size++;
        while (i > 0)
        {
            var p = (i - 1) >> 1;
            if (compare(this.heap[p], item) <= 0)
                break;
            this.heap[i] = heap[p];
            i = p;
        }
        this.heap[i] = item;

    }
    public T Dequeue()
    {
        var ret = this.heap[0];
        var x = this.heap[--size];
        var i = 0;
        while ((i << 1) + 1 < size)
        {
            var a = (i << 1) + 1;
            var b = (i << 1) + 2;
            if (b < size && compare(heap[b], heap[a]) < 0) a = b;
            if (compare(heap[a], x) >= 0)
                break;
            heap[i] = heap[a];
            i = a;
        }
        heap[i] = x;
        heap.RemoveAt(size);
        return ret;

    }
    public T Peek() { return heap[0]; }
    public int Count { get { return size; } }
    public bool Any() { return size > 0; }
}
#endregion