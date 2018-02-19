using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxConnection3
{
    public long minimalSteps(int[] x, int[] y)
    {
        dic = new SortedDictionary<ComparableList<Pair<int, int>>, long>();
        N = x.Length;
        X = x; Y = y;
        var ans = f(1, new ComparableList<Pair<int, int>>() { new Pair<int, int>(0, 0) });
        Debug.WriteLine(cnt);
        return ans;
    }
    int N;
    int[] X, Y;
    int[] dx = { 1, -1, 0, 0 };
    int[] dy = { 0, 0, -1, 1 };
    int cnt = 0;
    SortedDictionary<ComparableList<Pair<int, int>>, long> dic;
    public long f(int cur, ComparableList<Pair<int, int>> p)
    {
        {
            long res;
            if (dic.TryGetValue(p, out res))
                return res;
        }
        var min = long.MaxValue;
        if (cur == N)
        {
            //Debug.WriteLine(p.AsJoinedString());
            var a = Enumerate(N, x => x);
            do
            {
                min = Math.Min(min, g(a, p));
            } while (MathEx.NextPermutation(a, 0, N));
            cnt++;
        }
        else
        {
            for (int i = 0; i < p.Count; i++)
            {
                for (int d = 0; d < 4; d++)
                {
                    var np = new Pair<int, int>(p[i].x + dx[d], p[i].y + dy[d]);
                    if (np.y < 0) continue;
                    var ok = true;
                    for (int j = 0; j < p.Count; j++)
                        if (p[j].CompareTo(np) == 0) ok = false;
                    if (ok)
                    {
                        p.Add(np);
                        p.Sort();
                        min = Math.Min(f(cur + 1, p), min);
                        p.Remove(np);
                    }
                }
            }
        }
        var key = new ComparableList<Pair<int, int>>();
        for (int k = 0; k < p.Count; k++)
        {
            key.Add(new Pair<int, int>(p[k].x, p[k].y));
            dic[key] = min;
        }
        return min;

    }
    long g(int[] a, ComparableList<Pair<int, int>> p)
    {
        //Debug.WriteLine(p.AsJoinedString());
        long val = 0;
        {
            var xs = new long[N];
            for (int i = 0; i < N; i++)
                xs[i] = X[i] - p[a[i]].x;
            Array.Sort(xs);
            var x = N % 2 == 1 ? xs[N / 2] : (xs[(N - 1) / 2] + xs[N / 2]) / 2;
            for (int i = 0; i < N; i++)
                val += Math.Abs(xs[i] - x);
        }
        {
            var xs = new long[N];
            for (int i = 0; i < N; i++)
                xs[i] = Y[i] - p[a[i]].y;
            Array.Sort(xs);
            var x = N % 2 == 1 ? xs[N / 2] : (xs[(N - 1) / 2] + xs[N / 2]) / 2;
            for (int i = 0; i < N; i++)
                val += Math.Abs(xs[i] - x);
        }
        return val;
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


#region Compair
static public class Pair
{
    static public Pair<FT, ST> Create<FT, ST>(FT f, ST s)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return new Pair<FT, ST>(f, s); }
    static public Pair<FT, ST> Min<FT, ST>(Pair<FT, ST> p, Pair<FT, ST> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return (p.CompareTo(q) <= 0) ? p : q; }
    static public Pair<FT, ST> Max<FT, ST>(Pair<FT, ST> p, Pair<FT, ST> q)
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    { return (p.CompareTo(q) >= 0) ? p : q; }
}
public struct Pair<FT, ST>: IComparable<Pair<FT, ST>>
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

#region ComparableList
public class ComparableList<T>: List<T>, IComparable<ComparableList<T>> where T : IComparable<T>
{
    public int CompareTo(ComparableList<T> other)
    {
        var k = Math.Min(Count, other.Count);
        for (int i = 0; i < k; i++)
        {
            var cmp = this[i].CompareTo(other[i]);
            if (cmp != 0) return cmp;
        }
        return Count.CompareTo(other.Count);
    }
}
#endregion

#region next_permutation
static public partial class MathEx
{

    static public bool NextPermutation<T>(this T[] array, int first, int last) where T : IComparable<T>
    {
        if (first == last)
            return false;
        var i = last;
        if (--i == first)
            return false;
        while (true)
        {
            var ii = i--;
            if (array[i].CompareTo(array[ii]) < 0)
            {
                var j = last;
                while (array[i].CompareTo(array[--j]) >= 0) { }
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                Array.Reverse(array, ii, last - ii);
                return true;
            }
            if (i == first)
            {
                Array.Reverse(array, first, last - first);
                return false;
            }
        }
    }

}
#endregion

#region BinarySearch
static public partial class Algorithm
{
    /// <summary>
    /// f(x) \leq f(x+1)‚Æ‚È‚é‹«ŠE‚ð’T‚·
    /// </summary>
    static public long BinarySearch(long l, long r, Func<long, long> f, int K = 32)
    {
        for (int i = 0; i < K; i++)
        {
            var x = (l + r) / 2;
            var u = f(x);
            var v = f(x + 1);
            if (u >= v) l = x;
            else r = x;
        }
        return f(r);
    }
}
#endregion