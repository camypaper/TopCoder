using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class WinterAndSnowmen
{
    public int getNumber(int N, int M)
    {
        const int MOD = 1000000007;
        var max = Math.Max(N, M);
        int ans = 0;
        for (int k = 0; k < 10; k++)
        {
            var dp = Enumerate(2048, x => new int[2, 2]);
            dp[0][0, 0] = 1;
            for (int i = 1; i <= max; i++)
            {
                var p = i >> k;
                var q = p >> 1;
                var r = p & 1;
                var next = Enumerate(2048 >> k, x => new int[2, 2]);
                for (int j = 0; j < 2048 >> k; j++)
                    for (int u = 0; u < 2; u++)
                        for (int v = 0; v < 2; v++)
                        {
                            if (dp[j][u, v] == 0) continue;

                            if (i <= N)
                                if ((next[j ^ q][u ^ r, v] += dp[j][u, v]) >= MOD) next[j ^ q][u ^ r, v] -= MOD;

                            if (i <= M)
                                if ((next[j ^ q][u, v ^ r] += dp[j][u, v]) >= MOD) next[j ^ q][u, v ^ r] -= MOD;
                            if ((next[j][u, v] += dp[j][u, v]) >= MOD) next[j][u, v] -= MOD;
                        }
                dp = next;
            }
            ans += dp[0][0, 1];
            ans %= MOD;
        }
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
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
