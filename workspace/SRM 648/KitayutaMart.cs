using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KitayutaMart
{
    public int lastPrice(int N, int K)
    {
        const long MOD = 1000000007;

        if (K <= 5000005)
        {
            N--;
            var pq = new BinaryHeapPriorityQueue();
            for (int i = 1; i <= K; i++) pq.Enqueue(i);
            while (N > 0)
            {
                var p = pq.Dequeue();
                if (p * 2 >= K)
                {
                    pq.Enqueue(p); break;
                }
                pq.Enqueue(p * 2);
                N--;
            }
            if (N == 0) return (int)(pq.Dequeue() % MOD);
            var k = N / K;
            N %= K;
            var a = pq.heap.ToArray();
            Array.Sort(a);
            var ans = ModPow(2, k, MOD) * a[N];
            return (int)(ans % MOD);

        }
        else
        {
            BigInteger l = 0, r = BigInteger.Pow(2, 250);
            for (int _ = 0; _ < 255 ; _++)
            {
                var m = (l + r) / 2;
                BigInteger cnt = 0;
                BigInteger v = m;
                while (v > 0 && cnt < N)
                {
                    cnt += BigInteger.Min(v, K);
                    v /= 2;
                }
                if (cnt >= N)
                    r = m;
                else l = m;
            }
            return (int)(r % MOD);
        }
    }
    static public long ModPow(long x, long n, long mod)
    {
        long r = 1;
        while (n > 0)
        {
            if ((n & 1) == 1)
                r = r * x % mod;
            x = x * x % mod;
            n >>= 1;
        }
        return r;
    }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(1000000000, 5000001);
    }
}
// CUT end
#region PriorityQueue by BinaryHeap
public class BinaryHeapPriorityQueue
{
    public readonly List<long> heap;
    private int size;
    public BinaryHeapPriorityQueue()
    {

        this.heap = new List<long>(5000000);
    }
    public void Enqueue(long item)
    {

        this.heap.Add(item);
        var i = size++;
        while (i > 0)
        {
            var p = (i - 1) >> 1;
            if (this.heap[p] <= item)
                break;
            this.heap[i] = heap[p];
            i = p;
        }
        this.heap[i] = item;

    }
    public long Dequeue()
    {
        var ret = this.heap[0];
        var x = this.heap[--size];
        var i = 0;
        while ((i << 1) + 1 < size)
        {
            var a = (i << 1) + 1;
            var b = (i << 1) + 2;
            if (b < size && heap[b] < heap[a]) a = b;
            if (heap[a] >= x)
                break;
            heap[i] = heap[a];
            i = a;
        }
        heap[i] = x;
        heap.RemoveAt(size);
        return ret;

    }
    public int Count { get { return size; } }
    public bool Any() { return size > 0; }
}
#endregion