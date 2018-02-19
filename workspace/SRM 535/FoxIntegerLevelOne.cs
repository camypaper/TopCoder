using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;
public class FoxAndGCDLCM

{
    public long get(long G, long L)
    {
        var A = MathEx.GetFactors(G);
        var B = MathEx.GetFactors(L);
        var C = new List<KeyValuePair<long, long>>();
        var D = new List<long>();
        foreach (var x in B)
        {
            if (!A.ContainsKey(x.Key)) A[x.Key] = 0;
            if (A[x.Key] > x.Value)
                return -1;
            C.Add(new KeyValuePair<Number, Number>(x.Value, A[x.Key]));
            D.Add(x.Key);
        }
        foreach (var x in A)
            if (!B.ContainsKey(x.Key)) return -1;
        var min = long.MaxValue;
        for (int i = 0; i < 1 << C.Count; i++)
        {
            long u = 1;
            long v = 1;

            for (int j = 0; j < C.Count; j++)
            {
                var a = Pow(D[j], C[j].Key);
                var b = Pow(D[j], C[j].Value);
                if ((i >> j & 1) == 1) { u *= a; v *= b; }
                else { v *= a; u *= b; }
            }
            min = Math.Min(min, u + v);
        }
        return min;
    }

    static public long Pow(long r, long n)
    {
        if (n == 0) return 1;
        var ret = Pow(r * r, n >> 1);
        if ((n & 1) == 1) ret *= r;
        return ret;
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
#region Factors
public static partial class MathEx
{
    static public Dictionary<Number, int> GetFactors(Number v)
    {
        var ret = new Dictionary<Number, int>();
        for (Number i = 2; i * i <= v; i++)
        {
            if (v % i != 0) continue;
            var val = 0;
            while (v % i == 0)
            {
                val++; v /= i;
            }
            ret[i] = val;
        }
        if (v > 1) ret[v] = 1;
        return ret;
    }
}
#endregion