using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class XorSequence
{
    public long getmax(int N, int sz, int A0, int A1, int P, int Q, int R)
    {
        var a = new long[sz];
        a[0] = A0; a[1] = A1;
        for (int i = 2; i < sz; i++)
            a[i] = (a[i - 1] * P + a[i - 1] * Q +R) % N;
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
