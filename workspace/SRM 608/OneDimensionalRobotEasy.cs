using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class OneDimensionalRobotEasy
{
    public int finalPosition(string commands, int A, int B)
    {
        var pos = 0;
        foreach(var x in commands)
        {
            if (x == 'R') pos = Math.Min(pos + 1, B);
            else pos = Math.Max(pos - 1, -A);
        }
        return pos;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ") { return string.Join(s, e);}
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand=new Random(0);
    public Tester()
    {
    }
}
// CUT end
