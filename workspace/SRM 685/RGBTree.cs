using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RGBTree
{
    public string exist(string[] G)
    {
        var n = G.Length;
        var k = n / 3;
        var dp = Enumerate(1 << n, x => new bool[10, 10, 10]);
        dp[1][0, 0, 0] = true;
        for (int i = 0; i < 1 << n; i++)
        {
            for (int r = 0; r < 5; r++)
                for (int g = 0; g < 5; g++)
                    for (int b = 0; b < 5; b++)
                    {
                        if (!dp[i][r, g, b]) continue;

                        for (int j = 0; j < n; j++)
                        {
                            if ((i >> j & 1) == 1) continue;

                            for (int u = 0; u < n; u++)
                            {
                                if ((i >> u & 1) == 0) continue;
                                if (G[j][u] == 'R') dp[i | (1 << j)][r + 1, g, b] = true;
                                if (G[j][u] == 'G') dp[i | (1 << j)][r, g + 1, b] = true;
                                if (G[j][u] == 'B') dp[i | (1 << j)][r, g, b + 1] = true;

                            }
                        }
                    }

        }
        if (dp[(1 << n) - 1][k, k, k]) return "Exist";
        return "Does not exist";
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
