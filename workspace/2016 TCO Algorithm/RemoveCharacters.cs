using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RemoveCharacters
{
    public int minimalDistinct(string A, string B)
    {
        var use = new int[26];
        var mask = 0;
        for (int i = 0; i < 26; i++)
            for (int j = i; j < 26; j++)
            {
                var sb = new StringBuilder();
                var tb = new StringBuilder();
                for (int k = 0; k < A.Length; k++)
                    if (A[k] - 'a' == i || A[k] - 'a' == j) sb.Append(A[k]);
                for (int k = 0; k < B.Length; k++)
                    if (B[k] - 'a' == i || B[k] - 'a' == j) tb.Append(B[k]);
                var s = sb.ToString();
                var t = tb.ToString();
                if (s == t)
                {
                    use[i] |= 1 << j;
                    use[j] |= 1 << i;
                    if (i == j) mask |= 1 << i;
                }
            }
        var ok = new int[1 << 13];
        for (int i = 0; i < 1 << 13; i++)
        {
            ok[i] = mask;
            for (int j = 0; j < 26; j++)
                if ((i >> j & 1) == 1) ok[i] &= use[j];
        }
        var ok2 = new int[1 << 13];
        for (int i = 0; i < 1 << 13; i++)
        {
            ok2[i] = mask;
            for (int j = 0; j < 26; j++)
                if ((i >> j & 1) == 1) ok[i] &= use[j];
        }
        var dp = new bool[1 << 13];
        dp[0] = true;
        for (int i = 0; i < 1 << 13; i++)
        {
            if (!dp[i]) continue;
            for (int j = 0; j < 13; j++)
            {
                if ((i >> j & 1) == 1) continue;
                if ((ok[i] >> j & 1) == 0) continue;
                dp[i | (1 << j)] = true;
            }
        }
        var pd = new bool[1 << 13];
        pd[0] = true;
        for (int i = 0; i < 1 << 13; i++)
        {
            if (!pd[i]) continue;
            for (int j = 0; j < 13; j++)
            {
                if ((i >> j & 1) == 1) continue;
                if ((ok2[i] >> (j + 13)) == 0) continue;
                pd[i | 1 << j] = true;
            }

        }
        var max = new int[1 << 13];
        for (int i = 0; i < 1 << 13; i++)
        {
            if (pd[i])
            {
                var cnt = 0;
                for (int j = 0; j < 13; j++)
                    if ((i >> j & 1) == 1) cnt++;
                max[i] = Math.Max(max[i], cnt);
            }
            for (int j = 0; j < 13; j++)
                if ((i >> j & 1) == 0) max[i | (1 << j)] = Math.Max(max[i | (1 << j)], max[i]);
        }

        var ans = 0;
        for (int i = 0; i < 1 << 13; i++)
        {
            if (!dp[i]) continue;
            var cnt = 0;
            for (int j = 0; j < 13; j++)
                if ((i >> j & 1) == 1) cnt++;
            var f = ok[i] >> 13;
            ans = Math.Max(ans, cnt + max[f]);
        }
        ans = 26 - ans;
        var unko = Naive_Test(A, B);
        Debug.Assert(ans == unko);
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string A, string B)
    {
        var n = A.Length;
        var m = B.Length;
        var dp = Enumerate(n + 1, x => new int[m + 1]);
        dp[0][0] = (1 << 26) - 1;
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= m; j++)
            {
                if (i < n && j < m && A[i] == B[j]) dp[i + 1][j + 1] = Math.Max(dp[i + 1][j + 1], dp[i][j]);
                if (i < n)
                    dp[i + 1][j] = Math.Max(dp[i + 1][j], dp[i][j] & ~(1 << (A[i] - 'a')));
                if (j < m)
                    dp[i][j + 1] = Math.Max(dp[i][j + 1], dp[i][j] & ~(1 << (B[j] - 'a')));
            }
        var cnt = 0;
        for (int i = 0; i < 26; i++)
        {
            if ((dp[n][m] >> i & 1) == 1) cnt++;
        }
        return 26 - cnt;
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
        Tests.Add(() => ManualTest("abcdbbac", "bacdbacb"));
        var s = "";
        var t = "";
        for (int i = 0; i < 1000; i++)
        {
            s += (char)((i % 26) + 'a');
            t += (char)(((i + 1) % 26) + 'a');
        }
        Tests.Add(() => ManualTest(s, t));
    }
}
// CUT end
