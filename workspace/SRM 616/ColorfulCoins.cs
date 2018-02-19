using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColorfulCoins
{
    public int minQueries(long[] values)
    {
        var n = values.Length;
        long[] a = new long[n];
        a[n - 1] = -1;
        for (int i = 0; i < n - 1; i++)
            a[i] = values[i + 1] / values[i];
        Debug.WriteLine(string.Join(" ", a));
        var map = new SortedMap<long, int>();
        foreach (var x in a) map[x]++;
        var max = 1;
        var sum = 0;
        foreach (var kv in map)
        {
            if (kv.Key == -1) continue;
            sum += kv.Value;
            for (long i = 0, k = 1; ; i++, k *= kv.Key)
                if (k - 1 >= sum) { max = Math.Max(max, (int)i); break; }
        }
        return max;
    }


    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(new long[] { 1, 10, 80, 240, 1680, 13440, 67200, 201600, 1008000, 5040000 });
    }
}
// CUT end
#region HashMap
public class SortedMap<K, V>: SortedDictionary<K, V>
{
    public SortedMap() : base() { }
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v : base[i] = default(V);
        }
        set { base[i] = value; }
    }
}
#endregion