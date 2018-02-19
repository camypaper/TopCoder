using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearDartsDiv2
{
    public long count(int[] a)
    {
        var n = a.Length;
        var map = new HashMap<int, int>();
        map[a[n - 1]]++;
        long ans = 0;
        for (int i = n - 2; i >= 0; i--)
        {
            long u = a[i];
            for (int j = i - 1; j >= 0; j--)
            {
                long v = u * a[j];
                if (v > 1000000) continue;
                for (int k = j - 1; k >= 0; k--)
                {
                    var val = v * a[k];
                    if (val <= 1000000) ans += map[(int)val];
                }
            }

            map[a[i]]++;
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
        var a = Enumerate(500, x => 1);
        test.ManualTest(a);
    }
}
// CUT end
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