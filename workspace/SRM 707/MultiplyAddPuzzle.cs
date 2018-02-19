using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using N = System.Numerics.BigInteger;
public class MultiplyAddPuzzle
{
    public long minimalSteps(long s, long t, long a, long b)
    {
        if (s == t) return 0;
        return (long)f(s, t, a, b);
    }
    N a0(N s, N t, N a, N b)
    {
        if (b == 1) return -1;
        if (s == 0) return -1;
        N ans = 0;
        while (s < t)
        {
            s *= b; ans++;
        }
        if (s == t) return ans;
        else return -1;
    }
    N b0(N s, N t, N a, N b)
    {
        if (t == 0) return 1;
        else
        {
            if (a == 0) return -1;
            else
            {
                N ans = 0;
                for (int i = 0; i < 2; i++)
                {
                    if (s > t) { ans = 1; s = 0; }
                    if ((t - s) % a == 0)
                    {
                        ans += (t - s) / a;
                        return ans;
                    }
                    s = 0; ans++;
                }
                return -1;
            }
        }
    }
    N b1(N s, N t, N a, N b)
    {
        if (t > s && (t - s) % a == 0)
            return (t - s) / a;
        return -1;

    }
    N f(N s, N t, N a, N b)
    {
        if (b == 0) return b0(s, t, a, b);
        if (a == 0) return a0(s, t, a, b);
        if (b == 1) return b1(s, t, a, b);
        if (s > t) return -1;
        //a!=0,b>1
        N min = long.MaxValue;
        for (int k = 0; k < 70; k++)
        {
            var ss = s;
            for (int i = 0; i < k; i++)
                ss = N.Min(t + 1, ss * b);
            if (ss > t) continue;
            var d = t - ss;
            if (d % a != 0) continue;
            N v = k;
            d /= a;
            for (int i = 0; i < k && d > 0; i++)
            {
                var x = d % b;
                v += x;
                d /= b;
            }
            v += d;
            min = N.Min(min, v);
        }
        if (min == long.MaxValue) return -1;
        return min;
    }



    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(long s, long t, long a, long b)
    {
        return 0;
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
