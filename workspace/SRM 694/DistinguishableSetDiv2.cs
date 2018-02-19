using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DistinguishableSetDiv2
{
    public int count(string[] s)
    {
        var n = s.Length;
        var m = s[0].Length;
        var ans = 1 << m;
        var dp = new bool[1 << m];
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                var v = 0;
                for (int k = 0; k < m; k++)
                {
                    if (s[i][k] == s[j][k]) v |= 1 << k;
                }
                dp[v] = true;
            }
        for (int i = dp.Length - 1; i >= 0; i--)
        {
            if (!dp[i]) continue;
            ans--;
            for (int j = 0; j < m; j++)
                if ((i >> j & 1) == 1) dp[i ^ (1 << j)] = true;

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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
