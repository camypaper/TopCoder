using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class PerfectMemory
{
    public double getExpectation(int N, int M)
    {
        var all = N * M / 2;
        var dp = new double[all + 1, all + 1];
        for (int i = 0; i <= all; i++)
            for (int j = 0; j <= all; j++)
                dp[i, j] = -1;
        Func<int, int, double> f = (p, n) => 1.0 * p / n;
        Func<int, int, double> dfs = null;
        dfs = (rem, opened) =>
            {
                if (dp[rem, opened] >= 0.0)
                    return dp[rem, opened];
                if (rem == 0)
                    return dp[rem, opened] = opened;

                var ret = 1.0;
                var sz = 2 * rem + opened;
                var p = f(rem * 2, sz);
                var q = 1.0 - p;
                if (opened > 0)
                    ret += q * dfs(rem, opened - 1);

                ret += p * f(opened, sz - 1) * (1 + dfs(rem - 1, opened));
                ret += p * f(1, sz - 1) * dfs(rem - 1, opened);
                if (rem >= 2)
                    ret += p * f(2 * rem - 2, sz - 1) * dfs(rem - 2, opened + 2);

                return dp[rem, opened] = ret;
            };
        return dfs(all, 0);
    }
}
