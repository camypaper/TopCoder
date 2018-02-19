using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PlusSign
{
    public int draw(string[] pixels)
    {
        var n = pixels.Length;
        var m = pixels[0].Length;
        var A = Enumerate(n + 1, x => new int[m + 1]);
        var B = Enumerate(n + 1, x => new int[m + 1]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                A[i + 1][j + 1] = A[i + 1][j] + A[i][j + 1] - A[i][j];
                B[i + 1][j + 1] = B[i + 1][j] + B[i][j + 1] - B[i][j];
                if (pixels[i][j] == '#') A[i + 1][j + 1]++;
                else B[i + 1][j + 1]++;
            }
        Func<int[][], int, int, int, int, int> get = (a, x, y, X, Y) =>
                {
                    if (x >= X || y >= Y) return 0;
                    return a[X][Y] - a[x][Y] - a[X][y] + a[x][y];
                };
        var min = 1000000000;
        var u = get(A, 0, 0, n, m);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                for (int L = 3; ; L += 2)
                {
                    if (i + L > n || j + L > m) break;
                    for (int l = 1; l * 2 < L; l++)
                    {
                        var all = get(A, i, j, i + L, j + L);
                        var p = get(B, i, j, i + l, j + l);
                        var q = get(B, i + L - l, j + L - l, i + L, j + L);
                        var r = get(B, i + L - l, j, i + L, j + l);
                        var s = get(B, i, j + L - l, i + l, j + L);
                        if (p != l * l || q != l * l || r != l * l || s != l * l) continue;
                        if (all != u) continue;
                        var val = L * L - all - 4 * l * l;
                        Debug.WriteLine("{0} {1} {2} {3}", i, j, L, l);
                        min = Math.Min(min, val);
                    }
                }

            }

        return min == 1000000000 ? -1 : min;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] pixels)
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
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);

    }
}
// CUT end
