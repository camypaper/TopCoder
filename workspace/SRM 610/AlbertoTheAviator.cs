using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AlbertoTheAviator
{
    public int MaximumFlights(int F, int[] duration, int[] refuel)
    {
        var n = duration.Length;
        var A = new List<KeyValuePair<int, int>>();
        var B = new List<KeyValuePair<int, int>>();
        var C = new List<KeyValuePair<int, int>>();
        for (int i = 0; i < n; i++)
        {
            var need = duration[i];
            var gain = refuel[i] - need;
            if (gain > 0) A.Add(new KeyValuePair<int, int>(need, gain));
            else if (gain == 0) B.Add(new KeyValuePair<int, int>(need, gain));
            else C.Add(new KeyValuePair<int, int>(need, gain));
        }
        A.Sort((l, r) => l.Key.CompareTo(r.Key));
        B.Sort((l, r) => l.Key.CompareTo(r.Key));
        C.Sort((l, r) => (r.Key + r.Value).CompareTo(l.Key + l.Value));
        var ans = 0;
        foreach (var x in A)
            if (x.Key <= F) { ans++; F += x.Value; }
        foreach (var x in B)
            if (x.Key <= F) ans++;

        return ans + f(F, C.ToArray());
    }
    public int f(int F, KeyValuePair<int, int>[] A)
    {
        Debug.WriteLine(F);
        var dp = new int[F + 1];
        for (int i = 0; i <= F; i++)
            dp[i] = -1000000000;
        dp[F] = 0;
        foreach (var x in A)
        {
            for (int i = x.Key; i <= F; i++)
                if (i + x.Value >= 0) dp[i + x.Value] = Math.Max(dp[i + x.Value], dp[i] + 1);
        }
        return dp.Max();
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
