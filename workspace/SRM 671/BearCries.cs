using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearCries
{
    public int count(string s)
    {
        var n = s.Length;
        var dp = new long[n + 5, n + 5];
        dp[0, 0] = 1;
        const long MOD = 1000000007;
        foreach (var x in s)
        {
            var next = new long[n + 5, n + 5];
            for (int i = 0; i <= n; i++)
                for (int j = 0; j <= n; j++)
                {
                    if (x == ';')
                    {
                        next[i + 1, j] = (next[i + 1, j] + dp[i, j]) % MOD;
                        if (j > 0)
                            next[i, j - 1] = (next[i, j - 1] + dp[i, j] * j) % MOD;
                    }
                    else
                    {
                        if (i > 0)
                            next[i - 1, j + 1] = (next[i - 1, j + 1] + dp[i, j] * i) % MOD;
                        next[i, j] = (next[i, j] + dp[i, j] * j) % MOD;
                    }
                }
            dp = next;
        }
        return (int)dp[0, 0];
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
