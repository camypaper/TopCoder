using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndFlowerShopDivOne {
    public int theMaxFlowers(string[] flowers, int maxDiff) {
        var n = flowers.Length;
        var m = flowers[0].Length;

        var a = Enumerate(n, x => new char[m]);
        var b = Enumerate(m, x => new char[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                a[i][j] = b[j][i] = flowers[i][j];
        return Math.Max(f(a, maxDiff), f(b, maxDiff));
    }
    int f(char[][] a, int d) {
        var n = a.Length;
        var m = a[0].Length;
        const int X = 950;
        var DP = Enumerate(n, x => new int[1900]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < 1900; j++)
                DP[i][j] = -1 << 24;

        var A = Enumerate(n + 1, x => new int[m + 1]);
        var B = Enumerate(n + 1, x => new int[m + 1]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++) {
                A[i + 1][j + 1] = A[i + 1][j] + A[i][j + 1] - A[i][j];
                B[i + 1][j + 1] = B[i + 1][j] + B[i][j + 1] - B[i][j];
                if (a[i][j] == 'L') A[i + 1][j + 1]++;
                else if (a[i][j] == 'P') B[i + 1][j + 1]++;
            }
        Func<int[][], int, int, int, int, int> g = (sum, l, r, t, b) => {
            if (l > r || t > b) return 0;
            return sum[r][b] - sum[l][b] - sum[r][t] + sum[l][t];
        };
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                for (int ii = i; ii < n; ii++)
                    for (int jj = j; jj < m; jj++) {
                        var x = g(A, i, ii + 1, j, jj + 1);
                        var y = g(B, i, ii + 1, j, jj + 1);
                        DP[ii][X + x - y] = Math.Max(DP[ii][X + x - y], x + y);
                    }
            var max = -1;
        for (int i = 1; i < n; i++) {

            var EP = Enumerate(1900, x => -1 << 26);
            for (int x = 50; x <= 1850; x++)
                for (int y = 50; y <= 1850; y++) {
                    if (Math.Abs(x - X + y - X) > d) continue;
                    EP[y] = Math.Max(EP[y], DP[i - 1][x]);
                }

            for (int j = 0; j < m; j++)
                for (int ii = i; ii < n; ii++)
                    for (int jj = j; jj < m; jj++) {
                        var x = g(A, i, ii + 1, j, jj + 1);
                        var y = g(B, i, ii + 1, j, jj + 1);
                        max = Math.Max(max, x + y + EP[X + x - y]);
                    }
            for (int j = 0; j < 1900; j++)
                DP[i][j] = Math.Max(DP[i][j], DP[i - 1][j]);
        }
        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] flowers, int maxDiff) {
        return 0;
    }

    // CUT end
}
static public class EnumerableEX {
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester {
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run() {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
