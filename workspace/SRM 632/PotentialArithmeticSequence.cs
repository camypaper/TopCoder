using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PotentialArithmeticSequence
{
    public int numberOfSubsequences(int[] d)
    {
        var n = d.Length;
        for (int i = 0; i < n; i++)
            d[i] = Math.Min(d[i], 7);
        var ok = new bool[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int x = 1; x <= 128; x++)
            {
                for (int j = 0; i + j < n; j++)
                {
                    var v = x + j;
                    var k = 0;
                    while (v % 2 == 0) { v /= 2; k++; }
                    if (k != d[i + j]) break;
                    ok[i, i + j] = true;
                }
                //Debug.WriteLine(ans);
            }
        }
        var ans = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (ok[i, j]) ans++;
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] d)
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
