using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearSortsDiv2
{
    public double getProbability(int[] seq)
    {
        var n = seq.Length;
        var pos = new int[n];
        for (int i = 0; i < n; i++)
            pos[seq[i] - 1] = i;
        Debug.WriteLine(pos.AsJoinedString());
        sort(0, n, pos);
        return ans;
    }
    double ans;
    readonly double P = Math.Log(0.5);
    public List<int> sort(int l, int r, int[] seq)
    {
        if (l + 1 >= r) return new List<int>() { seq[l] };
        var mid = (l + r) / 2;
        var L = sort(l, mid, seq);
        var R = sort(mid, r, seq);
        var p = 0;
        var q = 0;
        while (p < L.Count && q < R.Count)
        {
            if (L[p] < R[q])
            {
                ans += P;
                p++;
            }
            else
            {
                ans += P;
                q++;
            }
        }
        var ret = new List<int>();
        foreach (var x in L) ret.Add(x);
        foreach (var y in R) ret.Add(y);
        ret.Sort();
        return ret;
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
