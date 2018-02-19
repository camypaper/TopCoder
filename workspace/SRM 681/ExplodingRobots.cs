using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ExplodingRobots
{
    public string canExplode(int x1, int y1, int x2, int y2, string instructions)
    {
        var dx = x2 - x1;
        var dy = y2 - y1;
        var dp = new bool[500, 500];
        dp[250 + dx, 250 + dy] = true;
        foreach (var x in instructions)
        {
            var XOK = x == 'L' || x == 'R';
            var YOK = x == 'U' || x == 'D';
            var next = new bool[500, 500];
            for (int i = 50; i < 450; i++)
                for (int j = 50; j < 450; j++)
                {
                    for (int d = -1; d <= 1; d++)
                    {
                        dp[i + d, j] |= dp[i, j] & XOK;
                        dp[i, j + d] |= dp[i, j] & YOK;
                    }
                }
        }
        if (dp[250, 250])
            return "Explosion";
        return  "Safe";
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
