using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAirline
{
    public int minimalCost(int n, int[] a, int[] b, int[] c)
    {
        const int INF = 100000000;
        var d = Enumerate(n, x => new int[n]);
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                d[i][j] = d[j][i] = INF;
        for (int i = 0; i < a.Length; i++)
            d[a[i]][b[i]] = c[i];
        var dp = new int[1 << n, n, n];
        for (int i = 0; i < 1 << n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                    dp[i, j, k] = INF;
        var pq = new PriorityQueue<KeyValuePair<int, int>>((l, r) => l.Value.CompareTo(r.Value));
        for (int i = 0; i < n; i++)
        {
            dp[1 << i, i, i] = 0;
            pq.Enqueue(new KeyValuePair<int, int>(encode(n, 1 << i, i, i), 0));
        }
        while (pq.Any())
        {
            var p = pq.Dequeue();
            int i, f, t; decode(n, p.Key, out i, out f, out t);
            var w = p.Value;
            for (int j = 0; j < n; j++)
            {
                if (d[t][j] == INF) continue;
                var nw = w + d[t][j];
                if (dp[i | (1 << j), f, j] > nw)
                {
                    dp[i | (1 << j), f, j] = nw;
                    pq.Enqueue(new KeyValuePair<int, int>(encode(n, i | (1 << j), f, j), nw));
                }
            }
        }
        var dp2 = new int[1 << n];
        for (int i = 0; i < 1 << n; i++)
            dp2[i] = INF;
        var all = (1 << n) - 1;
        dp2[1] = 0;
        for (int i = 1; i < 1 << n; i++)
        {
            if (dp2[i] == INF) continue;
            var sub = all ^ i;
            for (int s = sub; s > 0; s = (s - 1) & sub)
            {
                for (int f = 0; f < n; f++)
                    for (int t = 0; t < n; t++)
                    {
                        if ((i >> f & 1) == 0 || (i >> t & 1) == 0) continue;
                        dp2[i | s] = Math.Min(dp2[i | s], dp2[i] + dp[s | (1 << f) | (1 << t), f, t]);
                    }
            }
        }
        if (dp2.Last() == INF) return -1;
        return dp2.Last();
    }
    int encode(int n, int mask, int from, int to)
    {
        int res = mask;
        res = res * n + from;
        res = res * n + to;
        return res;
    }
    void decode(int n, int s, out int mask, out int from, out int to)
    {
        to = s % n; s /= n;
        from = s % n; s /= n;
        mask = s;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int n, int[] a, int[] b, int[] c)
    {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
#region BinaryHeap
public class PriorityQueue<T>
{
    readonly List<T> heap = new List<T>();
    readonly Comparison<T> compare;
    public PriorityQueue() { compare = Comparer<T>.Default.Compare; }

    public PriorityQueue(Comparison<T> comparison) { compare = comparison; }
    public PriorityQueue(IComparer<T> comparer) { compare = comparer.Compare; }

    public void Enqueue(T item)
    {
        var pos = heap.Count;
        heap.Add(item);
        while (pos > 0)
        {
            var par = (pos - 1) / 2;
            if (compare(heap[par], item) <= 0)
                break;
            heap[pos] = heap[par];
            pos = par;
        }
        heap[pos] = item;

    }

    public T Dequeue()
    {
        var ret = heap[0];
        var pos = 0;
        var x = heap[heap.Count - 1];

        while (pos * 2 + 1 < heap.Count - 1)
        {
            var lch = pos * 2 + 1;
            var rch = pos * 2 + 2;
            if (rch < heap.Count - 1 && compare(heap[rch], heap[lch]) < 0) lch = rch;
            if (compare(heap[lch], x) >= 0)
                break;
            heap[pos] = heap[lch];
            pos = lch;
        }
        heap[pos] = x;
        heap.RemoveAt(heap.Count - 1);
        return ret;

    }
    public T Peek() { return heap[0]; }
    public int Count { get { return heap.Count; } }
    public bool Any() { return heap.Count > 0; }

    public T[] Items
    {
        get
        {
            var ret = heap.ToArray();
            Array.Sort(ret, compare);
            return ret;
        }
    }
}
#endregion