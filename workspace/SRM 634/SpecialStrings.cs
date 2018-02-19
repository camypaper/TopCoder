using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class SpecialStrings
{
    public string findNext(string current)
    {
        var str = current.ToCharArray();
        var len = str.Length;
        for (int i = len - 1; i >= 0; i--)
        {
            if (str[i] == '1') continue;
            str[i] = '1';
            if (check(str))
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (str[j] == '0') continue;
                    str[j] = '0';
                    if (!check(str)) str[j] = '1';
                }
                return str.AsString();
            }

        }
        return "";
    }
    public bool check(char[] str)
    {
        var len = str.Length;
        for (int i = 1; i < len; i++)
        {
            var u = 0;
            var v = i;
            var f = true;
            var min = Math.Min(i, len - i);
            for (int j = 0; j < min; j++)
                if (str[u + j] > str[v + j]) return false;
                else if (str[u + j] < str[v + j]) { f = false; break; }
            if (i >= len - i && f) return false;

        }
        return true;
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
