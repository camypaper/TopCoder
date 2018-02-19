using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CanidsSeesaw
{
    public int[] construct(int[] a, int[] b, int k)
    {
        var n = a.Length;
        for (int i = 1; i < n; i++)
            a[i] += a[i - 1];
        var p = Enumerate(n, x => x);
        Array.Sort(p, (l, r) => b[p[l]].CompareTo(b[p[r]]));
        if (f(a, b, p) == k) return p;
        Debug.WriteLine(string.Join(" ", p));
        for (int i = n - 1; i >= 0; i--)
        {
            var last = -1;
            for (int j = i - 1; j >= 0; j--)
            {
                if (b[p[j]] < b[p[i]])
                    Swap(ref p[j], ref p[i]);
                var score = f(a, b, p);
                Debug.WriteLine(score);
                if (score < k) { last = j; }
                if (score == k) return p;
                if (score > k)
                {
                    Swap(ref p[j], ref p[i]);
                    if (last != -1)
                        Swap(ref p[last], ref p[i]);
                    break;
                }
            }
        }

        return new int[] { };
    }
    int f(int[] a, int[] b, int[] p)
    {
        var ret = 0;
        var n = a.Length;
        int x = 0;
        for (int i = 0; i < n; i++)
        {
            x += b[p[i]];
            if (x > a[i]) ret++;
        }
        return ret;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int[] Naive_Test(int[] wolf, int[] fox, int k)
    {
        return new int[] { };
    }

    // CUT end
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

    }
}
// CUT end
