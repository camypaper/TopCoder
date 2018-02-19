using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearBall
{
    public int countThrows(int[] x, int[] y)
    {
        var n = x.Length;
        var sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += disfrom(n, x, y, i);
        }
        return sum;
    }
    public int disfrom(int n, int[] x, int[] y, int p)
    {
        var map = new HashMap<long, List<int>>();
        for (int i = 0; i < n; i++)
        {
            if (i == p) continue;
            var u = x[i] - x[p];
            var v = y[i] - y[p];
            var gcd = GCD(Math.Abs(u), Math.Abs(v));
            var ug = u / gcd;
            var vg = v / gcd;
            var dydx = vg * 1000000000L + ug;
            if (ug != 0)
                map[dydx].Add(u);
            else map[dydx].Add(v);
        }
        var cnt = map.Count;
        foreach (var l in map)
        {
            l.Value.Sort();
        }
        if (cnt == 1)
        {
            var ans = 0;
            foreach (var kv in map)
            {
                var pos = 0;
                var neg = 0;
                foreach (var v in kv.Value)
                {
                    if (v < 0) neg++;
                    if (v > 0) pos++;
                }
                ans += pos * (pos + 1) / 2 + neg * (neg + 1) / 2;
            }
            return ans;
        }
        else
        {
            var ans = 0;
            foreach (var kv in map)
            {
                var pos = 0;
                var neg = 0;
                foreach (var v in kv.Value)
                {
                    if (v < 0) neg++;
                    if (v > 0) pos++;
                }
                if (pos > 0) { ans++; pos--; }
                if (neg > 0) { ans++; neg--; }
                ans += 2 * pos;
                ans += 2 * neg;
            }
            return ans;
        }



    }
    static public int GCD(int x, int y)
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
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        var n = 1500;
        var X = Enumerate(n, x => rand.Next(-20000, 20000));
        var Y = Enumerate(n, x => rand.Next(-20000, 20000));
        test.ManualTest(X, Y);
    }
}
// CUT end

#region HashMap
public class HashMap<K, V>: Dictionary<K, V>
where V : new()
{
    public HashMap() : base() { }
    public HashMap(int cap) : base(cap) { }
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v :
            //    base[i] = default(V);
            base[i] = new V();
        }
        set { base[i] = value; }
    }
}
#endregion