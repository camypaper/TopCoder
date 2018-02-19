using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;

public class BuildingTowers
{
    public long maxHeight(int N, int K, int[] x, int[] t)
    {
        var n = x.Length;
        var a = new List<long>();
        var b = new List<long>();
        a.Add(1);
        b.Add(0);
        foreach (var v in x)
            a.Add(v);
        foreach (var v in t)
            b.Add(v);
        if (!a.Any() || a.Last() != N)
        {
            a.Add(N);
            b.Add(Math.BigMul(N - 1, K));
        }
        return solve(N, K, a.ToArray(), b.ToArray());
    }
    long solve(long num, long k, long[] u, long[] h)
    {

        var n = u.Length;
        while (true)
        {
            var go = false;
            for (int i = 1; i < n; i++)
            {
                var t = h[i - 1] + k * (u[i] - u[i - 1]);
                if (h[i] > t)
                {
                    h[i] = t;
                    go = true;
                }
            }
            for (int i = n - 2; i >= 0; i--)
            {
                var t = h[i + 1] + k * (u[i + 1] - u[i]);
                if (h[i] > t)
                {
                    h[i] = t;
                    go = true;
                }
            }
            if (!go) break;
        }
        long ans = 0;
        foreach (var v in h) ans = Math.Max(ans, v);
        for (int i = 1; i < n; i++)
        {
            long l = 1, r = h[i - 1] + k * (u[i] - u[i - 1]);
            while (l <= r)
            {
                var m = (l + r) / 2;
                var diff = m - h[i - 1];
                var p = diff / k;
                if (diff % k > 0) p++;
                var rem = u[i] - u[i - 1] - p;
                if (m - rem * k <= h[i])
                    l = m + 1;
                else r = m - 1;

            }
            Console.WriteLine("{0} {1}",i,l-1);
            ans = Math.Max(ans, l - 1);
        }
        return ans;
    }
    // CUT begin

    public void ManualTest()
    {
        var s = Scanner.In.string_array();
        Console.WriteLine(s.AsJoinedString());
    }

    public void TestRun(int N, int K, int[] x, int[] t)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x))); Console.WriteLine(string.Format("t:{0}", string.Join(" ", t))); sw.Start();
        var ret = maxHeight(N, K, x, t);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }


    // CUT end
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