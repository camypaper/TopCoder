using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GerrymanderEasy
{
    public double getmax(int[] A, int[] B, int K)
    {
        var max = 0.0;
        var n = A.Length;
        for (int i = 0; i < n; i++)
        {
            var sum = 0;
            var val = 0;
            for (int j = i; j < n; j++)
            {
                sum += A[j];
                val += B[j];
                if (j - i + 1 >= K) max = Math.Max(max, 1.0 * val / sum);
            }
        }
            return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ") { return string.Join(s, e);}
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand=new Random(0);
    public Tester()
    {
    }
}
// CUT end
