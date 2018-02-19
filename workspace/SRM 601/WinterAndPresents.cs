using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class WinterAndPresents
{
    public long getNumber(int[] apple, int[] orange)
    {
        var n = apple.Length;
        var a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = apple[i] + orange[i];
        var to = a.Min();
        long ans = 0;
        for (int i = 1; i <= to; i++)
        {
            var max = 0;
            var min = 0;
            for (int j = 0; j < n; j++)
            {
                max += Math.Min(i, apple[j]);
                min += Math.Max(0, i - orange[j]);
            }
            ans += max - min + 1;

        }

        return ans;
    }
}
// CUT end
