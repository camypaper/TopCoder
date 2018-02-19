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
        var g = Enumerate(n, x => new int[m]);

        var odd = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (s[i][j] != 'T') continue;
                var wall = 0;
                var exit = 0;
                var tonari = 0;
                for (int d = 0; d < 4; d++)
                {
                    var res = check(n, m, s, i + dx[d], j + dy[d]);
                    if (res == -1) wall++;
                    if (res == 0) exit++;
                    if (res == 1) tonari++;
                }
                if (wall == 4) continue;
                else if (wall + exit == 4)
                    odd++;
                else if (exit > 0 && wall + exit + tonari == 4)
                {
                    odd++;
                }
                else if (wall + tonari == 4)
                {
                    if (k == 1)
                        odd++;
                }
                else
                {
                    if (exit > 0) odd++;
                    else if (k % 2 == 1) odd++;
                }
            }
        if (odd % 2 == 0) return "Bob";


        return "Alice";
    }
    int[] dx = { 1, 0, -1, 0 };
    int[] dy = { 0, 1, 0, -1 };
    public int check(int n, int m, string[] s, int x, int y)
    {
        if (x < 0 || x >= n || y < 0 || y >= m) return -1;
        if (s[x][y] == '#') return -1;
        if (s[x][y] == 'E') return 0;
        for (int i = 0; i < 4; i++)
        {
            var nx = x + dx[i];
            var ny = y + dy[i];
            if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
            if (s[nx][ny] == 'E') return 1;
        }
        return 2;
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
        var s = new string[]
        {
            "E.T.E.T.E.T.E"
        };
        test.ManualTest(s, 1);
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
