using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ExactTree
{
    public int getTree(int n, int m, int r)
    {
        var dp = Enumerate(n + 1, x => new int[m]);
        for (int i = 0; i <= n; i++)
            for (int j = 0; j < m; j++)
                dp[i][j] = 1000000000;
        dp[1][0] = 0;
        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j < i; j++)
            {
                var k = i - j;
                for (int s = 0; s < m; s++)
                {
                    if (dp[j][s] == 1000000000) continue;
                    for (int t = 0; t < m; t++)
                    {
                        if (dp[k][t] == 1000000000) continue;
                        var nc = dp[j][s] + dp[k][t] + j * (n - j);
                        dp[i][nc % m] = Math.Min(dp[i][nc % m], nc);
                    }
                }
            }
        }
        var ans = dp[n][r];
        if (ans >= 1000000000) return -1;
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
