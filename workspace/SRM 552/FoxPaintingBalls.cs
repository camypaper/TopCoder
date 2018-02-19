using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class FoxPaintingBalls
{
    public long theMax(long R, long G, long B, int N)
    {
        var size = Math.BigMul(N, N + 1) / 2;
        var k = size / 3;
        var mod = size % 3;
        long l = 0; var r = 10 + (R + G + B) / size;
        int num = 0;
        while (l < r&&num<=100)
        {
            var m = (l + r) >> 1;
            long[] a = { R, G, B };
            for (int i = 0; i < 3; i++)
                a[i] -= m * k;
            long rem = 0;
            var ok = true;
            for (int i = 0; i < 3; i++)
                if (a[i] >= 0) rem += a[i];
                else ok = false;
            if (mod != 0 && rem / mod < m)
                ok = false;
            if (ok)
                l = m;
            else r = m;
            num++;
        }
        return l;
    }
}
