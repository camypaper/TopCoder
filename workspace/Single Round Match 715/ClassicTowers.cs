using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ClassicTowers
{
    public string findTowers(long k, int[] A)
    {
        for (int i = 0; i < 3; i++)
        {
            var b = A.ToArray();
            b[i]--;
            if (b[i] >= 0)
            {
                var s = solve(k, b[0], b[1], b[2], i);
                if (!s.Contains("*")) return s;
            }
        }
        return "";
    }
    string solve(long k, int a, int b, int c, int p)
    {
        Debug.WriteLine("{0} {1} {2} {3}", k, a, b, c, p);
        if (a < 0 || b < 0 || c < 0) return "*";
        if (a == 0 && b == 0 && c == 0)
        {
            if (k == 0) return "";
            else return "*";
        }
        var A = new int[] { a - 1, b - 1, c - 1 };
        for (int i = 0; i < 3; i++)
        {
            if (A[i] < 0) A[i] = -1000000000;
            if (i == p) A[i] = 0;
            else A[i] += p;
        }
        for (int i = 0; i < 3; i++)
        {
            if (A[i] > 60) continue;
            if (A[i] <= 0) continue;
            if ((k >> A[i] & 1) == 1)
            {
                var nk = k - (1L << A[i]);
                var na = new int[] { a, b, c };
                na[i]--;
                for (int np = 0; np < 3; np++)
                    if (np == p) continue;
                    else if (np == i) continue;
                    else return solve(nk, na[0], na[1], na[2], i);
            }
        }
        {
            var na = new int[] { a, b, c };
            na[p]--;
            return solve(k, na[0], na[1], na[2], p);
        }
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(long k, int[] count)
    {
        return "";
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
