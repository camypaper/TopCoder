using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EllysPairing
{
    public int getMax(int M, int[] count, int[] first, int[] mult, int[] add)
    {
        var n = count.Sum();
        var a = new long[n];
        var ptr = 0;
        for (int i = 0; i < count.Length; i++)
        {
            a[ptr++] = first[i];
            for (int j = 1; j < count[i]; j++)
            {
                a[ptr] = (a[ptr - 1] * mult[i] + add[i]) % M;
                ptr++;
            }
        }
        var res = Algorithm.MajorityVotes(a);
        var cnt = a.Count(x => x == res);
        cnt -= n / 2;
        cnt = Math.Max(cnt, 0);
        if (n % 2 == 1 && cnt > 0) { n--; cnt--; }
        return n / 2 - cnt;
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
static public partial class Algorithm
{
    static public long MajorityVotes(long[] a)
    {
        long v = -1;
        var cnt = 0;
        foreach (var x in a)
        {
            if (cnt == 0) { v = x; cnt = 1; }
            else if (v == x) cnt++;
            else cnt--;
        }
        return v;
    }
}