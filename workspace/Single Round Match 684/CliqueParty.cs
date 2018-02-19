using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CliqueParty
{
    public int maxsize(int[] a, int c)
    {
        Array.Sort(a);
        var max = 0;
        var n = a.Length;
        var A = new long[n];
        long K = c;
        for (int i = 0; i < n; i++)
            A[i] = a[i];
        for (int _ = 0; _ < n; _++)
        {
            for (int __ = _ + 1; __ < n; __++)
            {
                var D = A[__] - A[_];
                for (int i = 0; i < n; i++)
                {
                    var dp = Enumerate(n, x => -1000000);
                    dp[i] = 1;
                    var min = A[i];
                    for (int k = i + 1; k < n; k++)
                    {
                        for (int l = i; l < k; l++)
                        {
                            var dmax = A[k] - min;
                            var dmin = A[k] - A[l];
                            if (dmin < D) continue;
                            if (dmax > D * K) continue;
                            dp[k] = Math.Max(dp[k], dp[l] + 1);
                        }
                    }
                    max = Math.Max(max, dp.Max());
                }


            }

        }
        var get = otaku(a, c);
        if (get != max)
        {
            var s = a.AsJoinedString(",");

        }
        return max;
    }
    public int otaku(int[] a, int c)
    {
        Array.Sort(a);
        var max = 0;
        var n = a.Length;
        var A = new long[n];
        long K = c;
        for (int i = 0; i < n; i++)
            A[i] = a[i];
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                var D = A[j] - A[i];
                var min = A[i];
                var dp = Enumerate(n, x => -1000000);
                dp[j] = 2;
                for (int k = j + 1; k < n; k++)
                {
                    for (int l = j; l < k; l++)
                    {
                        var dmax = A[k] - min;
                        var dmin = A[k] - A[l];
                        if (dmin < D) continue;
                        if (dmax > D * K) continue;
                        dp[k] = Math.Max(dp[k], dp[l] + 1);
                    }
                }
                max = Math.Max(max, dp.Max());

            }

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
        var rand = new Random(0);
        unchecked
        {
            var x = 1000000000;
            var y = 1000000000;
            var otaku = x * y;
        }
        while (true)
        {
            var n = 50;
            var a = Enumerate(n, x => rand.Next(1, 1000000));
            var k = rand.Next(1, 1000);
            test.ManualTest(a, k);
        }
    }
}
// CUT end
