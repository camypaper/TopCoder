using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class YetAnotherIncredibleMachine
{
    public int countWays(int[] platformMount, int[] platformLength, int[] balls)
    {
        var count = new int[200050];
        const int offset = 100025;
        foreach (var x in balls)
            count[x + offset]++;
        for (int i = 1; i < 200050; i++)
            count[i] += count[i - 1];
        var n = platformMount.Length;
        const long mod = (long)1e9 + 9;
        long ans = 1;
        for (int i = 0; i < n; i++)
        {
            var pos = platformMount[i];
            var len = platformLength[i];
            var k = 0;
            for (int j = offset+pos; j <= pos+offset+len; j++)
            {
                if (count[j] - count[j - len - 1] == 0) k++;
            }
            ans = ans * k % mod;

        }
        return (int)ans;
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
