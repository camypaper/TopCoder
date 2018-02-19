using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ParenthesesAndPermutation
{
    public string getSequence(int[] p)
    {
        var n = p.Length;
        var s = new char[n];
        var t = new char[n];
        for (int i = 0; i < n; i++)
            s[i] = t[i] = ')';
        var set = new SortedSet<int>();
        for (int i = 0; i < n; i++)
        {
            set.Add(p[i] * n + i);
            if (i % 2 == 0)
            {
                var min = set.Min;
                set.Remove(min);
                var ii = min / n;
                var jj = min / n;
                s[ii] = t[jj] = '(';
            }
        }
        var v = 0;
        foreach (var x in t)
        {
            if (x == '(') v++;
            else v--;
            if (v < 0) return "Impossible";
        }
        return new string(s);
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
