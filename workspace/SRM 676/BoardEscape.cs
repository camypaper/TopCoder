using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BoardEscape
{
    public string findWinner(string[] s, int k)
    {


        var n = s.Length;
        var m = s[0].Length;

        k = Math.Min(k, (n * m) * 2 + k % 2);

        var dp = new int[n, m, k + 1];
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        for (int u = 1; u <= k; u++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (s[i][j] == 'E')
                    {
                        dp[i, j, u] = 0;
                        continue;
                    }
                    var set = new HashSet<int>();
                    for (int d = 0; d < 4; d++)
                    {
                        var nx = i + dx[d];
                        var ny = j + dy[d];
                        if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
                        if (s[nx][ny] == '#') continue;
                        set.Add(dp[nx, ny, u - 1]);
                    }
                    for (int v = 0; v < 4; v++)
                        if (set.Contains(v)) continue;
                        else { dp[i, j, u] = v; break; }
                }
        var ans = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (s[i][j] == 'T')
                {
                    ans ^= dp[i, j, k];
                }
            }
        if (ans == 0)
            return "Bob";
        return "Alice";
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
    public override void Test()
    {
        //var S = new string[] { "....................", "....................", "....................", "....................", "......E.E...........", ".......T............", "......E.E...........", "....................", "....................", "....................", "....................", "......T.............", ".....TET............", "....................", "....................", "....................", "....................", "....................", "....................", "...................." };
        var otaku = new string[] { "E.T.." };
        test.ManualTest(otaku, 1000003);
        //test.ManualTest(S, 61);
        base.Test();
    }
}
// CUT end
