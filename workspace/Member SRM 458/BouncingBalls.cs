using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BouncingBalls
{
    public double expectedBounces(int[] xs, int T)
    {
        Array.Sort(xs);
        var n = xs.Length;
        long ans = 0;
        for (int i = 0; i < 1 << n; i++)
        {
            var to = new int[n];
            for (int j = 0; j < n; j++)
            {
                var mul = (i >> j & 1) == 1 ? 1 : -1;
                to[j] = mul * T + xs[j];
            }
            var cnt = 0;
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                {
                    if (j == k) continue;
                    if (xs[j] < xs[k] && to[j] >= to[k]) cnt++;
                    if (xs[j] > xs[k] && to[j] <= to[k]) cnt++;
                }
            //Debug.WriteLine("{0} {1}", i, cnt);
            ans += cnt / 2;
        }
        return 1.0 * ans / (1 << n);
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
        test.ManualTest(new int[] { 1, 2, 3, 4 }, 100000);
    }
}
// CUT end
