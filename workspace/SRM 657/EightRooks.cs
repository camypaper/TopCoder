using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EightRooks
{
    public string isCorrect(string[] board)
    {
        const int n = 8;
        for (int i = 0; i < n; i++)
        {
            if (board[i].Count(x => x == 'R') != 1) return "Incorrect";
        }
        for (int j = 0; j < n; j++)
        {
            var cnt = 0;
            for (int i = 0; i < n; i++)
                if (board[i][j] == 'R') cnt++;
            if (cnt != 1) return "Incorrect";
        }

        return "Correct";
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
