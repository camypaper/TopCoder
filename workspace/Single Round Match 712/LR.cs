using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class LR
{
    public string construct(long[] s, long[] t)
    {
        s = new long[] { 1, 0 };
        t = new long[] { 0, 0 };
        var k = chk(s.Sum(), t.Sum());
        if (k == -1)
            return "No solution";
        var n = s.Length;
        var a = new List<long>() { 1 };
        for (int i = 0; i < k; i++)
        {
            for (int j = a.Count - 1; j > 0; j--)
                a[j] += a[j - 1];
            a.Add(1);
        }
        for (int i = -k; i <= k; i++)
        {
            var d = (i + 100 * n) % n;

            var str = "";
            var cnt = Math.Abs(i);
            if (i < 0) str = new string('L', cnt) + new string('R', k - cnt);
            else str = new string('R', cnt) + new string('L', k - cnt);
            if (f(s, t, str))
                return str;
        }


        return "No solution";
    }
    public int chk(long x, long y)
    {
        if (x == 0) return (y == 0) ? 0 : -1;
        if (y % x != 0) return -1;
        y /= x;
        var k = 0;
        while (y > 0 && y % 2 == 0) { y /= 2; k++; }
        return k;
    }

    public bool f(long[] a, long[] b, string s)
    {

        var c = new long[a.Length];
        for (int i = 0; i < a.Length; i++)
            c[i] = a[i];
        unchecked
        {
            foreach (var x in s)
            {
                var na = new long[a.Length];
                if (x == 'L')
                {
                    for (int i = 0; i < a.Length; i++)
                        na[i] = c[i] + c[(i + a.Length - 1) % a.Length];
                }
                else for (int i = 0; i < a.Length; i++)
                        na[i] = c[i] + c[(i + 1) % a.Length];

                c = na;
            }
        }
        var ok = true;
        for (int i = 0; i < a.Length; i++)
            ok &= c[i] == b[i];
        Debug.WriteLine(c.AsJoinedString());
        return ok;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(long[] s, long[] t)
    {



        var ans = "";
        if (!f(s, t, ans))
        {
            Debug.WriteLine(ans);
        }
        return "";
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
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);
        Test(Example6);

    }
}
// CUT end
