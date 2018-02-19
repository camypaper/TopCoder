using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class PrinceXToastbook
{
    public double eat(int[] prerequisite)
    {
        var n = prerequisite.Length;
        Func<int, int, double,double> dfs = null;
        dfs = (cur, depth, div) =>
            {
                var ret = 1.0 / div;
                for (int i = 0; i < n; i++)
                    if (prerequisite[i] == cur) ret += dfs(i, depth + 1, div * (depth + 1));
                return ret;
            };
        var ans=0.0;
        for (int i = 0; i < n; i++)
            if (prerequisite[i] == -1) ans += dfs(i, 1, 1);
        return ans;
    }
    public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
}
