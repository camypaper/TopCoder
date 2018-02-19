using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DevuAndGame
{
    public string canWin(int[] nextLevel)
    {
        var n = nextLevel.Length;
        var vis = new bool[n];
        var p = 0;
        while(true)
        {
            if (vis[p]) break;
            vis[p] = true;
            p = nextLevel[p];
            if (p == -1)
                return "Win";

        }
        return "Lose";
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
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
