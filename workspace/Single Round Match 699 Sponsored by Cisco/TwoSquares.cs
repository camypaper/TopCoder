using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TwoSquares
{
    public int maxOnes(string[] t)
    {
        var sum = t.SelectMany(x => x).Count(x => x == '1');
        var n = t.Length;
        var a = Enumerate(n, x => new int[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                a[i][j] = t[i][j] - '0';
        return sum + get(n, a);
    }
    int get(int n, int[][] a)
    {
        var A = createCumulativeSum(a);
        var L = new int[n + 1];
        var R = new int[n + 1];
        var T = new int[n + 1];
        var B = new int[n + 1];

        var TL = Enumerate(n, x => Enumerate(n, y => new int[n + 1]));
        var BR = Enumerate(n, x => Enumerate(n, y => new int[n + 1]));
        int max = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if (i + k > n || j + k > n) break;
                    var size = k * k;
                    var val = getArea(A, i, j, i + k, j + k);
                    var gain = size - 2 * val;
                    max = Math.Max(max, gain);
                    L[j] = Math.Max(L[j], gain);
                    R[j + k - 1] = Math.Max(R[j + k - 1], gain);
                    T[i] = Math.Max(T[i], gain);
                    B[i + k - 1] = Math.Max(B[i + k - 1], gain);
                    TL[i][j][k] = Math.Max(TL[i][j][k], gain);
                    BR[i + k - 1][j + k - 1][k] = Math.Max(BR[i + k - 1][j + k - 1][k], gain);
                }
            }
        for (int i = 0; i < n; i++)
        {
            var l = R[i]; var r = L[i + 1];
            max = Math.Max(max, l + r);
            var t = B[i]; var b = T[i + 1];
            max = Math.Max(max, t + b);
        }
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = n - 1; k >= 0; k--)
                {
                    TL[i][j][k] = Math.Max(TL[i][j][k], TL[i][j][k + 1]);
                    BR[i][j][k] = Math.Max(BR[i][j][k], BR[i][j][k + 1]);
                }

        for (int i = 0; i < n; i++)
            for (int x = i; x < n; x++)
                for (int j = 0; j < n; j++)
                    for (int y = j; y < n; y++)
                    {
                        var dx = x - i + 1;
                        var dy = y - j + 1;
                        var d = Math.Max(dx, dy);
                        var size = dx * dy;
                        var val = getArea(A, i, j, x + 1, y + 1);
                        var gain = size - 2 * val;

                        var tl = TL[i][j][d] - gain;
                        var br = BR[x][y][d] - gain;
                        max = Math.Max(max, tl + br);
                        if (tl + br == 6)
                        {

                        }
                    }


        return max;
    }
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
    static public Func<int[][], int, int, int, int, int> getArea = (a, x1, y1, x2, y2) =>
    {
        if (x1 >= x2 || y1 >= y2) throw new ArgumentException("x1<x2 && y1<y2");
        return a[x2][y2] - a[x1][y2] - a[x2][y1] + a[x1][y1];
    };

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] t)
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
