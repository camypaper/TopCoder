using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Nisoku
{
    public double theMax(double[] cards)
    {
        var n = cards.Length;
        Array.Sort(cards);
        var ans = -1.0;
        for (int i = 0; i <= n; i++)
        {
            var add = new List<double>();
            if (i % 2 == 1) add.Add(0);
            for (int j = 0; j < i; j++)
                add.Add(cards[j]);
            var val = 1.0;
            for (int l = 0, r = add.Count - 1; l < r; l++, r--)
                val *= add[l] + add[r];
            for (int j = i; j < n; j++)
                val *= cards[j];
            ans = Math.Max(ans, val);
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
