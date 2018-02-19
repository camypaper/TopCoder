using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndGreed
{
    public int count(int H, int W, int S)
    {
        Func<int, int, int, ModInteger> dfs = null;
        var dp = new ModInteger[H + 1, W + 1, S + 1];
        for (int i = 0; i < H + 1; i++)
            for (int j = 0; j < W + 1; j++)
                for (int k = 0; k < S + 1; k++)
                    dp[i, j, k].num = -1;
        dfs = (h, w, sum) =>
        {
            if (dp[h, w, sum].num != -1) return dp[h, w, sum];
            if (h == H && w == W)
            {
                if (sum == 0) return 1;
                else return 0;
            }
            ModInteger ret = 0;
            for (int v = 0; v <= S; v++)
            {
                if (sum - v < 0) break;
                if (h == H) { ret += dfs(h, w + 1, sum - v); }
                else if (w == W) { ret += dfs(h + 1, w, sum - v); }
                else
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var cnt = v + i;
                        if (i == 1) ret += cnt * dfs(h, w + 1, sum - v) * ModInteger.Pow(S, H - h);
                        else ret += cnt * dfs(h + 1, w, sum - v) * ModInteger.Pow(S, W - w);
                    }
                }
            }
            return dp[h, w, sum] = ret;
        };
        var ans = (int)dfs(1, 1, S).num;
        return ans;
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
    public const long Mod = (long)1e4 + 7;
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