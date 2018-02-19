using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CucumberWatering
{
    public long theMin(int[] a, int K)
    {
        var xs = a.Select(x => (long)x).ToList(); xs.Add(-(1L << 60)); xs.Add(1L << 60);
        xs.Sort();
        var n = xs.Count;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i + 1 < a.Length; i++)
        {
            var f = xs.BinarySearch(a[i]);
            var t = xs.BinarySearch(a[i + 1]);
            G[f].Add(t); G[t].Add(f);
        }
        var w = Enumerate(n, x => new long[n]);
        for (int l = 0; l < n; l++)
            for (int r = 0; r < n; r++)
            {
                for (int i = l; i < r; i++)
                    foreach (var to in G[i])
                    {
                        var u = Math.Min(Math.Abs(xs[r] - xs[i]), Math.Abs(xs[l] - xs[i]));
                        var v = Math.Min(Math.Abs(xs[r] - xs[to]), Math.Abs(xs[l] - xs[to]));
                        if (l <= to && to <= r)
                        {
                            if (i <= to)
                                w[l][r] += Math.Min(Math.Abs(xs[to] - xs[i]), u + v);
                        }
                        else w[l][r] += u;
                    }
            }
        var dp = Enumerate(n, x => new long[K + 5]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < K + 2; j++)
                dp[i][j] = 1L << 60;
        dp[0][0] = 0;
        for (int i = 0; i < n; i++)
            for (int j = K + 1; j >= 0; j--)
            {
                for (int t = i + 1; t < n; t++)
                    dp[t][j + 1] = Math.Min(dp[t][j + 1], dp[i][j] + w[i][t]);
            }
        var min = 1L << 60;
        for (int i = 0; i <= K + 1; i++)
            min = Math.Min(min, dp[n - 1][i]);
        return min;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(int[] x, int K)
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
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
