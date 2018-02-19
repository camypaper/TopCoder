using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class Revmatching
{
    public int smallest(string[] A)
    {
        var n = A.Length;
        var min = int.MaxValue;
        for (int U = 1; U < 1 << n; U++)
        {
            var sz = 0;
            var v = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (((U >> i) & 1) == 0)
                    continue;
                for (int j = 0; j < n; j++)
                    v[j] += A[i][j] - '0';
                sz++;
            }
            Array.Sort(v);
            var val = 0;
            for (int i = 0; i <= n - sz; i++)
                val += v[i];
            min = Math.Min(min, val);
        }
        return min;
    }
}
