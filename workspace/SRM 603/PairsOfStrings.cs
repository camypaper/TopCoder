using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PairsOfStrings
{
    public int getNumber(int n, int k)
    {
        ModInteger ans = 0;
        var div = new List<int>();
        var dic = new Dictionary<long, ModInteger>();
        for (int i = 1; i * i <= n; i++)
        {
            if (n % i != 0) continue;
            if (i * i != n) div.Add(n / i);
            div.Add(i);
        }
        div.Sort();
        foreach (var D in div)
        {
            var cycle = ModInteger.Pow(k, D);
            foreach (var d in div)
            {
                if (D > d && D % d == 0)
                    cycle -= dic[d];
            }
            dic[D] = cycle;
            ans += cycle * D;
        }
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
public class Tester : AbstractTester
{
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0)num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod)n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod)n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
}
#endregion
#region ModPow
public partial struct ModInteger
{
    static public ModInteger Pow(ModInteger v, ModInteger k)
    {
        ModInteger ret = 1;
        var n = k.num;
        for (; n > 0; n >>= 1, v *= v)
        {
            if ((n & 1) == 1)
                ret = ret * v;
        }
        return ret;
    }
}
#endregion