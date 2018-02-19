using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ChocolateDividingEasy
{
    public int findBest(string[] chocolate)
    {
        int n = chocolate.Length, m = chocolate[0].Length;
        var mat = Enumerate(n, x => new int[m]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                mat[i][j] = chocolate[i][j] - '0';
        var cum = createCumulativeSum(mat);
        var max = 0;
        for (int i = 1; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                for (int l = 1; l < m; l++)
                {

                    for (int r = l + 1; r < m; r++)
                    {
                        var min = 1000000000L;
                        min = Math.Min(min, getArea(cum, 0, 0, i, l));
                        min = Math.Min(min, getArea(cum, i, 0, j, l));
                        min = Math.Min(min, getArea(cum, j, 0, n, l));
                        min = Math.Min(min, getArea(cum, 0, l, i, r));
                        min = Math.Min(min, getArea(cum, i, l, j, r));
                        min = Math.Min(min, getArea(cum, j, l, n, r));
                        min = Math.Min(min, getArea(cum, 0, r, i, m));
                        min = Math.Min(min, getArea(cum, i, r, j, m));
                        min = Math.Min(min, getArea(cum, j, r, n, m));
                        max = Math.Max(max, (int)min);
                    }
                }
            }
        return max;
    }
    #region 累積和
    static public Func<int[][], int[][]> createCumulativeSum = s =>
    {
        int n = s.Length, m = s[0].Length;
        var a = new int[n + 1][];
        for (int i = 0; i <= n; i++)
            a[i] = new int[m + 1];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                a[i + 1][j + 1] = a[i + 1][j] + a[i][j + 1] - a[i][j] + s[i][j];
        return a;
    };
    /// <summary>元のテーブルにおける[x1,x2),[y1,y2)の矩形領域に含まれる値の和を取ってくる</summary>
    static public Func<int[][], int, int, int, int, long> getArea = (a, x1, y1, x2, y2) =>
    {
        if (x1 >= x2 || y1 >= y2) throw new ArgumentException("x1<x2 && y1<y2");
        return a[x2][y2] - a[x1][y2] - a[x2][y1] + a[x1][y1];
    };
    #endregion
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
