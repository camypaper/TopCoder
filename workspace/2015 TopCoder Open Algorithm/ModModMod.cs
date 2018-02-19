using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ModModMod
{
    public long findSum(int[] m, int R)
    {
        var n = m.Length;

        var len = m[0];
        var dp = new int[10000050];
        for (int i = 1; i <= R; i++)
            dp[i % len]++;
        for (int i = 1; i < n; i++)
        {
            var next = m[i];
            if (next < len)
            {
                for (int j = next; j < len; j++)
                    dp[j % next] += dp[j];
                len = next;
            }
        }
        var sum=0L;
        for (int i = 0; i < len; i++)
            sum += Math.BigMul(i, dp[i]);
        return sum;
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
