using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PackingBallsDiv1
{
    public int minPacks(int K, int A, int B, int C, int D)
    {
        var a = new long[K];
        a[0] = A;
        for (int i = 1; i < K; i++)
            a[i] = ((a[i - 1] * B + C) % D) + 1;
        Array.Sort(a);
        var mod = new int[K];
        long cnt = 0;
        for (int i = 0; i < K; i++)
        {
            mod[(int)(a[i] % K)]++;
            cnt += a[i] / K;
        }
        for (int i = 1; i < K; i++)
            mod[i] += mod[i - 1];
        var min = long.MaxValue;
        for (int i = 0; i < K; i++)
        {
            min = Math.Min(min, cnt + i + mod[K - 1] - mod[i]);
        }
        return (int)min;
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
