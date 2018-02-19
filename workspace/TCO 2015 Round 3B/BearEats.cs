using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = Pair<long, int>;
public class BearEats
{
    public long getDifference(int N, int R, int C, int D, int A_MAX, int B_MAX)
    {
        var a = new Pair<long, long>[N];

        long ans = 0;
        {
            long r = R, c = C, d = D, aa = A_MAX, bb = B_MAX;
            for (int i = 0; i < N; i++)
            {
                r = (c * r + d) % 1000000007;
                var u = r % aa;
                r = (c * r + d) % 1000000007;
                var v = r % bb;
                a[i] = new Pair<long, long>(v, u);
                ans -= v;
            }
        }
        Array.Sort(a);
        Array.Reverse(a);
        var rmq = new RMQSegmentTree(N);
        for (int i = 0; i < N; i++)
            rmq.Update(i, new Number(a[i].x + a[i].y, i));
        for (int i = (N + 1) / 2 - 1; i >= 0; i--)
        {
            var l = 2 * i;
            var max = rmq.Query(l, N);
            ans += max.x;
            rmq.Update(max.y, new Number(-1000000000, max.y));
        }
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end

#region RMQ SegmentTree
public class RMQSegmentTree
{
    int n;
    Number[] data;
    readonly Number min = new Number(-1000000000, -1000000000);
    public RMQSegmentTree(int size)
    {
        n = 1;
        while (n < size)
            n <<= 1;
        data = new Number[n << 1];
        for (int i = 0; i < data.Length; i++)
            data[i] = min;
    }
    public void Update(int k, Number v)
    {
        k += n;
        data[k] = v;
        k >>= 1;
        while (k > 0)
        {
            data[k] = Pair.Max(data[k << 1], data[(k << 1) + 1]);
            k >>= 1;
        }

    }
    public Number Query(int a, int b) { return Query(a, b, 1, 0, n); }
    private Number Query(int a, int b, int k, int l, int r)
    {
        if (r <= a || b <= l)
            return min;
        if (a <= l && r <= b)
            return data[k];
        else
        {
            var vl = Query(a, b, k << 1, l, (l + r) >> 1);
            var vr = Query(a, b, (k << 1) + 1, (l + r) >> 1, r);
            return Pair.Max(vl, vr);
        }
    }
    public Number[] Items
    {
        get
        {
            var ret = new Number[n];
            for (int i = 0; i < n; i++)
                ret[i] = data[i + n];
            return ret;
        }
    }

}
#endregion

#region Compair
static public class Pair
{
    static public Pair<FT, ST> Max<FT, ST>(Pair<FT, ST> p, Pair<FT, ST> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return (p.CompareTo(q) >= 0) ? p : q; }
}
public struct Pair<FT, ST> : IComparable<Pair<FT, ST>>
    where FT : IComparable<FT>
    where ST : IComparable<ST>
{
    public FT x;
    public ST y;
    public Pair(FT f, ST s) : this() { x = f; y = s; }

    public int CompareTo(Pair<FT, ST> other)
    {
        var cmp = x.CompareTo(other.x);
        return cmp != 0 ? cmp : y.CompareTo(other.y);
    }
    public override string ToString() { return string.Format("{0} {1}", x, y); }
}
#endregion