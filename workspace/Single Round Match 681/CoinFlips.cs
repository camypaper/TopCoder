using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CoinFlips
{
    public double getExpectation(int[] vals, int prob)
    {
        var n = vals.Length;
        var p = 1.0 * prob / 1000000000;
        var liv = new double[n];
        for (int i = 0; i < n; i++)
            liv[i] = 1;
        var ans = 0.0;
        for (int i = 0; i < n; i++)
        {
            var next = new double[n];
            var left = new double[n];
            var right = new double[n];
            var P = 1.0;
            for (int j = 0; j < n; j++)
            {
                var q = P * liv[i] * p;//erabareru kakuritu
                next[j] = (1 - q);
                P *= (1 - q);
            }
            next[0] += P;
            for (int j = 0; j < n; j++)
                if (j > 0)
                {
                    left[j] = liv[j - 1] * vals[j - 1] + (1 - liv[j - 1]) * left[j - 1];
                }
            for (int j = n - 1; j >= 0; j--)
                if (j < n - 1)
                {
                    right[j] = liv[j + 1] * vals[j + 1] + (1 - liv[j + 1]) * right[j + 1];
                }
            for (int j = 0; j < n; j++)
                ans += (1 - next[j]) * left[j] * right[j];
            liv = next;
        }
        return ans;
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
    }
}
// CUT end
