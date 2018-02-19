using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearFair
{
    public string isFair(int n, int b, int[] upTo, int[] quantity)
    {
        var q = upTo.Length;
        Array.Sort(upTo, quantity);
        for (int i = 0; i < q; i++)
            for (int j = i + 1; j < q; j++)
            {
                if (upTo[i] == upTo[j])
                {
                    if (quantity[i] != quantity[j]) return "unfair";
                }
                else
                {
                    if (quantity[i] > quantity[j]) return "unfair";
                }
            }
        var dp = new bool[35, 35];
        dp[0, 0] = true;
        for (int x = 1; x <= b; x++)
        {
            var next = new bool[35, 35];
            for (int i = 0; i < 30; i++)
                for (int j = 0; j < 30; j++)
                {
                    if (dp[i, j])
                    {
                        next[i, j] = true;
                        if (x % 2 == 0) next[i + 1, j] = true;
                        else next[i, j + 1] = true;
                    }
                }
            for (int _ = 0; _ < q; _++)
            {
                if (upTo[_] == x)
                {
                    for (int i = 0; i < 30; i++)
                        for (int j = 0; j < 30; j++)
                            if (i + j != quantity[_]) next[i, j] = false;
                }
                dp = next;
            }
        }
        if (dp[n / 2, n / 2]) return "fair";
        else return "unfair";
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
