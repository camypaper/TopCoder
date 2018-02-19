using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CombinationLockDiv1
{
    public int minimumMoves(string[] P, string[] Q)
    {
        var s = string.Concat(P);
        var t = string.Concat(Q);
        var n = s.Length;
        var ans = 1000000000;
        var a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = (t[i] - s[i] + 100) % 10;
        var b = new int[n];
        b[0] = a[0];
        for (int i = 1; i < n; i++)
            b[i] = (a[i] - a[i - 1] + 100) % 10;
        Array.Sort(b);
        for (int i = 0; i <= n; i++)
        {
            var u = 0;
            var v = 0;
            for (int j = 0; j < n; j++)
            {
                if (j < i) u += b[j];
                else v += 10 - b[j];
            }
            ans = Math.Min(ans, u + v - Math.Min(u, v));
        }
        return ans;
    }

}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
