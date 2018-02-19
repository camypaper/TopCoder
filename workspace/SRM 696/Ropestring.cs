using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Ropestring
{
    public string makerope(string s)
    {
        var A = Enumerate(2, x => new List<int>());
        var n = s.Length;
        s += '$';
        var l = 0;
        for (int i = 0; i <= n; i++)
        {
            if (s[i] == '-') l++;
            else
            {
                if (l > 0)
                    A[l % 2].Add(l);
                l = 0;
            }
        }
        A[0].Sort(); A[0].Reverse();
        A[1].Sort(); A[1].Reverse();
        var t = new char[n];
        for (int i = 0; i < n; i++)
            t[i] = '.';
        var p = 0;
        foreach (var x in A[0].Concat(A[1]))
        {
            for (int i = 0; i < x; i++)
                t[p++] = '-';
            p++;
        }

        return new string(t);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public string Naive_Test(string s)
    {
        return "";
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
