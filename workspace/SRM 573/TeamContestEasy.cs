using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TeamContestEasy
{
    public int worstRank(int[] a)
    {
        var val = a[0] + a[1] + a[2] - a.Take(3).Min();
        a = a.Skip(3).ToArray();
        Array.Sort(a); Array.Reverse(a);

        var n = a.Length;
        var cnt = 0;
        var used = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (used[i]) continue;
            var ok = false;
            for (int j = n - 1; j > i; j--)
            {
                if (used[j]) continue;
                if (a[i] + a[j] > val)
                {
                    ok = true;
                    for (int k = n - 1; k >= 0; k--)
                    {
                        if (used[k]) continue;
                        if (i == k || j == k) continue;
                        used[i] = used[j] = used[k] = true;
                        break;
                    }
                    break;
                }
            }
            if (ok) { cnt++; continue; }
            for (int j = n - 1; j >= 0; j--)
            {
                if (used[j]) continue;
                for (int k = j - 1; k > i; k--)
                {
                    if (used[k]) continue;
                    used[i] = used[j] = used[k] = true; break;
                }
                break;
            }
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
