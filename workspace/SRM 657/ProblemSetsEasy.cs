using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ProblemSetsEasy
{
    public int maxSets(int E, int EM, int M, int MH, int H)
    {
        var a = new int[] { E, EM, M, MH, H };
        for (int i = 200000; i >= 0; i--)
        {
            if (ok(i, E, EM, M, MH, H)) return i;
        }
        return 0;
    }
    public bool ok(int k, int E, int EM, int M, int MH, int H)
    {
        var easy = E;
        var med = M;
        var hard = H;
        if (easy < k)
        {
            var need = k - easy;
            if (need > EM) return false;
            EM -= need;
            med += EM;
        }
        else med += EM;
        if (med < k)
        {
            var need = k - med;
            if (need > MH) return false;
            MH -= need;
            hard += MH;
        }
        else hard += MH;
        if (hard < k) return false;
        return true;

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
