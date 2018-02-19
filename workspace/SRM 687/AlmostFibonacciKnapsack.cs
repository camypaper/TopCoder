using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AlmostFibonacciKnapsack
{
    public int[] getIndices(long x)
    {
        var A = new long[92];
        A[1] = 2;
        A[2] = 3;
        var B = new long[92];
        B[1] = 1;
        B[2] = 2;
        for (int i = 3; i < 92; i++)
        {
            A[i] = A[i - 1] + A[i - 2] - 1;
            B[i] = B[i - 1] + B[i - 2];
        }
        var ans = new List<int>();
        for (int i = 92 - 1; i > 0; i--)
        {
            if (x > A[i] + 1 || x == A[i]) { ans.Add(i); x -= A[i]; }
        }
        Debug.WriteLine(x);
        if (x != 0) return new int[] { -1 };
        return ans.ToArray();
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
