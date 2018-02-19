using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GCDLCM2
{
    public int getMaximalSum(int[] start, int[] d, int[] cnt)
    {
        var xs = new List<int>();
        for (int i = 0; i < start.Length; i++)
            for (int j = 0; j < cnt[i]; j++)
                xs.Add(start[i] + j * d[i]);
        xs.Sort();
        return f(xs.Count, xs.ToArray());
    }
    int f(int n, int[] a)
    {
        var ret = new ModInteger[n];
        for (int i = 0; i < n; i++)
            ret[i] = 1;

        var map = new HashMap<int, List<int>>();
        for (int i = 0; i < n; i++)
        {
            for (int v = 2; v * v <= a[i]; v++)
            {
                var cnt = 0;
                while (a[i] % v == 0) { a[i] /= v; cnt++; }
                if (cnt > 0) map[v].Add(-cnt);
            }
            if (a[i] > 1) map[a[i]].Add(-1);
        }
        ModInteger ans = 0;
        foreach (var kv in map)
        {
            var p = kv.Key;
            var b = kv.Value; b.Sort();
            for (int i = 0; i < b.Count; i++)
                ret[i] *= ModInteger.Pow(p, -b[i]);
        }

        for (int i = 0; i < n; i++)
            ans += ret[i];

        return (int)ans.num;
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
    }
}
// CUT end
#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static ModInteger operator ^(ModInteger l, long r) { return ModInteger.Pow(l, r); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
    public static ModInteger Pow(ModInteger v, long k)
    {
        ModInteger ret = 1;
        var n = k;
        for (; n > 0; n >>= 1, v *= v)
        {
            if ((n & 1) == 1)
                ret = ret * v;
        }
        return ret;
    }
}
#endregion
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
            //base[i] = default(V);
            base[i] = new V();
        }
        set { base[i] = value; }
    }
}
#endregion