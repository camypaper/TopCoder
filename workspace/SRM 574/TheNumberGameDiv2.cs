using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class TheNumberGameDiv2
{
    public int minimumMoves(int A, int B)
    {
        var a = A.ToString();
        var n = a.Length;
        var b = B.ToString();
        var len = b.Length;
        var ans = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            if (i + len > n) break;
            var f = true;
            for (int j = 0; j < len; j++)
            {
                if (a[i + j] == b[j]) continue;
                f = false;
                break; 
            }
            if (f)
            {
                var k = 0;
                if (i > 0) k += i + 2;
                k += n - (i + len);
                ans = Math.Min(ans, k);
            }
            f = true;
            for (int j = 0; j < len; j++)
            {
                if (a[i + j] == b[len - j - 1]) continue;
                f = false;
                break;
            }
            if (f)
            {
                var k = 0;
                k += i + 1;
                k += n - (i + len);
                ans = Math.Min(ans, k);
            }
        }
        if (ans != int.MaxValue)
            return ans;
        return -1;
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
