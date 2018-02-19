using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ConstructLCS
{
    public string construct(int ab, int bc, int ca)
    {
        var otaku = new[] { ab, bc, ca };
        var min = new[] { ab, bc, ca }.Min();
        ab -= min; bc -= min; ca -= min;
        var ans = new[] { "", "", "" };
        for (int i = 0; i < 3; i++)
            ans[i] = new string('1', min);
        var c = '0';
        if (ab > 0)
        {
            ans[0] += new string(c, ab);
            ans[1] += new string(c, ab);
            c++;
        }
        if (bc > 0)
        {
            ans[1] += new string(c, bc);
            ans[2] += new string(c, bc);
            c++;
        }
        if (ca > 0)
        {
            ans[0] += new string(c, ca);
            ans[2] += new string(c, ca);
            c++;
        }
        if (otaku[0] != lcs(ans[0], ans[1]))
        {

        }
        if (otaku[1] != lcs(ans[1], ans[2]))
        {


        }
        if (otaku[2] != lcs(ans[2], ans[0]))
        {

        }

        var s = ans[0] + " " + ans[1] + " " + ans[2];

        return s;
    }
    int lcs(string s, string t)
    {
        var n = s.Length; var m = t.Length;
        s += "$";
        t += "%";
        var dp = new int[s.Length + 2, t.Length + 2];
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= m; j++)
            {
                dp[i + 1, j] = Math.Max(dp[i + 1, j], dp[i, j]);
                dp[i, j + 1] = Math.Max(dp[i, j + 1], dp[i, j]);
                dp[i + 1, j + 1] = Math.Max(dp[i + 1, j + 1], dp[i, j]);
                if (s[i] == t[j])
                    dp[i + 1, j + 1] = Math.Max(dp[i + 1, j + 1], dp[i, j] + 1);
            }


        return dp[n, m];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(int ab, int bc, int ca)
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
        for (int i = 50; i > 0; i--)
            for (int j = 1; j <= 50; j++)
                for (int k = 1; k <= 50; k++)
                {
                    Debug.WriteLine("{0} {1} {2}", i, j, k);
                    ManualTest(i, j, k, true);
                }
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
