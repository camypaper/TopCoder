using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SuffixArrayDiv1
{
    public int minimalCharacters(int[] SA)
    {
        var ret = 1;
        var n = SA.Length;
        var ISA = new int[n + 1];
        for (int i = 0; i < n; i++)
            ISA[SA[i]] = i;
        ISA[n] = -1;
        for (int i = 1; i < n; i++)
        {
            var p = SA[i - 1];
            var q = p + 1;
            var r = ISA[q];

            var a = SA[i];
            var b = a + 1;
            var c = ISA[b];
            if (r < c) continue;
            else ret++;
        }
        return ret;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] SA)
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
