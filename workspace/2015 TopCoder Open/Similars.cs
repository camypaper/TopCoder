using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class Similars
{
    public int maxsim(int L, int R)
    {
        var h = new int[1 << 10];
        for (int i = L; i <= R; i++)
        {
            var s = i.ToString();
            var f = 0;
            foreach (var x in s)
                f |= (1 << (x - '0'));
            for (int k = 0; k < 1 << 10; k++)
                if ((k & f) >= k) h[k]++;
        }
        var max = 0;
        for (int i = 0; i < 1 << 10; i++)
        {
            if (h[i] <= 1)
                continue;
            var cnt = 0;
            for (int j = 0; j < 10; j++)
                if (((i >> j) % 2) == 1) cnt++;
            max = Math.Max(cnt, max);
        }
        return max;
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
