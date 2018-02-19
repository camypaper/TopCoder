using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class KingXNewCurrency
{
    public int howMany(int A, int B, int X)
    {
        if (A % X == 0 && B % X == 0)
            return -1;
        var set = new HashSet<int>();
        for (int i = 0; i <= A; i += X)
        {
            for (int j = 0; j <= B; j += X)
            {
                var u = A - i;
                var v = B - j;
                for (int k = 1; k <= Math.Max(u,v); k++)
                {
                    if (u % k == 0 && v % k == 0)
                        set.Add(k);
                }

            }
        }
        return set.Count;
    }
    public T[] Enumerate<T>(int n, Func<T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(); return a; }
    public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ")
    {
        return string.Join(s, e);
    }
}
