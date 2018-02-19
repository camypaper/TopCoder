using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Double;
public class DengklekMessage
{
    public double theExpected(string[] pieces, string[] goodSubstring, long K)
    {
        var s = goodSubstring.SelectMany(x => x).AsString();
        var n = s.Length;
        var to = new int[n + 1, 2];
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                var ss = s.Substring(0, i);
                ss += (char)(j + '0');
                for (int k = Math.Min(n, ss.Length); k >= 0; k--)
                {
                    var suf = ss.Reverse().Take(k).Reverse().AsString();
                    if (suf == s.Substring(0, k)) { to[i, j] = k; break; }
                }
            }
        }
        var toto = Enumerate(pieces.Length, x => new int[n + 1]);
        var plus = Enumerate(pieces.Length, x => new int[n + 1]);
        for (int type = 0; type < pieces.Length; type++)
        {
            for (int i = 0; i <= n; i++)
            {
                var pos = i;
                foreach (var x in pieces[type])
                {
                    pos = to[pos, x - '0'];
                    if (pos == n) plus[type][i]++;
                }
                toto[type][i] = pos;
            }
        }
        var dp = new double[n + 2, 512];
        dp[0, 0] = 1;
        for (int k = 0; k < 511; k++)
        {

            for (int t = 0; t < pieces.Length; t++)
                for (int i = 0; i <= n; i++)
                {
                    if (dp[i, k] == 0) continue;
                    dp[toto[t][i], k + 1] += dp[i, k] / pieces.Length;
                    dp[n + 1, k + 1] += plus[t][i] * dp[i, k] / pieces.Length;
                }
            dp[n + 1, k + 1] += dp[n + 1, k];
        }
        if (K < 512) return dp[n + 1, K];
        return dp[n + 1, 510] + (dp[n + 1, 511] - dp[n + 1, 510]) * (K - 510);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(string[] pieces, string[] goodSubstring, long K)
    {
        return 0.0;
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
