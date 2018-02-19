using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class Decipherability
{
    public string check(string s, int K)
    {
        var n = s.Length;
        if (n == K)
            return "Certain";
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                if (s[i] == s[j])
                {
                    if (j - i <= K)
                        return "Uncertain";
                }
            }
        return "Certain";
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
