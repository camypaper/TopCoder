using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearFair2
{
    public string isFair(int n, int b, int[] upTo, int[] quantity)
    {
        Array.Sort(upTo, quantity);
        var q = upTo.Length;
        for (int i = 0; i < q; i++)
        {
            for (int j = i + 1; j < q; j++)
            {
                if (upTo[i] == upTo[j])
                {
                    if (quantity[i] != quantity[j]) return "unfair";
                }
                else
                {
                    if (quantity[i] > quantity[j]) return "unfair";
                }
            }
        }
        var dp = new bool[20, 20, 20];
        dp[0, 0, 0] = true;
        for (int x = 1; x <= b; x++)
        {
            var next = new bool[20, 20, 20];
            for (int i = 0; i < 18; i++)
                for (int j = 0; j < 18; j++)
                    for (int k = 0; k < 18; k++)
                    {
                        if (!dp[i, j, k]) continue;
                        next[i, j, k] = true;
                        if (x % 3 == 0) next[i + 1, j, k] = true;
                        if (x % 3 == 1) next[i, j + 1, k] = true;
                        if (x % 3 == 2) next[i, j, k + 1] = true;
                    }
            for (int _ = 0; _ < q; _++)
            {
                if (upTo[_] != x) continue;
                var y = quantity[_];
                for (int i = 0; i < 18; i++)
                    for (int j = 0; j < 18; j++)
                        for (int k = 0; k < 18; k++)
                        {
                            if (i + j + k != y) next[i, j, k] = false;
                        }
            }
            dp = next;
        }
        if (dp[n / 3, n / 3, n / 3]) return "fair";
        else return "unfair";
    }

}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
