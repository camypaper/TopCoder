using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CheckerExpansion
{
    public string[] resultAfter(long t, long x0, long y0, int w, int h)
    {
        sim(32);
        return new string[] { };
    }

    private void sim(int t)
    {
        var board = Enumerate(t + 5, x => new char[t * 2 + 5]);
        const char emp = '.';
        for (int i = 0; i < t + 5; i++)
            for (int j = 0; j < t * 2 + 5; j++)
                board[i][j] = emp;
        board[2][2] = '0';
        for (int k = 1; k < t; k++)
        {
            var tar = k % 2 == 1 ? '0' : '1';
            var mine = k % 2 == 1 ? '1' : '0';
            for (int i = 2; i < t + 5; i++)
                for (int j = 2; j < t * 2 + 5; j++)
                {
                    if (board[i][j - 2] == tar && board[i - 1][j - 1] == emp)
                        board[i][j] = mine;
                    if (board[i][j - 2] == emp && board[i - 1][j - 1] == tar)
                        board[i][j] = mine;
                }

        }
        for (int i = t + 4; i >= 2; i--)
            Debug.WriteLine(board[i].Skip(2).AsJoinedString());

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
