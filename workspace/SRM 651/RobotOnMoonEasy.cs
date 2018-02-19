using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RobotOnMoonEasy
{
    public string isSafeCommand(string[] board, string S)
    {
        var n = board.Length;
        var m = board[0].Length;
        var px = -1; var py = -1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (board[i][j] == 'S') { px = i; py = j; }
        foreach (var x in S)
        {
            var nx = px;
            var ny = py;
            switch (x)
            {
                case 'U': nx--; break;
                case 'D': nx++; break;
                case 'R': ny++; break;
                case 'L': ny--; break;
            }
            if (nx < 0 || nx >= n || ny < 0 || ny >= m) return "Dead";
            if (board[nx][ny] == '#') continue;
            px = nx; py = ny;
        }
        return "Alive";
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
