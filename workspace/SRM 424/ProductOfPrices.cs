using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class ProductOfPrices
{
    public int product(int N, int L, int X0, int A, int B)
    {
        const long mod = (long)1e9 + 7;
        var pos = new long[N];
        pos[0] = X0 % L;
        for (int i = 1; i < N; i++)
            pos[i] = (pos[i - 1] * A + B) % L;
        var zip = pos.Distinct().ToArray();
        Array.Sort(zip);
        var sz = zip.Length;
        var cnt = new FenwickTree(sz + 1);
        var sum = new FenwickTree(sz + 1);
        {
            var p = Array.BinarySearch(zip, pos[0]);
            cnt.Add(p + 1, 1);
            sum.Add(p + 1, pos[0]);
        }
        var list = new List<long>();
        for (int i = 1; i < N; i++)
        {
            var p = Array.BinarySearch(zip, pos[i]);
            var val = 0L;
            {
                var l = cnt[p];
                var lsum = sum[p];
                val += l * pos[i] - lsum;
            }
            {
                var r = cnt[p + 1, sz];
                var rsum = sum[p + 1, sz];
                val += rsum - r * pos[i];
            }
            cnt.Add(p + 1, 1);
            sum.Add(p + 1, pos[i]);
            list.Add(val % mod);
        }
        long ans = 1;
        foreach (var x in list)
            ans = ans * x % mod;
        return (int)ans;
    }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ")
    {
        return string.Join(s, e);
    }
}


#region FenwickTree
[System.Diagnostics.DebuggerDisplay("Data={ToString()}")]
public class FenwickTree
{
    int n;
    long[] bit;
    int max = 1;
    public FenwickTree(int size)
    {
        n = size; bit = new long[n + 1];
        while ((max << 1) <= n) max <<= 1;
    }
    /// <summary>sum[a,b]</summary>
    public long this[int i, int j] { get { return this[j] - this[i - 1]; } }
    /// <summary>sum[0,i]</summary>
    public long this[int i] { get { long s = 0; for (; i > 0; i -= i & -i) s += bit[i]; return s; } }
    public int LowerBound(long w)
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
    public void Add(int i, long v)
    {
        if (i == 0) System.Diagnostics.Debug.Fail("BIT is 1 indexed");
        for (; i <= n; i += i & -i) bit[i] += v;
    }
    public override string ToString() { return string.Join(",", Enumerable.Range(0, n + 1).Select(i => this[i, i])); }
}
#endregion