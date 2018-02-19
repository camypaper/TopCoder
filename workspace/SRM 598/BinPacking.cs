using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BinPacking
{
    public int minBins(int[] a)
    {
        Array.Sort(a);
        var ans = int.MaxValue;
        var max = a.Count(x => x == 100) / 3;
        for (int i = 0; i <= max; i++)
        {
            ans = Math.Min(ans, i + solve(a.Skip(i * 3).ToArray()));
        }
        return ans;
    }
    public int solve(int[] a)
    {
        var ans = 0;
        var n = a.Length;
        var used = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (used[i]) continue;
            for (int j = n - 1; j >= 0; j--)
            {
                if (used[j]) continue;
                if (a[i] + a[j] <= 300)
                {
                    used[j] = true; break;
                }
            }
            used[i] = true;
            ans++;
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
