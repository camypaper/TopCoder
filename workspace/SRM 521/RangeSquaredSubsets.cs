using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RangeSquaredSubsets {
    public long countSubsets(int nlow, int nhigh, int[] x, int[] y) {
        Array.Sort(x, y);
        var xs = x.Select(u => 1L * u).Distinct().ToList(); xs.Add(-(1L << 40)); xs.Add(1L << 40); xs.Sort();
        var ys = y.Select(u => 1L * u).Distinct().ToList(); ys.Add(-(1L << 40)); ys.Add(1L << 40); ys.Sort();
        var n = xs.Count;
        var m = ys.Count;
        Debug.WriteLine(xs.AsJoinedString());
        Debug.WriteLine(ys.AsJoinedString());
        //min,max,min,max
        var S = new HashSet<long>();
        for (int i = 1; i < n - 1; i++)
            for (int j = i; j < n - 1; j++)
                for (int k = 1; k < m - 1; k++)
                    for (int l = k; l < m - 1; l++) {
                        var max = Math.Max(xs[j] - xs[i], ys[l] - ys[k]);
                        max = Math.Max(max, nlow);
                        if (max > nhigh) continue;
                        if (xs[j + 1] - xs[i - 1] <= max) continue;
                        if (ys[l + 1] - ys[k - 1] <= max) continue;
                        var mask = 0L;
                        for (int p = 0; p < x.Length; p++) {
                            if (x[p] < xs[i] || xs[j] < x[p]) continue;
                            if (y[p] < ys[k] || ys[l] < y[p]) continue;
                            mask |= 1L << p;
                        }
                        if (mask != 0) {
                            Debug.WriteLine(mask);
                            S.Add(mask);
                        }
                    }
        return S.Count;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(int nlow, int nhigh, int[] x, int[] y) {
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

    }
}
// CUT end
