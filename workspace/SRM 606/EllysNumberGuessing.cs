using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EllysNumberGuessing
{
    public int getNumber(int[] guesses, int[] answers)
    {
        var ok = new bool[2];
        for (int k = 0; k < 2; k++)
        {
            var v = guesses[0];
            if (k == 0)
                v -= answers[0];
            else v += answers[0];
            if (v <= 0 || v > 1000000000) continue;
            var go = true;
            for (int i = 0; i < guesses.Length; i++)
            {
                if (Math.Abs(v - guesses[i]) != answers[i]) go = false;
            }
            if (go) ok[k] = true;

        }
        if (ok[0] && ok[1]) return -1;
        else if (!ok[0] && !ok[1]) return -2;
        else if (ok[0]) return guesses[0] - answers[0];
        else return guesses[0] + answers[0];
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
