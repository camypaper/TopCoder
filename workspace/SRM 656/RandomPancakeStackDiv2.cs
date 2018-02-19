using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RandomPancakeStackDiv2
{
    public double expectedDeliciousness(int[] d)
    {
        var n = d.Length;
        var dp = new double[1 << n];
        dp[0] = 1;
        var E = 0.0;
        for (int i = 0; i < 1 << n; i++)
        {
            var p = dp[i];
            var sum = 0;
            var min = n;
            var small = 0;
            var cnt = n;
            for (int j = n - 1; j >= 0; j--)
                if ((i >> j & 1) == 1) { sum += d[j]; min = j; cnt--; }
            for (int j = 0; j < min; j++)
                if ((i >> j & 1) == 0) { dp[i | 1 << j] += dp[i] / cnt; small++; }
            if (cnt > 0)
                E += sum * dp[i] * (cnt - small) / cnt;
            else E += sum * dp[i];
        }
        return E;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int[] d)
    {
        return 0.0;
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
