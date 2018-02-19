using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int32;
public class CompositeSmash
{
    public string thePossible(int N, int target)
    {
        var factors = MathEx.GetFactors(N).Distinct().ToList();
        IOEx.Dump(factors, nameof(factors));
        if (N == target) return "Yes";
        if (factors.Contains(target)) return "Yes";
        if (factors.Count == 1)
        {
            var val = factors[0] * factors[0];
            if (N % val == 0 && target == val)
                return "Yes";
        }
        return "No";
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
#region Factors
public static partial class MathEx
{
    static public List<long> GetFactors(Number v)
    {
        var ret = new List<long>();
        for (Number i = 2; i * i <= v; i++)
        {
            if (v % i != 0) continue;
            while (v % i == 0)
            {
                ret.Add(i); v /= i;
            }
        }
        if (v > 1) ret.Add(v);
        ret.Sort();
        return ret;
    }
}
#endregion