using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Quacking
{
    public int quack(string s)
    {
        var automaton = "quack";
        var l = 1; var r = 2550;
        for (int _ = 0; _ < 30; _++)
        {
            var m = (l + r) / 2;
            var state = new int[6];
            state[0] = m;
            var ok = true;
            foreach (var x in s)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (automaton[i] != x) continue;
                    if (state[i] <= 0)
                    {
                        ok = false; break;
                    }
                    state[i]--;
                    state[(i + 1) % 5]++;
                }

            }
            ok &= state[0] == m;
            if (ok) r = m;
            else l = m;
        }
        if (r > s.Length) r = -1;
        return r;
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
