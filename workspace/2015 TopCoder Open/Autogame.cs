using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class Autogame
{
    public int wayscnt(int[] a, int k)
    {

        var n = a.Length;
        for (int i = 0; i < n; i++)
            a[i]--;
        var next = new int[n, 32];
        for (int i = 0; i < n; i++)
            next[i, 0] = a[i];
        for (int i = 1; i < 32; i++)
            for (int j = 0; j < n; j++)
                next[j, i] = next[next[j, i - 1], i - 1];
        var total = new int[n];
        for (int i = 0; i < n; i++)
        {
            var to = i;
            var it = k;
            for (int j = 0; j < 32; j++)
            {
                if (it % 2 == 1)
                    to = next[to, j];
                it /= 2;
            }
            total[to]++;
        }
        long ans = 1;
        for (int i = 0; i < n; i++)
            ans = (ans * (total[i] + 1)) % 1000000007;
        return (int)ans;
    }
}
