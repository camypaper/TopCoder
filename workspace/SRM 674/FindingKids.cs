using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;
public class FindingKids
{
    public long getSum(int n, int q, int A, int B, int C)
    {
        var pos = new long[n];
        var dir = new int[n];
        var id = new int[q];
        var t = new long[q];
        long a = A, b = B, c = C;
        const long mod = (long)1e9 + 7;
        var s = new HashSet<long>();
        for (int i = 0; i < n; i++)
        {
            a = a * b + c;
            a %= mod;
            var p = a % (mod - n + i + 1);
            if (!s.Add(p)) p = mod - n + i;
            pos[i] = p;
            if (p % 2 == 0) dir[i] = 1;
            else dir[i] = -1;
        }
        //Debug.WriteLine(pos.AsJoinedString());
        for (int i = 0; i < q; i++)
        {
            a = a * b + c;
            a %= mod;
            id[i] = (int)(a % n);
            a = a * b + c;
            a %= mod;
            t[i] = a;
        }
        return f(n, q, pos, dir, id, t);
    }
    long f(int n, int Q, long[] pos, int[] dir, int[] id, long[] t)
    {
        long[] L, R;
        {
            var ll = new List<long>();
            var rr = new List<long>();
            for (int i = 0; i < n; i++)
            {
                if (dir[i] == 1) rr.Add(pos[i]);
                else ll.Add(pos[i]);
            }
            ll.Sort(); rr.Sort();
            L = ll.ToArray();
            R = rr.ToArray();
        }
        {
            var xs = L.Concat(R).ToList();
            xs.Sort();
            var go = new int[n];
            for (int i = 0; i < n; i++)
            {
                go[i] = xs.BinarySearch(pos[i]);
            }
            for (int i = 0; i < Q; i++)
                id[i] = go[id[i]];
        }
        //Array.Sort(t, id);
        long ans = 0;
        for (int i = 0; i < Q; i++)
        {
            var l = -100000000000;
            var r = +100000000000;
            var k = id[i];
            for (int _ = 0; _ < 50; _++)
            {
                var m = (l + r) / 2;
                var lub = L.UpperBound(m + t[i]);
                var rub = R.UpperBound(m - t[i]);
                if (lub + rub >= k + 1) r = m;
                else l = m;

            }
            ans += Math.Abs(r);
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
#region BinarySearch for Number[]
static public partial class Algorithm
{
    static public int LowerBound(this Number[] arr, Number v)
    {
        int l = 0, h = arr.Length - 1;
        while (l <= h)
        {
            int m = ((h + l) >> 1);
            if (arr[m] < v) l = m + 1;
            else h = m - 1;
        }
        return l;
    }
    static public int UpperBound(this Number[] a, Number v)
    {
        int l = 0, h = a.Length - 1;
        while (l <= h)
        {
            int m = ((h + l) >> 1);
            if (a[m] <= v) l = m + 1;
            else h = m - 1;
        }
        return l;
    }

}
#endregion