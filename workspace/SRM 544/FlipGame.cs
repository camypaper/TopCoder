using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FlipGame
{
    public int minOperations(string[] board)
    {
        var n = board.Length;
        var m = board[0].Length;
        var map = Enumerate(n, x => new int[m]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                map[i][j] = board[i][j] - '0';
        for (int ans = 0; ; ans++)
        {
            foreach (var x in map)
                Debug.WriteLine(x.AsJoinedString(""));
            Debug.WriteLine("");
            var r = new int[n];
            for (int i = 0; i < n; i++)
            {
                var j = i == 0 ? 0 : r[i - 1];
                var to = j;
                for (; j < m; j++)
                {
                    if (map[i][j] == 1)
                        to = Math.Max(to, j + 1);
                }
                r[i] = to;
            }
            if (r[n - 1] == 0)
                return ans;
            for (int i = 0; i < n; i++)
            {
                for (int j = r[i] - 1; j >= 0; j--)
                {
                    map[i][j] ^= 1;
                }
            }

        }
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
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
