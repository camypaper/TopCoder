using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColorfulLineGraphs
{
    public int countWays(long N, long K, int M)
    {
        long MOD = M;
        var mod = Enumerate(M + 100, x => -1L);
        //dp(i)=dp(i-1)*(K+(i-1)*(K-1))
        //dp(0)=1
        mod[0] = 1;
        long m = 1;
        long n = 0;
        long mul = 1;
        while (n < N)
        {
            mul += K - 1;
            mul %= MOD;
            m *= mul;
            m %= MOD;
            //Debug.WriteLine(m);
            n++;
            mod[n] = m;
            if (n > 1 && mul == 1) break;
        }
        Debug.WriteLine(n);
        if (n == N) return (int)m;
        else return (int)(ModPow(m, N / n, MOD) * mod[N % n] % MOD);
    }
    static public long ModPow(long x, long n, long mod)
    {
        long r = 1;
        while (n > 0)
        {
            if ((n & 1) == 1)
                r = r * x % mod;
            x = x * x % mod;
            n >>= 1;
        }
        return r;
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
        test.ManualTest(5000000000, 5000000000, 100007);
    }
}
// CUT end
