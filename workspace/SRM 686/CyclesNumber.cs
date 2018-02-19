using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CyclesNumber
{
    public int[] getExpectation(int[] N, int[] M)
    {
        const int MOD = 1000000007;
        var fact = new int[100050];
        var s = Enumerate(100050, x => new int[322]);
        var S = Enumerate(322, x => new int[322]);
        fact[0] = 1;
        s[0][0] = 1;
        S[0][0] = 1;
        for (int i = 1; i < 100050; i++)
            fact[i] = (int)((1L * fact[i - 1] * i) % MOD);
        for (int i = 0; i <= 100000; i++)
            for (int j = 0; j < 320; j++)
            {

                long x = s[i][j];
                s[i + 1][j] = (int)((s[i + 1][j] + i * x) % MOD);
                s[i + 1][j + 1] = (s[i + 1][j + 1] + s[i][j]) % MOD;
            }
        for (int i = 0; i < 320; i++)
            for (int j = 0; j < 320; j++)
            {
                S[i + 1][j] = (int)((S[i + 1][j] + 1L * j * S[i][j]) % MOD);
                S[i + 1][j + 1] = (S[i + 1][j + 1] + S[i][j]) % MOD;
            }
        var ans = new int[N.Length];
        for (int i = 0; i < N.Length; i++)
        {
            var n = N[i];
            var m = M[i];
            int ret = 0;
            for (int j = 0; j <= m; j++)
            {
                long x = S[m][j];
                x = (x * s[n + 1][j + 1]) % MOD;
                x = (x * fact[j]) % MOD;
                ret = (int)((ret + x) % MOD);
            }
            ans[i] = ret;
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
