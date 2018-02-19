using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AndPicture
{
    public string isPossible(int n, string[] picture)
    {
        var a = Enumerate(1 << n, x => new int[1 << n]);
        for (int i = 0; i < 1 << n; i++)
            for (int j = 0; j < 1 << n; j++)
                a[i][j] = picture[i][j] - '0';
        if (solve(n, a)) return "Possible";
        else return "Impossible";
    }
    bool solve(int n, int[][] a)
    {
        var b = new List<int>();
        var c = new List<int>();
        var bb = new List<int>(); var cc = new List<int>();
        for (int i = 0; i < 1 << n; i++)
        {
            var p = 0; var q = 0;
            for (int j = 0; j < 1 << n; j++)
            {
                p += a[i][j];
                q += a[j][i];
            }
            if (p * 2 == (1 << n)) b.Add(i);
            if (q * 2 == (1 << n)) c.Add(i);
            if (p == 0) bb.Add(i);
            if (q == 0) cc.Add(i);
        }
        if (b.Count != n)
            return false;
        if (c.Count != n)
            return false;
        if (bb.Count != 1)
            return false;
        if (cc.Count != 1)
            return false;
        for (int i = 0; i < n; i++)
        {
            var p = b[i];
            for (int j = 0; j < n; j++)
            {
                var q = c[j];
                if (a[p][q] == 1) { var tmp = c[i]; c[i] = q; c[j] = tmp; }
            }
        }
        var R = new int[1 << n];
        var C = new int[1 << n];
        for (int k = 0; k < b.Count; k++)
        {
            var i = b[k];
            for (int j = 0; j < 1 << n; j++)
            {
                if (a[i][j] == 1) C[j] |= 1 << k;
            }
            i = c[k];
            for (int j = 0; j < 1 << n; j++)
                if (a[j][i] == 1) R[j] |= 1 << k;

        }
        if (R.Distinct().Count() != (1 << n))
            return false;
        if (C.Distinct().Count() != (1 << n))
            return false;
        for (int i = 0; i < 1 << n; i++)
            for (int j = 0; j < 1 << n; j++)
            {
                var v = ((R[i] & C[j]) > 0) ? 1 : 0;
                if (a[i][j] != v)
                    return false;
            }
        return true;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        //test.ManualTest(3, new string[] { "01010011", "01111110", "00011011", "01011001", "01111111", "00111111", "00111111", "00000000" });
    }
}
// CUT end
