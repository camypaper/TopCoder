using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Privateparty
{
    public double getexp(int[] a)
    {
        var n = a.Length;
        var g = Enumerate(n, x => new bool[n]);
        for (int i = 0; i < n; i++)
        {
            g[i][i] = true;
            g[i][a[i]] = true;
        }
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    g[i][j] |= g[i][k] & g[k][j];


        var dp = Enumerate(n + 1, x => new double[n + 1]);
        var sum = new double[n + 1];
        dp[1][1] = 1; sum[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                for (int t = 1; t <= i; t++)
                {
                    if (t < j) dp[i][j] += (1 - dp[i - 1][t]);
                    else if (j < t) dp[i][j] += 1;
                }
                dp[i][j] /= (i - 1);
            }
            sum[i] = dp[i].Sum() / i;
        }
        var E = 0.0;
        for (int i = 0; i < n; i++)
            E += sum[g[i].Count(x => x)];
        return E;
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
