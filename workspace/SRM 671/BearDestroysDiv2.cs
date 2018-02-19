using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearDestroysDiv2
{
    public int sumUp(int W, int H, int MOD)
    {
        ModInteger.Mod = MOD;

        //xoxox
        var dp = new ModInteger[1 << W];
        dp[0] = 1;
        ModInteger ans = 0;
        for (int _ = 0; _ < H; _++)
        {
            var next = new ModInteger[1 << W];
            //mask
            for (int mask = 0; mask < 1 << W; mask++)
            {
                if (dp[mask].num == 0) continue;
                //0:E 1:S
                for (int i = 0; i < 1 << W; i++)
                {

                    var ni = 0;
                    var cnt = 0;
                    for (int j = 0; j < W;)
                    {
                        if ((mask >> j & 1) == 1) j++;
                        else
                        {
                            //S
                            if ((i >> j & 1) == 1)
                            {
                                if (_ != H - 1) { cnt++; ni |= 1 << j; j++; }
                                else
                                {
                                    if ((mask >> (j + 1) & 1) == 1 || j == W - 1)
                                    {
                                        j++;
                                    }
                                    else 
                                    {
                                        cnt++;
                                        j += 2;
                                    }
                                }
                            }
                            else@//E
                            {
                                if ((mask >> (j + 1) & 1) == 1 || j == W - 1)
                                {
                                    if (_ != H - 1) { cnt++; ni |= 1 << j; }
                                    j++;
                                }
                                else
                                {
                                    cnt++;
                                    j += 2;
                                }
                            }
                        }

                    }
                    ans += cnt * dp[mask] * ModInteger.Pow(2, W * (H - _ - 1));
                    next[ni] += dp[mask];
                }

            }
            dp = next;
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
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(1, 1, 1000000009);
    }
}
// CUT end
#region ModNumber
public partial struct ModInteger
{
    public static long Mod = (long)1e9 + 7;
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