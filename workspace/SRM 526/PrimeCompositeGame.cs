using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PrimeCompositeGame {
    public int theOutcome(int N, int K) {
        var isP = Enumerate(N + 50, x => true);
        isP[0] = isP[1] = false;
        var primes = new List<int>();
        var composites = new List<int>();
        for (int i = 2; i < N + 50; i++)
            if (isP[i]) {
                primes.Add(i);
                for (int j = i * 2; j < N + 50; j += i)
                    isP[j] = false;
            }
            else {
                composites.Add(i);
            }
        var len = new int[] { primes.Count, composites.Count };
        var min = Enumerate(2, x => new RmQ(len[x] + 5));
        var max = Enumerate(2, x => new RMQ(len[x] + 5));
        for (int k = 0; k < 2; k++)
            for (int i = 0; i < len[k] + 5; i++) {
                min[k].Update(i, 1000000000);
                max[k].Update(i, -1000000000);
            }
        for (int i = 2; i <= N; i++) {
            if (i != N && isP[i]) {
                var p = primes.BinarySearch(i);
                var l = composites.BinarySearch(i - K);
                var r = ~composites.BinarySearch(i);
                if (l < 0) l = ~l;
                var mi = min[1].Query(l, r);
                if (mi < 1000000000) {
                    max[0].Update(p, mi + 1);
                }
                else {
                    var ma = max[1].Query(l, r);
                    ma = Math.Max(0, ma + 1);
                    min[0].Update(p, ma);
                }
            }
            else {
                if (i == N) {
                }
                var p = composites.BinarySearch(i);
                var l = primes.BinarySearch(i - K);
                var r = primes.BinarySearch(i);
                if (l < 0) l = ~l;
                if (r < 0) r = ~r;

                var mi = min[0].Query(l, r);
                if (mi < 1000000000) {
                    if (i == N) return (int)(mi + 1);
                    max[1].Update(p, mi + 1);
                }
                else {
                    var ma = max[0].Query(l, r);
                    ma = Math.Max(0, ma + 1);
                    if (i == N) return (int)-ma;
                    min[1].Update(p, ma);
                }
            }

        }
        return 0;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int N, int K) {
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
        ManualTest(474747, 1);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
#region Segment Tree Node
public interface IData<T> {
    T Merge(T l, T r);
    T Identity { get; }
}
#endregion
#region Segment Tree

public class SegmentTree<T, U>
   where U : struct, IData<T> {
    int sz;
    int n;
    T[] data;
    U op = default(U);
    public SegmentTree(int size) {
        sz = size;
        n = 1;
        while (n < size) n *= 2;
        data = new T[n * 2];
        for (int i = 0; i < data.Length; i++)
            data[i] = op.Identity;
    }
    public SegmentTree(T[] a) {
        sz = a.Length;
        n = 1;
        while (n < sz) n *= 2;
        data = new T[n * 2];
        for (int i = 0; i < n; i++)
            data[i + n] = (i < a.Length) ? a[i] : op.Identity;
        for (int i = n - 1; i >= 0; i--)
            data[i] = op.Merge(data[i * 2], data[i * 2 + 1]);
    }
    public void Update(int k, T v) {
        k += n;
        data[k] = v;
        for (k = k / 2; k > 0; k /= 2)
            data[k] = op.Merge(data[k * 2], data[k * 2 + 1]);

    }
    public T Query(int a, int b) { return query(a, b, 1, 0, n); }
    private T query(int a, int b, int k, int l, int r) {
        if (r <= a || b <= l)
            return op.Identity;
        if (a <= l && r <= b)
            return data[k];
        else {
            var vl = query(a, b, k * 2, l, (l + r) / 2);
            var vr = query(a, b, k * 2 + 1, (l + r) / 2, r);
            return op.Merge(vl, vr);
        }
    }
    public T[] Items {
        get {
            var ret = new T[sz];
            for (int i = 0; i < sz; i++)
                ret[i] = data[i + n];
            return ret;
        }
    }

}
#endregion
#region RmQ
public class RmQ: SegmentTree<int, MinData> {
    public RmQ(int size) : base(size) { }
}
public struct MinData: IData<int> {
    public int Identity { get { return int.MaxValue; } }
    public int Merge(int l, int r) { return Math.Min(l, r); }
}
#endregion
#region RMQ
public class RMQ: SegmentTree<int, MaxData> {
    public RMQ(int size) : base(size) { }
}
public struct MaxData: IData<int> {
    public int Identity { get { return int.MinValue; } }
    public int Merge(int l, int r) { return Math.Max(l, r); }
}
#endregion