using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ProductTriplet
{
    public long countTriplets(int minx, int maxx, int miny, int maxy, int minz, int maxz)
    {
        X = new long[] { minx, maxx };
        Y = new long[] { miny, maxy };
        Z = new long[] { minz, maxz };
        return solve();
    }
    long[] X, Y, Z;
    public long solve()
    {
        long ans = 0;
        for (long min = 1; min <= 100000; min++)
        {
            long cnt = 0;
            if (X[0] <= min && min <= X[1])
            {
                var L = (Z[0] + min - 1) / min;
                var R = Z[1] / min;

                L = Math.Max(L, Y[0]);
                L = Math.Max(L, min);
                R = Math.Min(R, Y[1]);
                if (L <= R) cnt += R - L + 1;
            }
            if (Y[0] <= min && min <= Y[1])
            {
                var L = (Z[0] + min - 1) / min;
                var R = Z[1] / min;

                L = Math.Max(L, X[0]);
                L = Math.Max(L, min);
                R = Math.Min(R, X[1]);
                if (L <= R) cnt += R - L + 1;
            }
            if (X[0] <= min && min <= X[1] && Y[0] <= min && min <= Y[1])
            {
                var v = min * min;
                if (Z[0] <= v && v <= Z[1]) cnt--;
            }
            //Debug.WriteLine("{0} {1}", min, cnt);
            ans += cnt;

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
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
