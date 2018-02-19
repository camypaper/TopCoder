using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class KingXNewBaby
{
    public string isValid(string name)
    {
        var ans = false;
        ans |= name.Length != 8;
        var h = new int[26];
        foreach (var x in name)
            h[x - 'a']++;
        var vowel = "aiueo";
        var count = new int[5];
        for (int i = 0; i < 5; i++)
        {
            count[i] = h[vowel[i] - 'a'];
        }
        var t = 0;
        for (int i = 0; i < 5; i++)
            if (count[i] > 0) t++;
        ans |= t != 1;
        t = 0;
        for (int i = 0; i < 5; i++)
            if (count[i] == 0) continue;
            else if (count[i] != 2) ans |= true;
        if (ans) return "NO";
        return "YES";
    }
    static T[] Enumerate<T>(int n, Func<T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(); return a; }
    static T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
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
