using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CatsOnTheCircle
{
    public double getProb(int N, int K, int p)
    {
        if (p == 1000000000 / 2) return 1.0 / (N - 1);
        if (p > 1000000000 / 2) { p = 1000000000 - p; K = N - K; }
        var q = 1.0 * p / 1000000000;
        Func<int, int, double> f = (L, R) =>
            {
                var r = q / (1 - q);
                var a = 1 / (1 - Math.Pow(r, L + R));
                var b = 1 - a;
                return a * Math.Pow(r, R) + b;
            };

        return f(N - K - 1, K - 1) * (1 - f(N - 2, 1)) + (1 - f(N - K - 1, K - 1)) * f(1, N - 2);
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
