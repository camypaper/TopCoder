using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ParenthesesAndPermutation
{
    public string getSequence(int[] p)
    {
        var n = p.Length;
        var dp = new string[n + 2];
        dp[0] = new string('b', n);
        for (int i = 0; i < n; i++)
        {
            var next = new string[n + 2];
            for (int j = 0; j < n; j++)
            {
                if (dp[j] == null) continue;

                {
                    var tt = dp[j].ToCharArray();
                    tt[p[i]] = 'a';
                    var ttt = tt.AsString();
                    if (next[j + 1] == null) next[j + 1] = ttt;
                    else if (string.CompareOrdinal(ttt, next[j + 1]) < 0) next[j + 1] = ttt;

                }
                if (j - 1 >= 0)
                {
                    var ttt = dp[j];
                    if (next[j - 1] == null) next[j - 1] = ttt;
                    else if (string.CompareOrdinal(ttt, next[j - 1]) < 0) next[j - 1] = ttt;
                }
            }
            dp = next;
        }


        if (dp[0] == null) return "Impossible";
        return dp[0].Select(x => x == 'a' ? '(' : ')').AsString();
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
