using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColorfulBoard
{
    public int theMin(string[] s)
    {
        var ans = 100000;
        var n = s.Length;
        var m = s[0].Length;
        for (int k = 0; k < n + m; k++)
        {
            var ok = true;
            var R = Enumerate(n, x => '?');
            var C = Enumerate(m, x => '?');
            if (k < n) for (int j = 0; j < m; j++) C[j] = s[k][j];
            else for (int i = 0; i < n; i++) R[i] = s[i][k - n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (s[i][j] == C[j]) continue;
                    if (s[i][j] == R[i]) continue;
                    if (R[i] == '?') R[i] = s[i][j];
                    if (C[j] == '?') C[j] = s[i][j];
                }

            var g = new bool[n + m, n + m];
            for (int i = 0; i < n + m; i++)
                g[i, i] = true;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (s[i][j] != C[j] && s[i][j] != R[i]) ok = false;
                    if (R[i] == C[j]) continue;
                    if (s[i][j] == R[i]) g[n + j, i] = true;
                    else g[i, n + j] = true;
                }
            for (int kk = 0; kk < n + m; kk++)
                for (int i = 0; i < n + m; i++)
                    for (int j = 0; j < n + m; j++)
                        g[i, j] |= g[i, kk] & g[kk, j];
            for (int i = 0; i < n + m; i++)
                for (int j = i + 1; j < n + m; j++)
                    if (g[i, j] & g[j, i]) ok = false;
            if (ok)
                ans = Math.Min(ans, R.Count(x => x != '?') + C.Count(x => x != '?'));

        }
        if (ans > n + m) return -1;
        return ans;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int Naive_Test(string[] board)
    {
        return 0;
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
        //ManualTest(new string[] { "ac", "xx", "ab" });
        //Tests.Add(null);
    }
}
// CUT end
