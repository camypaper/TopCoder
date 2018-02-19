using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class WinterAndShopping
{
    public int getNumber(int[] first, int[] red, int[] green, int[] blue)
    {
        const long MOD = (long)1e9 + 7;
        var n = first.Length;
        var ev = Enumerate(550, x => new List<int>());
        for (int i = 0; i < n; i++)
        {
            first[i]--;
            ev[first[i]].Add(i);
        }
        var dp = new long[150, 150];
        dp[0, 0] = 1;
        var cur = -1;
        var binomial = new long[550, 550];
        binomial[0, 0] = 1;
        for (int i = 0; i < 520; i++)
            for (int j = 0; j < 520; j++)
            {
                binomial[i + 1, j] += binomial[i, j];
                binomial[i + 1, j + 1] += binomial[i, j];
                binomial[i + 1, j] %= MOD;
                binomial[i + 1, j + 1] %= MOD;
            }
        for (int t = 0; t < 520;)
        {
            if (cur != -1 && first[cur] + red[cur] + green[cur] + blue[cur] == t)
                cur = -1;

            if (ev[t].Count > 0)
            {
                foreach (var id in ev[t])
                {
                    if (cur == -1)
                    {
                        cur = id;
                        var next = new long[150, 150];
                        next[red[id], green[id]] = dp[0, 0];
                        dp = next;
                    }
                    else
                    {
                        var endcur = first[cur] + red[cur] + green[cur] + blue[cur];
                        var endid = first[id] + red[id] + green[id] + blue[id];
                        if (endcur < endid)
                        {
                            var next = new long[150, 150];
                            for (int i = 0; i < 120; i++)
                            {
                                if (i > red[id]) continue;
                                for (int j = 0; j < 120; j++)
                                {
                                    if (j > green[id]) continue;
                                    var k = blue[cur];
                                    k -= (t - first[cur]) - (red[cur] - i) - (green[cur] - j);
                                    if (k < 0 || k > blue[id]) continue;
                                    next[red[id] - i, green[id] - j] += ((binomial[endcur - t, i] * binomial[endcur - t - i, j]) % MOD) * dp[i, j];
                                    next[red[id] - i, green[id] - j] %= MOD;
                                }
                            }
                            cur = id;
                            dp = next;
                            t = endcur;
                            goto NEXT;
                        }
                        else if (endcur == endid)
                        {
                            var next = new long[150, 150];
                            next[0, 0] = dp[red[id], green[id]] * ((binomial[endcur - t, red[id]] * binomial[endcur - t - red[id], green[id]]) % MOD);
                            next[0, 0] %= MOD;
                            dp = next;
                            t = endcur;
                            goto NEXT;
                        }
                        else
                        {
                            var next = new long[150, 150];
                            for (int i = 0; i < 120; i++)
                            {
                                if (i < red[id]) continue;
                                for (int j = 0; j < 120; j++)
                                {
                                    if (j < green[id]) continue;
                                    var k = blue[cur];
                                    k -= (t - first[cur]) - (red[cur] - i) - (green[cur] - j);
                                    if (k < 0 || k < blue[id]) continue;
                                    next[i - red[id], j - green[id]] += ((binomial[endid - t, red[id]] * binomial[endid - t - red[id], green[id]]) % MOD) * dp[i, j];
                                    next[i - red[id], j - green[id]] %= MOD;
                                }
                            }
                            dp = next;
                            t = endid;
                            goto NEXT;
                        }
                    }
                }

            }
            if (cur == -1) { t++; continue; }
            else
            {
                var next = new long[120, 120];
                for (int i = 0; i < 120; i++)
                    for (int j = 0; j < 120; j++)
                    {
                        if (dp[i, j] == 0) continue;
                        var k = blue[cur];
                        k -= (t - first[cur]) - (red[cur] - i) - (green[cur] - j);
                        if (k < 0) continue;
                        if (i > 0) next[i - 1, j] = (next[i - 1, j] + dp[i, j]) % MOD;
                        if (j > 0) next[i, j - 1] = (next[i, j - 1] + dp[i, j]) % MOD;
                        if (k > 0) next[i, j] = (next[i, j] + dp[i, j]) % MOD;
                    }
                dp = next;
                t += 1;
            }
            NEXT:;
        }
        return (int)dp[0, 0];
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] first, int[] red, int[] green, int[] blue)
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
