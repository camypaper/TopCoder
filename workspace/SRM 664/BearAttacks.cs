using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearAttacks
{
    public int expectedValue(int n, int R0, int A, int B, int M, int LOW, int HIGH)
    {
        long a = A, b = B, r = R0, l = LOW, h = HIGH;
        var G = Enumerate(n, x => new List<int>());
        var par = new int[n];
        par[0] = -1;

        for (int i = 1; i < n; i++)
        {
            r = (a * r + b) % M;
            var min = ((i - 1) * l) / 1000000000;
            var max = ((i - 1) * h) / 1000000000;
            par[i] = (int)(min + (r % (max - min + 1)));
            G[i].Add((int)(min + (r % (max - min + 1))));
            G[(int)(min + (r % (max - min + 1)))].Add(i);
        }
        ModInteger P = 1;
        for (int i = 1; i <= n; i++)
            P *= i;
        ModInteger ans = 0;
        for (int i = 0; i < n; i++)
            ans += ModInteger.Inverse(i + 1);


        var inv = new ModInteger[n + 1];
        //inverse construct
        {
            var fact = new ModInteger[n + 1];
            fact[0] = 1;
            for (int i = 1; i <= n; i++)
                fact[i] = fact[i - 1] * i;
            inv[n] = ModInteger.Inverse(fact[n]);
            for (int i = n - 1; i >= 0; i--)
                inv[i] = inv[i + 1] * (i + 1);
            for (int i = 1; i <= n; i++)
                inv[i] *= fact[i - 1];
        }
        var dp = new ModInteger[n];
        for (int cur = n - 1; cur >= 0; cur--)
        {
            ModInteger ret = 1;
            foreach (var to in G[cur])
            {
                if (to == par[to]) continue;
                ret += dp[to];
            }
            ret *= inv[cur + 1];
            dp[cur] = ret;
        }
        var cumsum = new ModInteger[n];
        {
            var q = new Queue<int>();
            q.Enqueue(0);
            while (q.Any())
            {
                var cur = q.Dequeue();
                var cum = cumsum[cur];
                //Debug.WriteLine("{0} {1}", prev, cur);
                //curにつながっている連結成分のサイズ
                ans += 2 * cum * inv[cur + 1];
                var sz = dp[cur] * (cur + 1);
                foreach (var to in G[cur])
                {
                    if (to == par[cur]) continue;
                    sz -= dp[to];
                    var sz2 = (cum + sz) * inv[cur + 1];
                    cumsum[to] = sz2;
                    q.Enqueue(to);
                }


            };
        }
        //Debug.WriteLine(dp.AsJoinedString());
        ans *= P;
        Debug.WriteLine(ans);
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
        //test.ManualTest(992284, 174375768, 19813892, 408594106, 957639341, 999000000, 1000000000);
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
#region Inverse
public partial struct ModInteger
{
    static public ModInteger Inverse(ModInteger v)
    {
        long p, q;
        ExGCD(v.num, Mod, out p, out q);
        return new ModInteger(p % Mod + Mod);
    }
    static public long ExGCD(long a, long b, out long x, out long y)
    {
        var u = new long[] { a, 1, 0 };
        var v = new long[] { b, 0, 1 };
        while (v[0] != 0)
        {
            var t = u[0] / v[0];
            for (int i = 0; i < 3; i++)
            {
                var tmp = u[i] - t * v[i];
                u[i] = v[i];
                v[i] = tmp;
            }
        }
        x = u[1];
        y = u[2];
        if (u[0] > 0)
            return u[0];
        for (int i = 0; i < 3; i++)
            u[i] = -u[i];
        return u[0];

    }
}
#endregion