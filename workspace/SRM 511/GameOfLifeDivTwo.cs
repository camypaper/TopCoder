using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GameOfLifeDivTwo
{
    public string theSimulation(string init, int T)
    {
        var s = init.ToCharArray();
        var n = s.Length;
        for (int _ = 0; _ < T; _++)
        {
            var next = new char[n];
            for (int i = 0; i < n; i++)
            {
                var add = s[i] - '0';
                var l = (i + n - 1) % n;
                var r = (i + 1) % n;
                add += s[l] - '0';
                add += s[r] - '0';
                if (add >= 2) next[i] = '1';
                else next[i] = '0';
            }
            s = next;
            //Debug.WriteLine(s.AsString());
        }
        return new string(s);
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
