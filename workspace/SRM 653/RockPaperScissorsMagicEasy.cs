using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RockPaperScissorsMagicEasy
{
    public int count(int[] card, int score)
    {
        var dp = new long[2200];
        dp[0] = 1;
        const long MOD = 1000000007;
        foreach (var x in card)
        {
            var next = new long[2200];
            for (int i = 0; i <= 2000; i++)
            {
                next[i + 1] += dp[i];
                next[i + 1] %= MOD;
                next[i] += 2 * dp[i];
                next[i] %= MOD;
            }
            dp = next;
        }
        return (int)dp[score];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] card, int score)
    {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
