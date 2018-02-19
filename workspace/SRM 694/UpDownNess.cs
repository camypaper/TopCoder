using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class UpDownNess
{
    public int count(int N, int K)
    {
        const int MOD = (int)1e9 + 7;
        var dp = new int[K + 1];
        dp[0] = 1;
        for (int i = 0; i < N; i++)
        {
            var next = new int[K + 1];
            for (int j = 0; j <= K; j++)
            {
                for (int l = 0; l <= i; l++)
                {
                    var r = i - l;
                    if (j + l * r <= K)
                    {
                        next[j + l * r] += dp[j];
                        next[j + l * r] %= MOD;
                    }
                }
            }
            dp = next;
        }
        return dp[K];
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
