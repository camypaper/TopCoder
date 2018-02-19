using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TreeWalker
{
    public int calc(int N, int A0, int B, int C, int MOD)
    {
        var A = new int[N - 1];
        A[0] = A0;
        for (int i = 1; i < N - 1; i++)
            A[i] = (int)((Math.BigMul(B, A[i - 1]) + C) % MOD);
        var G = Enumerate(N, x => new List<int>());
        for (int i = 1; i < N; i++)
        {
            var to = (A[i - 1] % i);
            G[i].Add(to);
            G[to].Add(i);
        }

        var dp = new ModInteger[N];
        ModInteger ans = 0;
        Func<int, int, int> dfs = null;
        //G = Enumerate(3, x => new List<int>()); G[0].Add(1); G[0].Add(2);
        dfs = (prev, cur) =>
          {
              //Debug.WriteLine("{0} {1}", prev, cur);
              dp[cur] = 1;
              var ret = 0;
              foreach (var to in G[cur])
              {
                  if (prev == to) continue;
                  ret += dfs(cur, to) + 1;
                  ans += 2 * dp[cur] * dp[to] * ModInteger.Pow(2, N - 1 - ret);
                  dp[cur] = (dp[to] + dp[cur]) + dp[to];
                  //dp[cur] += dp[to] * 2;
              }
              return ret;
          };
        dfs(-1, 0);
        //for (int i = 0; i < N; i++) Debug.WriteLine(dp[i]);
        return (int)ans.num;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
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