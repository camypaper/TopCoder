using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Softmatch
{
    public int count(string s, string[] P)
    {
        P = P.OrderBy(x => x.Length).ToArray();
        var n = s.Length;
        var m = P.Length;
        var dp = new int[m + 1, 52];
        for (int i = 0; i < m + 1; i++)
            for (int j = 0; j < 52; j++)
                dp[i, j] = -1000000000;
        dp[m, 0] = 0;
        Func<char, char, bool> same = (x, y) =>
             {
                 if (x == 'a' || x == 'A')
                 {
                     if (y == '0' || y == '1') return x == 'a';
                     else return x == 'A';
                 }
                 else
                 {
                     if (y == '0' || y == '2') return x == 'b';
                     else return x == 'B';
                 }
             };
        for (int pos = 0; pos < s.Length; pos++)
        {
            var c = s[pos];
            var next = new int[m + 1, 52];
            for (int i = 0; i < m + 1; i++)
                for (int j = 0; j < 52; j++)
                    next[i, j] = -1000000000;

            for (int i = 0; i <= m; i++)
                for (int j = 0; j <= 50; j++)
                {
                    if (dp[i, j] < 0) continue;
                    var pat = "";
                    if (i != m)
                    {
                        for (int k = j - 1, l = pos - 1; k >= 0; k--, l--)
                        {
                            if (same(s[l], P[i][k])) pat = s[l] + pat;
                            else pat = char.ToUpper(s[l]) + pat;

                        }
                        if (j == 0)
                        {
                            if (same(s[pos - 1], P[i][j])) pat += char.ToUpper(s[pos - 1]);
                            else pat += s[pos - 1];
                        }
                    }

                    //a
                    for (int _ = 0; _ < 2; _++)
                    {
                        var p = 0; var q = 0;

                        var npat = pat;
                        if (_ == 0) npat += c;
                        else npat += char.ToUpper(c);

                        var v = dp[i, j];
                        for (int x = 0; x < m; x++)
                        {
                            for (int y = 1; y <= P[x].Length; y++)
                            {
                                if (y > npat.Length) break;
                                var ok = true;
                                for (int k = y - 1, l = npat.Length - 1; k >= 0; k--, l--)
                                {
                                    if (!same(npat[l], P[x][k])) { ok = false; break; }

                                }

                                if (ok)
                                {
                                    if (q < y) { p = x; q = y; }
                                    if (y == P[x].Length) v++;
                                }

                            }
                        }
                        next[p, q] = Math.Max(next[p, q], v);
                    }
                }
            dp = next;
        }
        var max = 0;
        for (int i = 0; i <= m; i++)
            for (int j = 0; j < 52; j++)
                max = Math.Max(max, dp[i, j]);
        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string S, string[] patterns)
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
