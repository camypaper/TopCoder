using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BoardEscapeDiv2
{
    public string findWinner(string[] s, int k)
    {
        var r = s.Length;
        var c = s[0].Length;
        var grundy = Enumerate(r, x => Enumerate(c, y => new int[k + 1]));
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        for (int u = 1; u <= k; u++)
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                {
                    if (s[i][j] == 'E') continue;
                    var set = new HashSet<int>();
                    for (int d = 0; d < 4; d++)
                    {
                        var nx = i + dx[d];
                        var ny = j + dy[d];
                        if (nx < 0 || nx >= r || ny < 0 || ny >= c) continue;
                        if (s[nx][ny] == '#') continue;
                        set.Add(grundy[nx][ny][u - 1]);

                    }
                    for (int v = 0; v <= 100; v++)
                        if (!set.Contains(v))
                        {
                            grundy[i][j][u] = v; break;
                        }
                }
        var win = 0;
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
            {
                if (s[i][j] != 'T') continue;

                IOEx.Dump(grundy[i][j], "otaku");
                win ^= grundy[i][j][k];
            }

        if (win == 0) return "Bob";
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
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
