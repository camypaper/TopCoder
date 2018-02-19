using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MagicalStringDiv1
{
    public int getLongest(string S)
    {
        var max = 0;
        var n = S.Length;
        for (int l = 0; l < n; l++)
            for (int r = l + 1; r < n; r++)
            {
                if (S[l] != '>') continue;
                if (S[r] != '<') continue;
                var a = S.Substring(0, l + 1);
                var b = S.Substring(r);
                var min = Math.Min(a.Count(x => x == '>'), b.Count(x => x == '<'));
                max = Math.Max(max, min * 2);
            }
        return max;
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
