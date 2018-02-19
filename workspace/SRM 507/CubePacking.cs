using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CubePacking
{
    public int getMinimumVolume(int Ns, int Nb, int L)
    {
        return (int)solve(Ns, Nb, L);
    }
    long solve(long a, long b, int l)
    {
        var lv = l * l * l;
        var min = long.MaxValue;
        for (int i = l; i <= 4000; i++)
        {
            for (int j = i; j <= 60000; j++)
            {
                long v = i;
                v *= j; v *= j;
                if (v >= 20000000000) break;
                var p = i / l;
                var q = j / l;
                var h = (b + p * q - 1) / (p * q);
                h *= l;
                var aa = a;

                aa = Math.Max(0, aa - (i * j * h - b * lv));
                var dh = (aa + i * j - 1) / (i * j);
                min = Math.Min(min, i * j * (h + dh));
            }
        }
        Debug.WriteLine(min);
        return min;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int Ns, int Nb, int L)
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
    public override void Run()
    {
        ManualTest(669515080, 64, 9);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
