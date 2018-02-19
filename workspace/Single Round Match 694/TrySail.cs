using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TrySail
{
    public int get(int[] strength)
    {
        Debug.WriteLine(strength.Length);
        var dp = new bool[256, 256];
        dp[0, 0] = true;
        var sum = 0;
        foreach (var x in strength)
        {
            var next = new bool[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    if (!dp[i, j]) continue;
                    var rem = sum ^ i ^ j;
                    next[i ^ x, j] |= dp[i, j];
                    next[i, j ^ x] |= dp[i, j];
                    next[i, j] |= dp[i, j];
                }
            dp = next;
            sum ^= x;
        }
        var max = 0;
        for (int i = 0; i < 256; i++)
            for (int j = 0; j < 256; j++)
            {
                if (!dp[i, j]) continue;
                var rem = sum ^ i ^ j;
                max = Math.Max(max, i + j + rem);
            }
        return max;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
