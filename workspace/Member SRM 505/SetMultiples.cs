using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SetMultiples
{
    public long smallestSubset(long A, long B, long C, long D)
    {
        long ans = 0;
        var xs = new SortedSet<long>();
        var a = new long[] { A, B, C, D };
        for (int i = 1; i < 150000; i++)
        {
            xs.Add(i);
            foreach (var x in a)
            {
                xs.Add(x / i);
                xs.Add(x / i + 1);
            }
        }
        var xa = xs.ToList();
        for (int i = 0; i < xa.Count - 1; i++)
        {
            var l = xa[i];
            var r = xa[i + 1];
            if (l == 0) continue;
            if (D / l == 1 && (C - 1) / l == 0 && B / l == 0 && (A - 1) / l == 0)
                ans += r - l;
            if (D / l == (C - 1) / l && B / l == 1 && (A - 1) / l == 0)
                ans += r - l;
        }
        Debug.WriteLine(ans);
        return ans;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(long A, long B, long C, long D)
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
        ManualTest(9, 4261, 10000000000, 10000000000);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
