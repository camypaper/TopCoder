using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class CartInSupermarket
{
    public int calcmin(int[] a, int b)
    {
        long c = b;
        Array.Sort(a);
        Array.Reverse(a);
        var l = 1;
        var r = 1000000000;
        var n = a.Length;
        var k = 0;
        long rem = 0;
        while (l <= r && k < 100)
        {
            var m = (r + l) >> 1;
            long count = 0;
            for (int i = 0; i < n; i++)
            {
                var v = a[i];
                long u = 1;
                while (v > m && count <= c)
                {
                    v = v / 2 + v % 2;
                    count += u;
                    u <<= 1;
                }
            }
            if (count <= c)
            {
                r = m;
                rem = c - count;
            }
            else l = m;
            k++;
        }
        var ans = 0;
        for (int i = 0; i < n; i++)
        {
            var v = a[i];
            var t = 1;
            var u = 0;
            while (v > r)
            {
                v = v / 2 + v % 2;
                u++;
                t <<= 1;
            }
            if (rem > 0)
            {
                v = v / 2 + v % 2;
                u++;
                rem--;
            }
            ans = Math.Max(ans, u + v);
        }
        return ans;
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
