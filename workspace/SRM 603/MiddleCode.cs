using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MiddleCode
{
    public string encode(string str)
    {
        var a = str.ToList();
        var l = new List<char>();
        while (a.Any())
        {
            if (a.Count % 2 == 1)
            {
                var m = a.Count / 2;
                l.Add(a[m]);
                a.RemoveAt(m);
            }
            else
            {
                var m = a.Count / 2;
                if (a[m - 1] < a[m]) m--;

                l.Add(a[m]);
                a.RemoveAt(m);


            }
        }
        return l.AsString();
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
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
