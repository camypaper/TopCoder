using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class CutTheNumbers
{
    public int maximumSum(string[] board)
    {
        var n = board.Length;
        var m = board[0].Length;
        var max = n * m;
        var dp = new long[1 << max];
        for (int i = 1; i < 1 << max; i++)
            dp[i] = -1;
        for (int i = 0; i < 1 << max; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    for (int l = j, flag = 0, val = 0; l < n; l++)
                    {
                        val = val * 10 + (board[l][k] - '0');
                        var p = l * m + k;
                        flag |= 1 << p;
                        if ((i >> p) % 2 == 1) break;
                        dp[i | flag] = Math.Max(dp[i | flag], dp[i] + val);
                    }
                    for (int l = k, flag = 0, val = 0; l < m; l++)
                    {
                        val = val * 10 + (board[j][l] - '0');
                        var p = j * m + l;
                        flag |= 1 << p;
                        if ((i >> p) % 2 == 1) break;
                        dp[i | flag] = Math.Max(dp[i | flag], dp[i] + val);
                    }

                }
            }
        }

        return (int)dp[(1 << max)-1];
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
