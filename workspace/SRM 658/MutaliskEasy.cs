using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MutaliskEasy
{
    public int minimalAttacks(int[] a)
    {
        var n = a.Length;
        var b = new int[3];
        for (int i = 0; i < n; i++)
            b[i] = a[i];
        var dp = new int[100, 100, 100];
        n = 3;
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 100; j++)
                for (int k = 0; k < 100; k++)
                    dp[i, j, k] = 1000000;
        dp[b[0], b[1], b[2]] = 0;
        var hit = new int[] { 1, 3, 9 };
        for (int i = 60; i >= 0; i--)
            for (int j = 60; j >= 0; j--)
                for (int k = 60; k >= 0; k--)
                {
                    if (dp[i, j, k] > 1000)
                        continue;
                    for (int p = 0; p < 3; p++)
                        for (int q = 0; q < 3; q++)
                            if (p != q) for (int r = 0; r < 3; r++)
                                {
                                    if (r != p && r != q)
                                    {
                                        dp[Math.Max(0, i - hit[p]), Math.Max(0, j - hit[q]), Math.Max(0, k - hit[r])] = Math.Min(dp[i, j, k] + 1, dp[Math.Max(0, i - hit[p]), Math.Max(0, j - hit[q]), Math.Max(0, k - hit[r])]);
                                    }
                                }
                }
        return dp[0, 0, 0];
    }
    // CUT begin

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
public class Tester : AbstractTester
{
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
    // CUT end

}
