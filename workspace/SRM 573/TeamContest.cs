using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TeamContest
{
    public int worstRank(int[] a)
    {
        var val = a.Take(3).Max() + a.Take(3).Min();
        a = a.Skip(3).ToArray();
        Array.Sort(a);
        var cnt = 0;
        var n = a.Length;
        var used = new bool[n];
        for (int i = n - 1; i >= 0; i--)
        {
            if (used[i]) continue;
            var go = true;
            for (int j = 0; j < i && go; j++)
            {
                if (used[j]) continue;
                if (a[i] + a[j] > val)
                {
                    for (int k = j + 1; k < i && go; k++)
                    {
                        if (used[k]) continue;
                        used[i] = used[j] = used[k] = true;
                        cnt++;
                        go = false;
                        break;
                    }
                }
            }
            if (go) return cnt + 1;
        }
        return cnt + 1;
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
