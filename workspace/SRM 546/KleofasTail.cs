using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KleofasTail
{
    public long countGoodSequences(long K, long A, long B)
    {
        return otaku(K, B) - otaku(K, A - 1);
    }
    public long otaku(long k, long a)
    {
        if (k == 0)
            return a;
        if (k > a) return 0;
        long ans = 0;
        if (k % 2 == 0) { k /= 2; ans--; }
        for (int i = 0; i < 60; i++)
        {
            if ((a >> i) == k)
            {
                ans += Math.Max(0, (a - (k << i)) + 1);
                break;
            }
            else if ((a >> i) > k)
                ans += 1L << i;
        }
        Debug.WriteLine(ans);
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
        test.ManualTest(32532534, 43534, 43643643643262);
    }
}
// CUT end
