using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class XorOrderDiv1
{
    public int get(int m, int n, int a0, int b)
    {
        var X = 1 << m;
        var A = new long[n];
        for (long i = 0; i < n; i++)
            A[i] = (a0 + i * b) % X;
        Array.Sort(A);
        return f(A, m);
    }
    int f(long[] A, int m)
    {
        var n = A.Length;
        var ans = 0L;
        const long MOD = (long)1e9 + 7;
        const long INV2 = 500000004;
        foreach (var x in A)
        {
            var b = new List<long>();
            for (int i = 0; i < m; i++)
            {
                var y = ((x >> i) ^ 1) << i;
                var z = y;
                for (int j = 0; j < i; j++)
                    z |= 1L << j;
                z++;
                var p = Array.BinarySearch(A, y);
                var q = Array.BinarySearch(A, z);
                if (p < 0) p = ~p;
                if (q < 0) q = ~q;
                b.Add(q - p);
            }
            long e = 0;
            long f = 0;
            foreach (var k in b)
            {
                var ne = e + INV2 * k;
                ne %= MOD;
                var nf = f + k * e + INV2 * ((k * k) % MOD);
                nf %= MOD;
                e = ne;
                f = nf;
            }
            f *= 1 << m;
            f %= MOD;
            ans ^= f;
            //Debug.WriteLine(x); Debug.WriteLine(b.AsJoinedString());
        }

        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int m, int n, int a0, int b)
    {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
