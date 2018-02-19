using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KthStringAgain
{
    public string getKth(string s, long k)
    {
        var n = s.Length;
        var ans = Enumerate(n, x => '?');
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                ans[i] = (char)(j + 'a');
                Func<int, int, int, long> dfs = null;
                var dp = new long[n, n];
                for (int l = 0; l < n; l++)
                    for (int r = 0; r < n; r++)
                        dp[l, r] = -1;
                dfs = (l, r, p) =>
                {
                    if (p == n) return 1;
                    if (dp[l, r] != -1) return dp[l, r];
                    var ret = 0L;
                    if (s[p] == ans[l] || ans[l] == '?') ret += dfs(l + 1, r, p + 1);
                    if (s[p] == ans[r] || ans[r] == '?') ret += dfs(l, r - 1, p + 1);

                    return dp[l, r] = ret;
                };
                var val = dfs(0, n - 1, 0);
                if (val >= k) { break; }
                else k -= val;

            }
        }
        return new string(ans);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(string s, long k)
    {
        return "";
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
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
