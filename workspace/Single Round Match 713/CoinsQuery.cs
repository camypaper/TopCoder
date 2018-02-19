using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CoinsQuery
{
    public long[] query(int[] w, int[] v, int[] query)
    {
        var dp = new Pair<long, ModInteger>[150 * 150];
        for (int i = 0; i < 150 * 150; i++)
            dp[i] = new Pair<long, ModInteger>(-1, 0);
        dp[0] = new Pair<long, ModInteger>(0, 1);
        var n = w.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 150 * 150; j++)
            {
                if (j + w[i] >= 150 * 150) continue;
                if (dp[j].x == -1) continue;
                var nv = dp[j].x + v[i];
                if (dp[j + w[i]].x < nv) dp[j + w[i]] = new Pair<long, ModInteger>(nv, dp[j].y);
                else if (dp[j + w[i]].x == nv) dp[j + w[i]].y += dp[j].y;
            }
        }

        long ww = -1;
        long vv = -1;
        var cnt = 0;
        for (int i = 0; i < n; i++)
        {
            if (ww == -1) { ww = w[i]; vv = v[i]; cnt = 1; }
            else
            {
                if (ww * v[i] > w[i] * vv) { ww = w[i]; vv = v[i]; cnt = 1; }
                else if (ww * v[i] == w[i] * vv) cnt++;
            }
        }
        var ret = new List<long>();
        foreach (var s in query)
        {
            if (s >= dp.Length)
            {
                var ok = false;
                for (int j = 150 * 150 - 1; j >= 0; j--)
                {
                    if ((s - j) % ww == 0)
                    {
                        var nv = dp[j].x; var nc = dp[j].y;
                        var k = (s - j) / ww;
                        nv += k * vv;
                        nc *= ModInteger.Pow(cnt, k);
                        ret.Add(nv); ret.Add(nc.num);
                        ok = true;
                        break;
                    }
                }
                if (!ok)
                    ret.Add(-1); ret.Add(-1);
            }
            else if (dp[s].x == -1) { ret.Add(-1); ret.Add(-1); }
            else { ret.Add(dp[s].x); ret.Add(dp[s].y.num); }
        }
        return ret.ToArray();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long[] Naive_Test(int[] w, int[] v, int[] query)
    {
        return new long[] { };
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
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
#region Compair

public struct Pair<FT, ST>
{
    public FT x;
    public ST y;
    public Pair(FT f, ST s) : this() { x = f; y = s; }

    public override string ToString() { return string.Format("{0} {1}", x, y); }
}
#endregion
#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger() { num = l.num * r.num % Mod }; }
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