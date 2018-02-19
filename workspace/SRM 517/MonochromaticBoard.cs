using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MonochromaticBoard
{
    public int theMin(string[] board)
    {
        var n = board.Length;
        var m = board[0].Length;
        if (n * m == board.SelectMany(x => x).Count(x => x == 'B'))
            return Math.Min(n, m);
        var R = board.Count(x => x.All(y => y == 'B'));
        var C = 0;
        for (int i = 0; i < m; i++)
        {
            var cnt = 0;
            for (int j = 0; j < n; j++)
                if (board[j][i] == 'B') cnt++;
            if (cnt == n) C++;
        }
        return R + C;
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
