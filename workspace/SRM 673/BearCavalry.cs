using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearCavalry
{
    public int countAssignments(int[] warriors, int[] horses)
    {
        var n = warriors.Length;
        var A = new int[n - 1];
        var X = warriors[0];
        for (int i = 0; i < n - 1; i++)
            A[i] = warriors[i + 1];
        long ret = 0;
        for (int i = 0; i < n; i++)
        {
            var c = new List<int>();
            for (int j = 0; j < n; j++)
                if (i != j) c.Add(horses[j]);
            ret += get(X * horses[i], A, c.ToArray());
            ret %= 1000000007;

        }
        return (int)ret;
    }
    public long get(int X, int[] A, int[] B)
    {
        Array.Sort(A);
        Array.Sort(B);
        long ret = 1;
        for (int i = A.Length - 1, used = 0; i >= 0; i--, used++)
        {
            var cnt = 0;
            var x = A[i];
            foreach (var y in B)
                if (x * y < X) cnt++;
            ret = (ret * Math.Max(0, cnt - used)) % 1000000007;
        }
        return ret;
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
    }
}
// CUT end
