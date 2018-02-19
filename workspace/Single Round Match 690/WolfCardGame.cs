using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class WolfCardGame
{
    public int[] createAnswer(int N, int K)
    {
        if (K * (K + 1) / 2 < N)
        {
            return Enumerable.Range(1, K).ToArray();
        }
        if (N % 2 != 0)
        {
            var a = Enumerable.Range(1, K).ToArray();
            for (int i = 0; i < K; i++)
                a[i] *= 2;
            return a;
        }
        if (N % 3 != 0)
        {
            var a = Enumerable.Range(1, K).ToArray();
            for (int i = 0; i < K; i++)
                a[i] *= 3;
            return a;
        }
        if (N % 4 != 0)
        {
            var a = Enumerable.Range(1, K).ToArray();
            for (int i = 0; i < K; i++)
                a[i] *= 4;
            return a;
        }
        if (N % 5 != 0)
        {
            var a = Enumerable.Range(1, K).ToArray();
            for (int i = 0; i < K; i++)
                a[i] *= 5;
            return a;
        }
        {
            var a = new int[K];
            a[0] = 1;
            for (int i = 1; i < K; i++)
                a[i] = i * 7;

            return a;
        }

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
        for (int i = 1; i <= 100; i++)
            test.ManualTest(i, 15);
    }
}
// CUT end
