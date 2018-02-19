using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TomekPhone
{
    public int minKeystrokes(int[] a, int[] keySizes)
    {
        Array.Sort(a);
        Array.Reverse(a);
        var b = new List<int>();
        foreach (var x in keySizes)
        {
            for (int i = 1; i <= x; i++)
                b.Add(i);
        }
        b.Sort();
        if (a.Length > b.Count) return -1;
        int ans = 0;
        for (int i = 0; i < a.Length; i++)
            ans += b[i] * a[i];
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
