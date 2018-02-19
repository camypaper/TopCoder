using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndGo2
{
    public int maxKill(string[] board)
    {
        var n=board.Length;
        var map = new char[n][];
        for (int i = 0; i < n; i++)
            map[i] = board[i].ToCharArray();
        
        return 0;
    }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ")
    {
        return string.Join(s, e);
    }
}
