using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;
public class BearDarts
{
    public long count(int[] a)
    {
        var n = a.Length;
        var L = new HashMap<long, long>();
        long ans = 0;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                long u = a[i]; long v = a[j];
                var gcd = MathEx.GCD(u, v);
                u /= gcd; v /= gcd;
                L[u * 2000000000L + v]++;
            }
        for (int j = n - 1; j >= 0; j--)
        {
            for (int i = 0; i < j; i++)
            {
                long u = a[i], v = a[j];
                var gcd = MathEx.GCD(u, v);
                u /= gcd; v /= gcd;
                L[u * 2000000000L + v]--;
            }
            for (int k = j + 1; k < n; k++)
            {
                long u = a[j], v = a[k];
                var gcd = MathEx.GCD(u, v);
                u /= gcd;v /= gcd;
                ans += L[v * 2000000000L + u];
            }

        }
        return ans;
    }
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
}
#endregion
#region HashMap
public class HashMap<K, V> : Dictionary<K, V>
//where V : new()
{
    public HashMap() : base() { }
    public HashMap(int cap) : base(cap) { }
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v :
                base[i] = default(V);
            //base[i] = new V();
        }
        set { base[i] = value; }
    }
}
#endregion