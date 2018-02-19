using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class MountainRanges
{
    public int countPeaks(int[] heights)
    {
        var n = heights.Length;
        var a = new int[n + 2];
        for (int i = 0; i < n; i++)
            a[i + 1] = heights[i];
        var count = 0;
        for (int i = 1; i <= n; i++)
            if (a[i - 1] < a[i] && a[i] > a[i + 1]) count++;
        return count;
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
