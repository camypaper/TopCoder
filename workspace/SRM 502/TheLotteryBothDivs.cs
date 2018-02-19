using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheLotteryBothDivs
{
    public double find(string[] s)
    {

        s = s.Distinct().OrderBy(x => x.Length).ToArray();
        var n = s.Length;
        var pass = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (pass[i]) continue;
            for (int j = i + 1; j < n; j++)
            {
                if (pass[j]) continue;
                var min = Math.Min(s[i].Length, s[j].Length);
                var S = s[i].Reverse().Take(min).AsString();
                var T = s[j].Reverse().Take(min).AsString();
                if (S == T)
                    pass[j] = true;
            }
        }
        var ans = 0.0;
        for (int i = 0; i < n; i++)
        {
            if (pass[i]) continue;
            var len = s[i].Length;
            ans += Math.Pow(0.1, len);
        }
        return ans;
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
