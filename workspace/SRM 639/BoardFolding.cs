using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BoardFolding
{
    public int howMany(int n, int m, string[] compressedPaper)
    {
        var a = Enumerate(n, x => new int[m]);
        var b = Enumerate(m, x => new int[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                var x = 0;
                var y = compressedPaper[i][j / 6];
                if (char.IsDigit(y))
                    x = compressedPaper[i][j / 6] - '0';
                else if (y == '#') x = 62;
                else if (y == '@') x = 63;
                else if (char.IsLower(y)) x = 10 + y - 'a';
                else x = 36 + y - 'A';

                x >>= (j % 6);
                x %= 2;
                a[i][j] = b[j][i] = x;
            }
        var p = f(a);
        var q = f(b);
        return p * q;
    }
    int f(int[][] a)
    {
        foreach (var x in a)
            Debug.WriteLine(x.AsJoinedString());
        var n = a.Length;
        var m = a[0].Length;
        var same = Enumerate(m, x => new bool[m]);
        for (int i = 0; i < m; i++)
            for (int j = i + 1; j < m; j++)
            {
                same[i][j] = true;
                for (int k = 0; k < n; k++)
                    same[i][j] &= a[k][i] == a[k][j];
            }
        var dp = Enumerate(m, x => new bool[m]);
        dp[0][m - 1] = true;
        var ret = 1;
        for (int len = m - 1; len >= 1; len--)
        {
            for (int l = 0; l < m; l++)
            {
                var r = l + len - 1;
                if (r >= m) continue;
                dp[l][r] = false;
                for (int x = l - 1; x >= 0 && !dp[l][r]; x--)
                {
                    if (l - x > r - l + 1) break;
                    if (!same[x][l + (l - x - 1)]) break;
                    dp[l][r] |= dp[x][r];
                }
                for (int x = r + 1; x < m && !dp[l][r]; x++)
                {
                    if (x - r > r - l + 1) break;
                    if (!same[r - (x - r - 1)][x]) break;
                    dp[l][r] |= dp[l][x];
                }
                if (dp[l][r]) ret++;
            }
        }
        return ret;


    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int N, int M, string[] compressedPaper)
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
        var n = 64;
        var m = 64;
        var s = new string[] { "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6", "mCmqmCCBmC6", "FpFBFppqFp9", "mCmqmCCBmC6", "FpFBFppqFp9", "FpFBFppqFp9", "mCmqmCCBmC6" };
        //Tests.Add(() => ManualTest(n, m, s));
    }
}
// CUT end
