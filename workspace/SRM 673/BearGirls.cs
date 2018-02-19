using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearGirls
{
    //see editorial;_;
    public double expectedValue(int[] A, int[] T, int cost)
    {
        var n = T.Sum();
        var a = new List<int>();
        for (int i = 0; i < A.Length; i++)
            for (int j = 0; j < T[i]; j++)
                a.Add(A[i] + j);
        a.Sort();
        var dp1 = new double[n + 1];
        var dp2 = new double[n + 2];
        for (int i = 0; i < n; i++)
            dp1[i + 1] = dp2[i + 1] = a[i];
        for (int k = n - 1; k >= 1; k--)
        {
            var next = 0.0;
            for (int i = 1; i <= k + 1; i++)
                next += dp1[i] / (k + 1);
            for (int i = 1; i <= k; i++)
            {
                var p = i * 1.0 / (k + 1);
                dp2[i] = p * dp2[i + 1] + (1 - p) * dp2[i];
                dp1[i] = Math.Max(next - cost, dp2[i]);
            }
        }
        return dp1[1] - cost;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
