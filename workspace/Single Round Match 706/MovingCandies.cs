using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MovingCandies
{
    public int minMoved(string[] t)
    {
        var cnt = 0;
        foreach (var x in t)
            cnt += x.Count(u => u == '#');
        var n = t.Length;
        var m = t[0].Length;
        var dp = new int[n, m, 451];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                for (int k = 0; k < 451; k++)
                    dp[i, j, k] = 1000000000;
        var q = new BinaryHeapPriorityQueue<KeyValuePair<int, int>>((l, r) =>
        {
            return (l.Value % 450).CompareTo(r.Value % 450);
        });
        if (t[0][0] == '#')
        {
            dp[0, 0, 1] = 0;
            q.Enqueue(new KeyValuePair<int, int>(0, 450));
        }
        else
        {
            dp[0, 0, 0] = 1;
            q.Enqueue(new KeyValuePair<int, int>(0, 1));
        }
      
       

        int[] dx = { 1, -1, 0, 0 };
        int[] dy = { 0, 0, 1, -1 };
        while (q.Count > 0)
        {
            var p = q.Dequeue();
            var x = p.Key / 20;
            var y = p.Key % 20;
            var k = p.Value / 450;
            var c = p.Value % 450;

            for (int d = 0; d < 4; d++)
            {
                var nx = x + dx[d];
                var ny = y + dy[d];
                if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
                if (t[nx][ny] == '#')
                {
                    var nk = k + 1;

                    if (nk < 450 && dp[nx, ny, nk] > c)
                    {
                        dp[nx, ny, nk] = c;
                        q.Enqueue(new KeyValuePair<int, int>(nx * 20 + ny, nk * 450 + c));
                    }
                }
                else
                {
                    var nk = k;
                    if (dp[nx, ny, nk] > c + 1)
                    {
                        dp[nx, ny, nk] = c + 1;
                        q.Enqueue(new KeyValuePair<int, int>(nx * 20 + ny, nk * 450 + c + 1));
                    }
                }
            }
        }
        var min = 1000000000;
        for (int k = 0; k <= cnt; k++)
        {
            var c = dp[n - 1, m - 1, k];
            if (k + c <= cnt)
                min = Math.Min(min, c);
        }
        if (min != 1000000000) return min;
        return -1;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] t)
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
    public void OnInit()
    {
        //Tests.Add(null);
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
        heap = new List<T>(capacity);
        compare = comparison;
    }
    public void Enqueue(T item)
    {

        heap.Add(item);
        var i = size++;
        while (i > 0)
        {
            var p = (i - 1) >> 1;
            if (compare(heap[p], item) <= 0)
                break;
            heap[i] = heap[p];
            i = p;
        }
        heap[i] = item;

    }
    public T Dequeue()
    {
        var ret = heap[0];
        var x = heap[--size];
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