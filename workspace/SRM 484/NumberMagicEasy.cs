using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NumberMagicEasy
{
    public int theNumber(string answer)
    {
        var a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        var b = new int[] { 1, 2, 3, 4, 9, 10, 11, 12 };
        var c = new int[] { 1, 2, 5, 6, 9, 10, 13, 14 };
        var d = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
        var AA = new int[][] { a, b, c, d };
        var S = Enumerable.Range(1, 16).ToArray();
        for (int i = 0; i < 4; i++)
        {
            if (answer[i] == 'Y') S = S.Intersect(AA[i]).ToArray();
            else S = S.Except(AA[i]).ToArray();
        }
        return S[0];
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
