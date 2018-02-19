using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CatchTheBeat
{
    public int maxCatched(int n, int x0, int y0, int a, int b, int c, int d, int mod1, int mod2, int offset)
    {
        var X = new int[n];
        var Y = new int[n];
        X[0] = x0; Y[0] = y0;
        for (int i = 1; i < n; i++)
        {
            X[i] = (int)((Math.BigMul(X[i - 1], a) + b) % mod1);
            Y[i] = (int)((Math.BigMul(Y[i - 1], c) + d) % mod2);
        }
        for (int i = 0; i < n; i++)
            X[i] -= offset;
        return f(X, Y);
    }
    int f(int[] X, int[] Y)
    {
        var n = X.Length;
        var Z = new KeyValuePair<int, int>[n];
        for (int i = 0; i < n; i++)
            Z[i] = new KeyValuePair<int, int>(Y[i] - X[i], X[i] + Y[i]);
        Array.Sort(Z, (l, r) =>
        {
            var cmp = l.Key.CompareTo(r.Key);
            if (cmp != 0) return cmp;
            return l.Value.CompareTo(r.Value);
        });
        var dp = new long[n + 50];
        for (int i = 0; i < n + 50; i++)
            dp[i] = 1000000000000;
        foreach (var x in Z)
        {
            if (x.Key < 0 || x.Value < 0) continue;
            var p = dp.UpperBound(x.Value);
            dp[p] = x.Value;
        }
        for (int i = n; i >= 0; i--)
        {
            if (dp[i] < dp[n + 48]) return i + 1;
        }
        return 0;
    }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {

    }
}
// CUT end
static public partial class Algorithm
{

    static private int binarySearch<T>(this T[] a, int idx, int len, T v, Comparison<T> cmp, bool islb)
    {
        int l = idx;
        int h = idx + len - 1;
        while (l <= h)
        {
            int i = l + ((h - l) >> 1);
            int ord;
            if (a[i] == null || v == null) return -1;
            else ord = cmp(a[i], v);
            if (ord < 0) l = i + 1;
            else if (ord == 0)
            {
                if (!islb) l = i + 1;
                else h = i - 1;
            }
            else h = i - 1;
        }

        return l;
    }
    static public int UpperBound<T>(this T[] a, int idx, int len, T v, Comparison<T> cmp) { return binarySearch(a, idx, len, v, cmp, false); }
    static public int UpperBound<T>(this T[] a, T v) where T : IComparable<T> { return UpperBound(a, 0, a.Length, v, Comparer<T>.Default.Compare); }
}
