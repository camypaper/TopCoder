using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class NarrowPassage
{
    public int minDist(int L, int[] a, int[] b)
    {
        Array.Sort(a, b);
        Debug.WriteLine(a.AsJoinedString());
        Debug.WriteLine(b.AsJoinedString());
        var n = a.Length;
        var ans = Math.Min(n * 2 * L - a.Sum() - b.Sum(), a.Sum() + b.Sum());

        for (int l = -1; l <= n; l++)
        {
            for (int r = l + 1; r <= n; r++)
            {
                var c = b.ToArray();
                if (l >= 0) Array.Sort(c, 0, l + 1);
                if (r < n) Array.Sort(c, r, n - r);
                var ok = true;
                for (int i = 0; i < n - 1; i++)
                    ok &= c[i] < c[i + 1];
                if (!ok) continue;
                var val = 0;
                for (int i = 0; i < n; i++)
                    if (i <= l) val += a[i] + b[i];
                    else if (i < r) val += Math.Abs(b[i] - a[i]);
                    else val += 2 * L - a[i] - b[i];
                ans = Math.Min(ans, val);
            }
        }
        Debug.WriteLine(ans);
        for (int l = 0; l <= n; l++)
            for (int t = 0; t <= n; t++)
            {
                var val = 0;
                for (int i = 0; i < n; i++)
                    if (i < l) val += a[i];
                    else val += L - a[i];
                var X = t < n ? b[t] : L;
                for (int i = 0; i < n; i++)
                {
                    if (i < l)
                    {
                        if (b[i] < X) val += b[i];
                        else val += 2 * L - b[i];
                    }
                    else
                    {
                        if (b[i] < X) val += L + b[i];
                        else val += L - b[i];
                    }
                }
                if (val < ans)
                    ans = val;
            }

        return ans;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        var a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        var b = new int[] { 2, 3, 4, 5, 1, 8, 9 };
        test.ManualTest(1000000, a, b);
    }
}
// CUT end
