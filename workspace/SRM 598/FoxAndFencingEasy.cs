using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndFencingEasy
{
    public string WhoCanWin(int mov1, int mov2, int d)
    {
        if (mov1 >= d)
            return "Ciel";
        if (mov1 > mov2 * 2)
            return "Ciel";
        if (mov2 > mov1 * 2)
            return "Liss";
        return "Draw";
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
