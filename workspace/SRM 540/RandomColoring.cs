using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RandomColoring {
    public double getProbability(int N, int R, int G, int B, int sR, int sG, int sB, int d1, int d2) {
        var P = new double[55, 55, 55];
        P[sR, sG, sB] = 1;
        d1--;

        for (int _ = 0; _ < N - 1; _++) {
            Q = new double[55, 55, 55];
            for (int i = 0; i < R; i++)
                for (int j = 0; j < G; j++)
                    for (int k = 0; k < B; k++) {
                        if (P[i, j, k] == 0) continue;
                        var x = Math.Min(i + d2, R - 1) - Math.Max(i - d2, 0) + 1;
                        var y = Math.Min(j + d2, G - 1) - Math.Max(j - d2, 0) + 1;
                        var z = Math.Min(k + d2, B - 1) - Math.Max(k - d2, 0) + 1;
                        var C = x * y * z;
                        if (d1 >= 0) {
                            x = Math.Min(i + d1, R - 1) - Math.Max(i - d1, 0) + 1;
                            y = Math.Min(j + d1, G - 1) - Math.Max(j - d1, 0) + 1;
                            z = Math.Min(k + d1, B - 1) - Math.Max(k - d1, 0) + 1;
                            C -= x * y * z;
                            if (C == 0) continue;
                            add(-P[i, j, k] / C, i, j, k, d1, R, G, B);
                        }
                        if (C == 0) continue;
                        add(P[i, j, k] / C, i, j, k, d2, R, G, B);
                    }
            for (int k = 0; k < 52; k++)
                for (int j = 0; j < 52; j++)
                    for (int i = 0; i < 52; i++)
                        Q[i + 1, j, k] += Q[i, j, k];
            for (int k = 0; k < 52; k++)
                for (int i = 0; i < 52; i++)
                    for (int j = 0; j < 52; j++)
                        Q[i, j + 1, k] += Q[i, j, k];
            for (int i = 0; i < 52; i++)
                for (int j = 0; j < 52; j++)
                    for (int k = 0; k < 52; k++)
                        Q[i, j, k + 1] += Q[i, j, k];
            var sum = 0.0;
            for (int i = 0; i < 55; i++)
                for (int j = 0; j < 55; j++)
                    for (int k = 0; k < 55; k++) {
                        if (Q[i, j, k] == 0) continue;
                        //Debug.WriteLine($"{i} {j} {k} {Q[i, j, k]}");
                        sum += Q[i, j, k];
                    }
            Debug.WriteLine(sum);
            P = Q;

        }
        var p = 0.0;
        for (int i = 0; i < R; i++)
            for (int j = 0; j < G; j++)
                for (int k = 0; k < B; k++) {
                    if (P[i, j, k] == 0) continue;
                    var dx = Math.Abs(i - sR);
                    var dy = Math.Abs(j - sG);
                    var dz = Math.Abs(k - sB);
                    if (dx > d2 || dy > d2 || dz > d2) p += P[i, j, k];
                    if (dx <= d1 && dy <= d1 && dz <= d1) p += P[i, j, k];

                }

        return p;
    }
    double[,,] Q;
    void add(double p, int i, int j, int k, int d, int R, int G, int B) {
        var li = Math.Max(0, i - d);
        var ri = Math.Min(R - 1, i + d);
        var lj = Math.Max(0, j - d);
        var rj = Math.Min(G - 1, j + d);
        var lk = Math.Max(0, k - d);
        var rk = Math.Min(B - 1, k + d);
        Q[li, lj, lk] += p;
        Q[ri + 1, lj, lk] -= p;
        Q[li, rj + 1, lk] -= p;
        Q[ri + 1, rj + 1, lk] += p;

        Q[li, lj, rk + 1] -= p;
        Q[ri + 1, lj, rk + 1] += p;
        Q[li, rj + 1, rk + 1] += p;
        Q[ri + 1, rj + 1, rk + 1] -= p;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int N, int maxR, int maxG, int maxB, int startR, int startG, int startB, int d1, int d2) {
        return 0.0;
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
        Test(Example4);
        Test(Example5);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
