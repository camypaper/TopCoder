using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;

public class ModEquation
{
    public int[] count(int n, int K, int[] query)
    {
        var div = new List<int>();
        for (int i = 1; i * i <= K; i++)
            if (K % i == 0) { div.Add(i); div.Add(K / i); }
        div = div.Distinct().ToList(); div.Sort();
        var m = div.Count;
        var cnt = new int[m];
        for (int i = m - 1; i >= 0; i--)
        {
            cnt[i] = K / div[i];
            for (int j = i + 1; j < m; j++)
                if (div[j] % div[i] == 0) cnt[i] -= cnt[j];
        }
        var go = Enumerate(m, x => new int[m]);
        for (int i = 0; i < m; i++)
            for (int j = 0; j < m; j++)
            {
                var x = (int)MathEx.GCD(K, 1L * div[i] * div[j]);
                var pos = div.BinarySearch(x);
                go[i][j] = pos;
            }
        var dp = new ModInteger[m];
        dp[0] = 1;
        for (int i = 0; i < n; i++)
        {
            var next = new ModInteger[m];
            for (int j = 0; j < m; j++)
                for (int k = 0; k < m; k++)
                    next[go[j][k]] += dp[j] * cnt[k];
            dp = next;
        }
        var ans = new int[query.Length];
        for (int i = 0; i < query.Length; i++)
        {
            var gcd = (int)MathEx.GCD(K, query[i]);
            var pos = div.BinarySearch(gcd);
            var x = dp[pos];
            x *= ModInteger.Pow(cnt[pos], (ModInteger.Mod - 2));
            ans[i] = (int)x.num;
        }

        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int[] Naive_Test(int n, int K, int[] query)
    {
        return new int[] { };
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
    public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static implicit operator ModInteger(long n) { return new ModInteger() { num = n }; }
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
static public partial class MathEx
{

    static public Number GCD(Number x, Number y)
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
