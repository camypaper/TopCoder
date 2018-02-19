using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using SB = System.Text.StringBuilder;
public class SoManyRectangles {
    public int maxOverlap(int[] x1, int[] y1, int[] x2, int[] y2) {
        var xs = x1.Concat(x2).Distinct().ToList(); xs.Sort();
        var ys = y1.Concat(y2).Distinct().ToList(); ys.Sort();
        var n = xs.Count;
        var m = ys.Count;

        var a = Enumerate(n, x => new int[m]);

        for (int i = 0; i < x1.Length; i++)
        {
            x1[i] = xs.BinarySearch(x1[i]);
            x2[i] = xs.BinarySearch(x2[i]);
            y1[i] = ys.BinarySearch(y1[i]);
            y2[i] = ys.BinarySearch(y2[i]);
            a[x1[i]][y1[i]]++;
            a[x1[i]][y2[i]]--;
            a[x2[i]][y1[i]]--;
            a[x2[i]][y2[i]]++;
        }
        for (int i = 0; i < n; i++)
            for (int j = 1; j < m; j++)
                a[i][j] += a[i][j - 1];
        for (int j = 0; j < m; j++)
            for (int i = 1; i < n; i++)
                a[i][j] += a[i - 1][j];
        var max = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                max = Math.Max(max, a[i][j]);
        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] x1, int[] y1, int[] x2, int[] y2) {
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

    public override void Run() {

        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
