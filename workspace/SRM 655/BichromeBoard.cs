using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class BichromeBoard
{
    public string ableToDraw(string[] board)
    {
        var n = board.Length;
        var m = board[0].Length;
        var map = new char[n, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                map[i, j] = board[i][j];
        var col="WB";
        for (int k = 0; k < 2; k++)
        {
            var f = true;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (map[i, j] == '?')
                        continue;
                    if (map[i, j] == col[(k + i + j) % 2])
                        continue;
                    f = false;
                    break;
                }
            if (f)
                return "Possible";
        }
        return "Impossible";
    }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ")
    {
        return string.Join(s, e);
    }
}
