using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class LongWordsDiv1
{
    public int count(int n)
    {
        const long MOD = 1000000007;
        var dp = new long[n + 1];
        for (int i = 0; i <= n; i++)
            dp[i] = -1;
        dp[0] = 0;
        dp[1] = 1;
        Func<int, long> dfs = null;
        dfs = N =>
          {
              if (dp[N] >= 0) return dp[N];
              //A dp[N-1] A
              long ret = dfs(N - 1);
              for (int l = 1; l < N - 1; l++)
                  ret = (ret + dfs(l) * dfs(N - 1 - l)) % MOD;

              return dp[N] = ret;
          };
        var ans = dfs(n);
        for (int i = 1; i <= n; i++)
            ans = (ans * i) % MOD;
        return (int)ans;
    }

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
