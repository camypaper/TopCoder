using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndClassroom
{
    public string ableTo(int n, int m)
    {
        var used = new bool[m];
        var p = 0;
        for (int i = 0; i < m; i++)
        {
            if (used[p])
                return "Impossible";
            used[p] = true;
            p = (p + n) % m;
        }
        return "Possible";
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
