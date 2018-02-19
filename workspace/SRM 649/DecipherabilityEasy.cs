using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class DecipherabilityEasy
{
    public string check(string s, string t)
    {
        var a = s.Length;
        var b = t.Length;
        for (int k = 0; k < a; k++)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < a; i++)
                if (i != k) sb.Append(s[i]);
            var u = sb.ToString();
            System.Diagnostics.Debug.WriteLine(u);
            if (t == u)
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
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ")
    {
        return string.Join(s, e);
    }
}
