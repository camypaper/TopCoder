using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class BinPackingEasy
{
    public int minBins(int[] item)
    {
        var a = new List<int>();
        var count = 0;
        foreach (var x in item)
            if (x < 200) a.Add(x);
            else count++;
        a.Sort();
        var n = a.Count;
        var used = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (used[i]) continue;
            var u = a[i];
            var f = true;
            for (int j = n - 1; j > i && f; j--)
            {
                if (used[j]) continue;
                var v = a[j];
                if (u + v <= 300)
                {
                    used[i] = used[j] = true;
                    f = false;
                    break;
                }
            }
            count++;
        }
        return count;
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
