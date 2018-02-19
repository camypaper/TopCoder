using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DiceRotation
{
    public int theCount(int goalx, int goaly)
    {
        if (goalx <= 50 && goaly <= 50)
        {
            var dp = new int[goalx + 100, goaly + 100];
            dp[0, 0] = 1;
            for (int _ = 0; _ < 2; _++)
            {
                var next = new int[goalx + 100, goaly + 100];
                for (int i = 0; i <= goalx; i++)
                    for (int j = 0; j <= goaly; j++)
                    {
                        if (i == 2 && j == 0)
                        {

                        }
                        for (int v = i; v <= goalx; v++)
                            next[v, j + 2] += dp[i, j];
                        for (int v = j; v <= goaly; v++)
                            next[i + 2, v] += dp[i, j];
                    }
                dp = next;
            }
            return dp[goalx, goaly];
        }
        if (goalx == 4 || goaly == 4)
        {
            return goalx + goaly - 1;
        }
        else return 2;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(4, 26);
    }
}
// CUT end
