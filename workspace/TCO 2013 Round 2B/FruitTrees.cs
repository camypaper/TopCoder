using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int32;
public class FruitTrees
{
    public int maxDist(int apple, int kiwi, int grape)
    {
        var a = new int[] { apple, kiwi, grape };
        Array.Sort(a);
        var g = new int[3];
        for (int i = 0, p = 0; i < 3; i++)
            for (int j = i + 1; j < 3; j++)
                g[p++] = MathEx.GCD(a[i], a[j]);
        var max = 0;
        for (int i = 0; i <= a[2]; i++)
        {
            for (int j = 0; j <= a[2]; j++)
            {

                var p = i % g[0];
                p = Math.Min(p, g[0] - p);
                var q = j % g[1];
                q = Math.Min(q, g[1] - q);
                var r = ((i - j) % g[2] + g[2]) % g[2];
                r = Math.Min(r, g[2] - r);
                max = Math.Max(max, new int[] { p, q, r }.Min());
            }
        }


        return max;
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
#region gcd,lcm
static public partial class MathEx
{

    static public Number GCD(Number x, Number y)
    {
        byte i = 0;
        while (x != 0 && y != 0)
        {
            if (i == 0)
                y %= x;
            else x %= y;
            i ^= 1;
        }
        return x == 0 ? y : x;
    }
    static public Number LCM(Number x, Number y)
    {
        return x * y / GCD(x, y);
    }

}
#endregion