using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class InfiniteString
{
    public string equal(string s, string t)
    {
        var n = s.Length;
        var m = t.Length;
        string sadd = s, tadd = t;
        for (int i = 0; i < m - 1; i++)
            s += sadd;
        for (int i = 0; i < n - 1; i++)
            t += tadd;
        for (int i = 0; i < n * m; i++)
            if (s[i] != t[i]) return "Not equal";
        return "Equal";
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
    public override void Test()
    {
        test.ManualTest("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "a");
        //base.Test();
    }
}
// Cut end
