using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Moneymanager
{
    public int getbest(int[] a, int[] b, int X)
    {
        var n = a.Length;
        var k = n / 2;
        var A = new KeyValuePair<int, int>[n];
        for (int i = 0; i < n; i++)
            A[i] = new KeyValuePair<int, int>(a[i], b[i]);
        A = A.OrderBy(x => x.Value * 1.0 / x.Key).ToArray();
        var max = 0;
        var BSUM = b.Sum();
        for (int bsum = k; bsum <= k * 10; bsum++)
        {
            var dp = new int[k + 2, bsum + 12];
            for (int i = 0; i < k + 2; i++)
                for (int j = 0; j < bsum + 12; j++)
                    dp[i, j] = -1000000000;
            dp[0, 0] = 0;
            var tot = 0;
            foreach (var kv in A)
            {
                var next = new int[k + 2, bsum + 12];
                for (int i = 0; i < k + 2; i++)
                    for (int j = 0; j < bsum + 12; j++)
                        next[i, j] = -1000000000;
                var u = kv.Key;
                var v = kv.Value;
                for (int i = k; i >= 0; i--)
                    for (int j = bsum; j >= 0; j--)
                    {
                        if (dp[i, j] < 0) continue;

                        if (i < k)
                        {
                            var add = u * (BSUM - j);
                            next[i + 1, j + v] = Math.Max(next[i + 1, j + v], dp[i, j] + add);
                        }
                        {
                            var add = u * (BSUM - bsum - (tot - j));
                            next[i, j] = Math.Max(next[i, j], dp[i, j] + add);
                        }
                    }
                dp = next;
                tot += v;
            }
            max = Math.Max(max, dp[k, bsum] + (BSUM - bsum) * X);
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
    }
}
// CUT end
