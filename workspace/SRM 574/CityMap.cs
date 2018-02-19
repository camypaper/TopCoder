using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class CityMap
{
    public string getLegend(string[] cityMap, int[] POIs)
    {
        var h = new int[26];
        foreach (var str in cityMap)
            foreach (var x in str)
                if (x == '.') continue;
                else h[x - 'A']++;
        var n=POIs.Length;
        var ans = new char[n];
        for (int i = 0; i < 26; i++)
            for (int j = 0; j < n; j++)
                if (POIs[j] == h[i]) ans[j] = (char)(i + 'A');
        return ans.AsString();
    }
    public T[] Enumerate<T>(int n, Func<T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(); return a; }
    public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
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
