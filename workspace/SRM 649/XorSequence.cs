using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class XorSequence
{
    public long getmax(int N, int sz, int A0, int A1, int P, int Q, int R)
    {
        var a = new long[sz];
        a[0] = A0;
        a[1] = A1;
        for (int i = 2; i < sz; i++)
        {
            a[i] = a[i - 2];
            a[i] *= P;
            a[i] += a[i - 1] * Q;
            a[i] += R;
            a[i] %= N;
        }
        return f(N - 1, a);
    }
    long[][] dp = Enumerate(30, x => new long[2]);
    void dfs(int k, List<long> a)
    {
        if (a.Count == 0) return;
        //Debug.WriteLine(k);
        //Debug.WriteLine(a.AsJoinedString());
        var b = new List<long>();
        var c = new List<long>();
        foreach (var x in a)
        {
            if ((x >> k & 1) == 0)
            {
                b.Add(x);
                dp[k][1] += c.Count;
            }
            else
            {
                c.Add(x);
                dp[k][0] += b.Count;
            }
        }

        if (k > 0)
        {
            dfs(k - 1, b); dfs(k - 1, c);
        }

    }
    long f(int n, long[] a)
    {
        dfs(29, a.ToList());
        for (int i = 30 - 1; i >= 0; i--)
            Debug.WriteLine("{0}: {1}", i, dp[i].AsJoinedString());
        long max = 0;
        for (int len = 30; len >= 0; len--)
        {
            var v = 0L;
            var x = 0;
            for (int i = 29, j = 0; i >= 0; i--, j++)
            {

                if (j < len)
                {
                    var y = n >> i & 1;
                    v += dp[i][y];
                    if (y == 1)
                        x |= 1 << i;
                }
                else if (j == len)
                {
                    var y = n >> i & 1;
                    v += dp[i][y ^ 1];
                    if (y == 0) x |= 1 << i;
                }
                else
                {
                    if (dp[i][0] < dp[i][1])
                    {
                        x |= 1 << i;
                        v += dp[i][1];
                    }
                    else v += dp[i][0];
                }
            }
            if (x <= n)
            {
                Debug.WriteLine(x);
                max = Math.Max(max, v);
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(4, 89167, 3, 2, 3, 2, 1);
    }
}
// CUT end
