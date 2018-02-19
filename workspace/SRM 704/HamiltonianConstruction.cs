using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class HamiltonianConstruction
{
    public string[] construct(int k)
    {
        var n = 20;
        var a = 1;
        var b = n - 2;
        var ret = Enumerate(n, x => new char[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                ret[i][j] = 'N';
        for (int i = a; i <= b; i++)
            ret[0][i] = ret[b][i] = 'Y';
        ret[b][b] = 'N';
        for (int i = a; i <= b; i++)
            for (int j = i + 1; j <= b; j++)
                ret[i][j] = 'Y';
        for (int i = 0; i < 20; i++)
            if ((k >> i & 1) == 1) ret[i + 1][n - 1] = 'Y';

        for (int i = 0; i < n; i++)
            Debug.WriteLine(new string(ret[i]));
        var dp = new int[1 << n, n];
        dp[1, 0] = 1;
        for (int i = 0; i < 1 << n; i++)
            for (int j = 0; j < n; j++)
            {
                if ((i >> j & 1) == 1 && dp[i, j] > 0)
                    for (int to = 0; to < n; to++)
                        if ((i >> j & 1) == 1 && (i >> to & 1) == 0 && ret[j][to] == 'Y') dp[i | (1 << to), to] += dp[i, j];
            }
        if (dp[(1 << n) - 1, n - 1] != k) throw new Exception();
        return Enumerate(n, x => new string(ret[x]));
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public string[] Naive_Test(int k)
    {
        return new string[] { };
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
        for (int i = 70000; i <= 100000; i++)
            ManualTest(i);
        //Tests.Add(null);
    }
}
// CUT end
