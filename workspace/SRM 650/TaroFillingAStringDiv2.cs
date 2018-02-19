using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TaroFillingAStringDiv2
{
    public int getNumber(string S)
    {
        var n = S.Length;
        var dp = new int[3];
        dp[0] = dp[1] = 10000000;
        for (int i = 0; i < n; i++)
        {
            var next = new int[3];
            next[0] = next[1] = next[2] = 100000000;
            for (int k = 0; k < 2; k++)
                if (S[i] == 'A' + k || S[i] == '?')
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var add = j == k ? 1 : 0;
                        next[k] = Math.Min(next[k], dp[j] + add);
                    }
                }
            dp = next;
        }

        return dp.Min();
    }

}
