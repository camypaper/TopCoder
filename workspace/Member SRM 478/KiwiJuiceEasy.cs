using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KiwiJuiceEasy
{
    public int[] thePouring(int[] capacities, int[] bottles, int[] fromId, int[] toId)
    {
        var n = fromId.Length;
        for (int i = 0; i < n; i++)
        {
            var f = fromId[i];
            var t = toId[i];
            var go = bottles[f];
            var cap = capacities[t] - bottles[t];
            var min = Math.Min(go, cap);
            bottles[f] -= min;
            bottles[t]+= min;

        }
        return bottles;
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
