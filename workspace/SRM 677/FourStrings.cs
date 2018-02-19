using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FourStrings
{
    public int shortestLength(string a, string b, string c, string d)
    {
        var S = new string[] { a, b, c, d };
        var dp = new int[20, 20, 20, 20];
        for (int i = 0; i < 20; i++)
            for (int j = 0; j < 20; j++)
                for (int k = 0; k < 20; k++)
                    for (int l = 0; l < 20; l++)
                        dp[i, j, k, l] = 1000000000;
        dp[0, 0, 0, 0] = 0;
        for (int i = 0; i <= a.Length; i++)
            for (int j = 0; j <= b.Length; j++)
                for (int k = 0; k <= c.Length; k++)
                    for (int l = 0; l <= d.Length; l++)
                    {
                        var go = new List<int>();
                        if (i < a.Length) go.Add(0);
                        if (j < b.Length) go.Add(1);
                        if (k < c.Length) go.Add(2);
                        if (l < d.Length) go.Add(3);
                        for (int mask = 1; mask < 1 << go.Count; mask++)
                        {
                            var ch = '$';
                            var ok = true;
                            var next = new int[] { i, j, k, l };
                            for (int u = 0; u < go.Count; u++)
                                if ((mask >> u & 1) == 1)
                                {
                                    var id = go[u];
                                    if (ch == '$' || ch == S[id][next[id]])
                                        ch = S[id][next[id]++];
                                    else ok = false;
                                }
                                else next[go[u]] = 0;
                            if (ok)
                            {
                                dp[next[0], next[1], next[2], next[3]] = Math.Min(dp[next[0], next[1], next[2], next[3]], dp[i, j, k, l] + 1);
                            }
                        }
                    }
        return dp[a.Length, b.Length, c.Length, d.Length];
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
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
#region LCP
static public partial class StringEx
{
    /// <summary>S‚ÆT‚ÌÅ’·‹¤’ÊÚ“ª«‚ğ‹‚ß‚éDO(|S||T|)</summary>
    /// <returns>ret[i][j]=s[i]‚©‚ç‚Ì•”•ª•¶š—ñ‚Æt[j]‚©‚ç‚Ì•”•ª•¶š—ñ‚ÌÚ“ª«‚ª‚Ç‚ê‚¾‚¯ˆê’v‚µ‚Ä‚¢‚é‚©</returns>
    static public int[][] LongestCommonPrefix(string s, string t)
    {
        var ret = new int[s.Length + 1][];
        for (int i = 0; i <= s.Length; i++)
            ret[i] = new int[t.Length + 1];
        for (int i = s.Length - 1; i >= 0; i--)
            for (int j = 0; j < t.Length; j++)
                if (s[i] == t[j]) ret[i][j] = ret[i + 1][j + 1] + 1;
        return ret;
    }
}
#endregion