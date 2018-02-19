using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Mutalisk
{
    public int minimalAttacks(int[] a)
    {
        var n = a.Length;

        const int sz = 100;
        var dp = new int[sz, sz];
        var min = new int[sz, sz];
        for (int i = 0; i < sz; i++)
            for (int j = 0; j < sz; j++)
                dp[i, j] = min[i, j] = 1 << 20;
        dp[0, 0] = min[0, 0] = 0;


        foreach (var x in a)
        {
            //Debug.WriteLine(x);
            var next = new int[sz, sz];
            var nextmin = new int[sz, sz];
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                    next[i, j] = nextmin[i, j] = 1 << 20;
            var go = new List<KeyValuePair<int, KeyValuePair<int, int>>>();
            for (int p = 0; p <= 10 && 9 * p <= x + 8; p++)
                for (int q = 0; q <= 20; q++)
                {
                    var r = Math.Max(0, x - p * 9 - q * 3);
                    go.Add(new KeyValuePair<int, KeyValuePair<int, int>>(p, new KeyValuePair<int, int>(q, r)));
                    if (r == 0)
                        break;
                }
            for (int i = 0; i < sz; i++)
                for (int j = 0; j < sz; j++)
                {
                    if (dp[i, j] == 1 << 20)
                        continue;
                    foreach (var kkv in go)
                    {
                        int p = kkv.Key, q = kkv.Value.Key, r = kkv.Value.Value;
                        next[Math.Min(sz - 1, i + p), Math.Min(sz - 1, j + q)] = Math.Min(dp[i, j] + r, next[Math.Min(sz - 1, i + p), Math.Min(sz - 1, j + q)]);
                        nextmin[Math.Min(sz - 1, i + p), Math.Min(sz - 1, j + q)] = Math.Min(Math.Max(min[i, j], p + q + r), nextmin[Math.Min(sz - 1, i + p), Math.Min(sz - 1, j + q)]);
                    }
                }
            dp = next;
            min = nextmin;
        }
        var ans = 1 << 20;
        for (int i = 0; i < sz; i++)
            for (int j = 0; j < sz; j++)
            {
                if (dp[i, j] == 1 << 20)
                    continue;
                var max = Math.Max(Math.Max(i, Math.Max(j, dp[i, j])), min[i, j]);
                ans = Math.Min(ans, max);
            }
        return ans;

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
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
