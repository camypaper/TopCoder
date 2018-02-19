using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColorfulWolves {
    public int getmin(string[] colormap) {
        var n = colormap.Length;
        var dp = Enumerate(n, x => 1 << 20);
        var pq = new PriorityQueue<KeyValuePair<int, int>>((l, r) => l.Value.CompareTo(r.Value));
        pq.Enqueue(new KeyValuePair<int, int>(n - 1, 0));
        dp[n - 1] = 0;

        while (pq.Any()) {
            var p = pq.Dequeue();
            Debug.WriteLine(p);
            for (int i = 0; i < n; i++) {
                var k = 0;
                for (int j = 0; j < n; j++) {
                    if (colormap[i][j] != 'Y') continue;
                    if (j == p.Key) {
                        var x = p.Value + k;
                        if (dp[i] > x) {
                            dp[i] = x;
                            pq.Enqueue(new KeyValuePair<int, int>(i, x));
                        }
                    }
                    k++;
                }
            }
        }
        if (dp[0] == 1 << 20) return -1;
        return dp[0];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] colormap) {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX {
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester {
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run() {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
#region BinaryHeap
public class PriorityQueue<T> {
    readonly List<T> heap = new List<T>();
    readonly Comparison<T> compare;
    public PriorityQueue() { compare = Comparer<T>.Default.Compare; }

    public PriorityQueue(Comparison<T> comparison) { compare = comparison; }
    public PriorityQueue(IComparer<T> comparer) { compare = comparer.Compare; }

    public void Enqueue(T item) {
        var pos = heap.Count;
        heap.Add(item);
        while (pos > 0) {
            var par = (pos - 1) / 2;
            if (compare(heap[par], item) <= 0)
                break;
            heap[pos] = heap[par];
            pos = par;
        }
        heap[pos] = item;

    }

    public T Dequeue() {
        var ret = heap[0];
        var pos = 0;
        var x = heap[heap.Count - 1];

        while (pos * 2 + 1 < heap.Count - 1) {
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

    public T[] Items {
        get {
            var ret = heap.ToArray();
            Array.Sort(ret, compare);
            return ret;
        }
    }
}
#endregion