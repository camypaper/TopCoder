using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Desertification
{
    public int desertArea(string[] island, int T)
    {
        var n = island.Length;
        var m = island[0].Length;
        if (island.SelectMany(x => x).All(x => x == 'F'))
            return 0;
        var cnt = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (island[i][j] != 'F') continue;

                var min = long.MaxValue;
                for (int k = 0; k < n; k++)
                {
                    for (int l = 0; l < m; l++)
                    {
                        if (island[k][l] == 'F') continue;

                        min = Math.Min(min, Math.Abs(k - i) + Math.Abs(l - j));
                    }
                }
                if (min <= T) cnt++;
            }
        return island.SelectMany(x => x).Count(x => x == 'D') + cnt;
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
