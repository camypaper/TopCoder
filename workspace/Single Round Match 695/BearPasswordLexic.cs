using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearPasswordLexic
{
    public string findPassword(int[] x)
    {

        var n = x.Length;
        var ans = "";
        var a = new List<int>();
        for (int p = n - 1; p >= 0; p--)
        {
            if (x[p] == 0) continue;
            for (int j = 0; j < x[p]; j++)
                a.Add(p + 1);
            var k = x[p];
            var l = p + 1;
            for (int i = 0; i < l; i++)
                for (int j = i; j < l; j++)
                    x[j - i] -= k;
            for (int i = 0; i < n; i++)
                if (x[i] < 0) return "";
        }
        for (int i = 0; i < n; i++)
            if (x[i] < 0) return "";
        if (a.Sum() != n) return "";
        a.Sort();
        var N = a.Count;
        var u = 0;
        var v = N - 1;
        for (int i = 0; i < N; i++)
        {
            if (i % 2 == 0) { ans += new string('a', a[v]); v--; }
            else { ans += new string('b', a[u]); u++; }
        }


        return ans;
    }



}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
