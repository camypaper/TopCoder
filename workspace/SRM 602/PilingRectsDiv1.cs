using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PilingRectsDiv1
{
    public long getmax(int N, int[] XS, int[] YS, int XA, int XB, int XC, int YA, int YB, int YC)
    {
        long[] xs = new long[2 * N];
        long[] ys = new long[2 * N];
        for (int i = 0; i < XS.Length; i++)
        {
            xs[i] = XS[i];
            ys[i] = YS[i];
        }
        for (int i = XS.Length; i < 2 * N; i++)
        {
            xs[i] = (xs[i - 1] * XA + XB) % XC + 1;
            ys[i] = (ys[i - 1] * YA + YB) % YC + 1;
        }
        for (int i = 0; i < 2 * N; i++)
        {
            if (xs[i] > ys[i]) Swap(ref xs[i], ref ys[i]);
        }
        var id = Enumerate(2 * N, x => x).OrderBy(x => xs[x] * 1000000000 + ys[x]).ToArray();
        var kv = new List<long>();
        for (int i = 0; i < 2 * N; i++)
            kv.Add(xs[i] * 2000000000 + ys[i]);
        kv.Sort();
        for (int i = 0; i < 2 * N; i++)
        {
            xs[i] = kv[i] / 2000000000;
            ys[i] = kv[i] % 2000000000;
        }
        return solve(N, xs, ys);
    }
    public long solve(int n, long[] xs, long[] ys)
    {
        Debug.WriteLine(xs.AsJoinedString());
        Debug.WriteLine(ys.AsJoinedString());
        var max = 0L;
        var yss = ys.Distinct().OrderBy(x => x).ToList();
        var m = yss.Count;
        var rem = new FenwickTree(m);
        var usd = new FenwickTree(m);
        for (int i = 0; i < 2 * n; i++)
        {
            var pos = yss.BinarySearch(ys[i]);
            if (i == 0) usd.Add(pos + 1, 1);
            else rem.Add(pos + 1, 1);
        }
        yss.Add(2000000000);
        for (int i = 1; i <= n; i++)
        {

            rem.Add(yss.BinarySearch(ys[i]) + 1, -1);
            //s1‘¤‚ð‘å‚«‚­‚·‚é
            {
                var ym1 = yss[usd.LowerBound(1) - 1];
                var pos = rem.LowerBound(n);
                var ym1_2 = yss[pos - 1];
                var ym2 = yss[rem.LowerBound(1) - 1];
                max = Math.Max(max, xs[0] * Math.Min(ym1, ym1_2) + xs[i] * Math.Min(ys[i], ym2));
            }
            //s2‘¤‚ð‘å‚«‚­‚·‚é
            {
                var ym1 = yss[usd.LowerBound(1) - 1];
                var pp = rem.LowerBound(1);
                var ym1_2 = yss[pp - 1];
                var pos = rem.LowerBound(n - i + 1);
                var ym2 = yss[pos - 1];
                max = Math.Max(max, xs[0] * Math.Min(ym1, ym1_2) + xs[i] * Math.Min(ys[i], ym2));
            }

            usd.Add(yss.BinarySearch(ys[i]) + 1, 1);
        }
        return max;
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
        test.ManualTest(5, new int[] { 97, 555, 436, 658, 575, 508, 940, 575, 754, 732 }, new int[] { 618, 266, 481, 289, 464, 444, 952, 843, 201, 34 }, 312, 960, 603, 799, 798, 904);

        // test.ManualTest(1, new int[] { 1 }, new int[] { 1 }, 1, 1, 1, 1, 1, 1);
    }
}
// CUT end
#region FenwickTree
[System.Diagnostics.DebuggerDisplay("Data={ToString()}")]
public class FenwickTree
{
    int n;
    int[] bit;
    int max = 1;
    public FenwickTree(int size)
    {
        n = size; bit = new int[n + 1];
        while ((max << 1) <= n) max <<= 1;
    }
    /// <summary>sum[a,b]</summary>
    public int this[int i, int j] { get { return this[j] - this[i - 1]; } }
    /// <summary>sum[0,i]</summary>
    public int this[int i] { get { int s = 0; for (; i > 0; i -= i & -i) s += bit[i]; return s; } }
    public int LowerBound(int w)
    {
        if (w <= 0) return 0;
        int x = 0;
        for (int k = max; k > 0; k >>= 1)
            if (x + k <= n && bit[x + k] < w)
            {
                w -= bit[x + k];
                x += k;
            }
        return x + 1;
    }
    /// <summary>add v to bit[i]</summary>
    public void Add(int i, int v)
    {
        if (i == 0) System.Diagnostics.Debug.Fail("BIT is 1 indexed");
        for (; i <= n; i += i & -i) bit[i] += v;
    }
    public override string ToString() { return string.Join(",", Enumerable.Range(0, n + 1).Select(i => this[i, i])); }
}
#endregion