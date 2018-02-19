using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheEmpireStrikesBack
{
    public int find(int AX, int BX, int CX, int AY, int BY, int CY, int N, int M)
    {
        var P = new KeyValuePair<long, long>[N];
        long ax = AX, bx = BX, cx = CX, ay = AY, by = BY, cy = CY;
        for (int i = 0; i < N; i++)
        {
            P[i] = new KeyValuePair<long, long>(ax, ay);
            ax = ax * bx + cx;
            ax %= 1000000007;
            ay = ay * by + cy;
            ay %= 1000000007;
        }
        Array.Sort(P, (l, r) =>
         {
             var cmp = l.Key.CompareTo(r.Key);
             if (cmp != 0) return cmp;
             return l.Value.CompareTo(r.Value);
         });
        var ps = new List<KeyValuePair<long, long>>();
        for (int i = 0; i < N; i++)
        {
            while (ps.Count != 0)
            {
                var lp = ps[ps.Count - 1];
                if (lp.Value <= P[i].Value) ps.RemoveAt(ps.Count - 1);
                else break;
            }
            ps.Add(P[i]);
        }
        return f(ps.Count, M, ps.ToArray());
    }
    int f(int n, int k, KeyValuePair<long, long>[] P)
    {
        Debug.WriteLine(P.AsJoinedString());
        var l = 0; var r = 1000000009;
        for (int _ = 0; _ < 60; _++)
        {
            var m = (l + r) / 2;

            if (g(n, P, m) <= k) r = m;
            else l = m;
        }
        return r;
    }
    int g(int n, KeyValuePair<long, long>[] P, int t)
    {
        var cnt = 0;
        var next = 0;
        while (next < n)
        {
            var py = P[next].Value;
            while (next < n)
            {
                if (P[next].Value + t < py) { next--; break; }
                else { next++; }
            }
            if (next < n)
            {
                var px = P[next].Key;
                while (next < n)
                {
                    if (P[next].Key > px + t) break;
                    else next++;
                }
            }
            cnt++;
        }

        return cnt;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
