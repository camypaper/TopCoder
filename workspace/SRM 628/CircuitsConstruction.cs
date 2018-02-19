using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CircuitsConstruction
{
    public int maximizeResistance(string circuit, int[] conductors)
    {
        var ptr = 0;
        var n = dfs(circuit, ref ptr);
        return conductors.OrderByDescending(x => x).Take(n).Sum();
    }
    public int dfs(string s, ref int ptr)
    {
        switch (s[ptr++])
        {
            case 'A':
                {
                    var u = dfs(s, ref ptr);
                    var v = dfs(s, ref ptr);
                    return u + v;
                }
            case 'B':
                {
                    var u = dfs(s, ref ptr);
                    var v = dfs(s, ref ptr);
                    return Math.Max(u, v);
                }
            case 'X': return 1;
            default: throw new Exception();
        }
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string circuit, int[] conductors)
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
