using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheGridDivOne
{
    public int find(int[] X, int[] Y, int K)
    {
        var xs = new List<int>() { -1, 0, 1 };
        var ys = new List<int>() { -1, 0, 1 };
        foreach (var x in X)
            for (int i = -1; i <= 1; i++)
                xs.Add(x + i);
        foreach (var x in Y)
            for (int i = -1; i <= 1; i++)
                ys.Add(x + i);
        xs = xs.Distinct().OrderBy(x => x).ToList();
        ys = ys.Distinct().OrderBy(x => x).ToList();
        var dp = Enumerate(xs.Count, x => new long[ys.Count]);
        var n = xs.Count;
        var m = ys.Count;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                dp[i][j] = 1000000000000;
        dp[xs.BinarySearch(0)][ys.BinarySearch(0)] = 0;
        var pq = new BinaryHeapPriorityQueue<KeyValuePair<int, long>>((l, r) => l.Value.CompareTo(r.Value));
        pq.Enqueue(new KeyValuePair<int, long>(xs.BinarySearch(0) * m + ys.BinarySearch(0), 0));
        var dame = new bool[n, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < X.Length; k++)
                {
                    if (X[k] == xs[i] && Y[k] == ys[j]) dame[i, j] = true;
                }
            }
        while (pq.Any())
        {
            var p = pq.Dequeue();
            var px = p.Key / m;
            var py = p.Key % m;
            var pz = p.Value;
            //Debug.WriteLine("{0} {1} {2}", xs[px], ys[py], pz);
            for (int i = -1; i <= 1; i += 2)
            {
                if (0 <= px + i && px + i < n && !dame[px + i, py])
                {
                    var nz = pz + Math.Abs(xs[px + i] - xs[px]);
                    if (dp[px + i][py] > nz)
                    {
                        dp[px + i][py] = nz;
                        pq.Enqueue(new KeyValuePair<int, long>((px + i) * m + py, nz));
                    }
                }
                if (0 <= py + i && py + i < m && !dame[px, py + i])
                {
                    var nz = pz + Math.Abs(ys[py + i] - ys[py]);
                    if (dp[px][py + i] > nz)
                    {
                        dp[px][py + i] = nz;
                        pq.Enqueue(new KeyValuePair<int, long>((px) * m + py + i, nz));
                    }
                }
            }
        }
        var max = 0L;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (dp[i][j] <= K)
                {
                    max = Math.Max(max, xs[i]);
                    if (i == n - 1)
                        max = Math.Max(max, xs[i] + K - dp[i][j]);
                    else
                    {
                        var dx = xs[i + 1] - xs[i];
                        if ((K - dp[i][j]) < dx) max = Math.Max(max, xs[i] + K - dp[i][j]);
                    }
                }


            }
        return (int)max;
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