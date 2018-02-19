using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class LCMGCD
{
    public string isPossible(int[] a, int t)
    {
        var n = a.Length;
        if (n == 1)
        {
            if (a[0] == t)
                return "Possible";
            else return "Impossible";
        }
        var A = new int[n];
        var B = new int[n];
        var x = 0;
        var y = 0;
        for (int i = 0; i < n; i++)
        {
            while (a[i] % 2 == 0)
            {
                A[i]++;
                a[i] /= 2;
            }
            while (a[i] % 3 == 0)
            {
                B[i]++;
                a[i] /= 3;
            }
        }
        while (t % 2 == 0) { x++; t /= 2; }
        while (t % 3 == 0) { y++; t /= 3; }
        if (f(A, B, x, y)) return "Possible";
        return "Impossible";
    }
    public bool f(int[] a, int[] b, int x, int y)
    {
        Array.Sort(a, b);
        Debug.WriteLine(a.AsJoinedString());
        Debug.WriteLine(b.AsJoinedString());
        Debug.WriteLine(x);
        Debug.WriteLine(y);
        var n = a.Length;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == x && b[i] == y)
            {
                var A = new int[2] { 1000, -1000 };
                var B = new int[2] { 1000, -1000 };
                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue;
                    A[0] = Math.Min(A[0], a[j]);
                    A[1] = Math.Max(A[1], a[j]);
                    B[0] = Math.Min(B[0], b[j]);
                    B[1] = Math.Max(B[1], b[j]);
                }
                if (A[0] <= x && B[0] <= y) return true;
                if (A[1] >= x && B[1] >= y) return true;
            }
        }
        var X = new List<int>();
        var Y = new List<int>();
        var rem = new List<KeyValuePair<int, int>>();
        for (int i = 0; i < n; i++)
        {
            if (a[i] == x) X.Add(b[i]);
            else if (b[i] == y) Y.Add(a[i]);
            else rem.Add(new KeyValuePair<int, int>(a[i], b[i]));
        }
        if (X.Count == 0 || Y.Count == 0) return false;


        {
            if (X.Max() >= y && Y.Max() >= x)
            {
                if (rem.Count == 0) return true;
                var aa = rem.Max(t => t.Key);
                var bb = rem.Max(t => t.Value);
                var cc = rem.Min(t => t.Key);
                var dd = rem.Min(t => t.Value);
                if (aa >= x && bb >= y) return true;
                if (cc <= x && dd <= y) return true;
            }
            if (X.Min() <= y && Y.Min() <= x)
            {
                if (rem.Count == 0) return true;
                var aa = rem.Max(t => t.Key);
                var bb = rem.Max(t => t.Value);
                var cc = rem.Min(t => t.Key);
                var dd = rem.Min(t => t.Value);
                if (aa >= x && bb >= y) return true;
                if (cc <= x && dd <= y) return true;
            }

            var u = 0;
            var v = 0;
            foreach (var kv in rem)
            {
                if (kv.Key < x && kv.Value > y) u++;
                if (kv.Key > x && kv.Value < y) v++;
            }
            if (u > 0 && v > 0) return true;
            if (u > 0 && Y.Max() >= x) return true;
            if (u > 0 && X.Min() <= y) return true;
            if (v > 0 && Y.Min() <= x) return true;
            if (v > 0 && X.Max() >= y) return true;
        }
        return false;
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
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        var a = new int[] { 36, 24, 48, 162 };
        test.ManualTest(a, 36);
    }
}
// CUT end
