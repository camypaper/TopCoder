using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ProblemSets
{
    public long maxSets(long E, long EM, long M, long MH, long H)
    {
        long l = 0, r = (long)2e18;
        for (int _ = 0; _ < 100; _++)
        {
            var m = (l + r) / 2;
            if (ok(m, E, EM, M, MH, H)) l = m;
            else r = m;
        }
        return l;
    }
    bool ok(long k, long E, long EM, long M, long MH, long H)
    {
        var easy = E;
        if (easy < k)
        {
            var need = k - easy;
            if (EM < need) return false;
            EM -= need;
        }
        var med = EM + M;
        if (med < k)
        {
            var need = k - med;
            if (MH < need) return false;
            MH -= need;
        }
        var hard = MH + H;
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
