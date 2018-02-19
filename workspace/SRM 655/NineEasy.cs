using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NineEasy
{
    public int count(int N, int[] digits)
    {
        var dp = new int[9, 9, 9, 9, 9];
        dp[0, 0, 0, 0, 0] = 1;
        foreach (var x in digits)
        {
            var next = new int[9, 9, 9, 9, 9];
            for (int v = 0; v < 10; v++)
                for (int a = 0; a < 9; a++)
                    for (int b = 0; b < 9; b++)
                        for (int c = 0; c < 9; c++)
                            for (int d = 0; d < 9; d++)
                                for (int e = 0; e < 9; e++)
                                {
                                    var A = new int[5] { a, b, c, d, e };
                                    for (int i = 0; i < 5; i++)
                                        if ((x >> i & 1) == 1) A[i] = (A[i] + v) % 9;
                                    next[A[0], A[1], A[2], A[3], A[4]] += dp[a, b, c, d, e];
                                    next[A[0], A[1], A[2], A[3], A[4]] %= 1000000007;

                                }
            dp = next;
        }
        return dp[0, 0, 0, 0, 0];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int N, int[] d)
    {
        return 0;
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
