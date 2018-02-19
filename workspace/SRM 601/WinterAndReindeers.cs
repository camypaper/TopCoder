using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class WinterAndReindeers
{
    public int getNumber(string[] allA, string[] allB, string[] allC)
    {
        var A = allA.AsJoinedString("");
        var B = allB.AsJoinedString("");
        var C = allC.AsJoinedString("");
        var n = A.Length; var m = B.Length;
        var a = Enumerate(n, x => -100000);
        var b = Enumerate(m, x => -100000);
        for (int i = 0; i < n; i++)
            for (int j = i, p = 0; j < n; j++)
                if (A[j] == C[p]) { p++; if (p == C.Length) { a[i] = j + 1; break; } }
        for (int i = 0; i < m; i++)
            for (int j = i, p = 0; j < m; j++)
                if (B[j] == C[p]) { p++; if (p == C.Length) { b[i] = j + 1; break; } }
        var lcs = Enumerate(n + 1, x => Enumerate(m + 1, y => -100000));
        lcs[0][0] = 0;
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= m; j++)
            {
                if (i < n && j < m && A[i] == B[j])
                    lcs[i + 1][j + 1] = Math.Max(lcs[i + 1][j + 1], lcs[i][j] + 1);
                if (i < n) lcs[i + 1][j] = Math.Max(lcs[i + 1][j], lcs[i][j]);
                if (j < m) lcs[i][j + 1] = Math.Max(lcs[i][j + 1], lcs[i][j]);
            }
        var rev = Enumerate(n + 1, x => Enumerate(m + 1, y => -100000));
        rev[n][m] = 0;
        for (int i = n; i >= 0; i--)
            for (int j = m; j >= 0; j--)
            {
                if (i > 0 && j > 0 && A[i - 1] == B[j - 1])
                    rev[i - 1][j - 1] = Math.Max(rev[i - 1][j - 1], rev[i][j] + 1);
                if (i > 0) rev[i - 1][j] = Math.Max(rev[i - 1][j], rev[i][j]);
                if (j > 0) rev[i][j - 1] = Math.Max(rev[i][j - 1], rev[i][j]);
            }
        var max = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i] < 0 || b[j] < 0)
                    continue;
                var head = lcs[i][j];
                var tail = rev[a[i]][b[j]];
                max = Math.Max(head + C.Length + tail, max);

            }
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
public class Tester : AbstractTester
{
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
