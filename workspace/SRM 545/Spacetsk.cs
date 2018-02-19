using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Spacetsk {
    public int countsets(int L, int H, int K) {
        if (K == 1) return (L + 1) * (H + 1);
        const long MOD = (long)1e9 + 7;
        var comb = Enumerate(2050, x => new long[2050]);
        comb[0][0] = 1;
        for (int i = 0; i <= 2000; i++)
            for (int j = 0; j <= 2000; j++) {
                comb[i][j] %= MOD;
                comb[i + 1][j] += comb[i][j];
                comb[i + 1][j + 1] += comb[i][j];
            }
        long ans = 0;
        for (int dx = 0; dx <= L; dx++)
            for (int dy = 1; dy <= H; dy++) {
                if (gcd(dx, dy) != 1) continue;
                var p = 0;
                var q = 0;
                var k = 1;
                for (; ; ) {
                    if (k >= K) {
                        //Debug.WriteLine($"{p} {q}");
                        var c = comb[k - 1][K - 1];
                        c *= L - p + 1;
                        c %= MOD;
                        if (p != 0)
                            c = c * 2 % MOD;
                        ans = (ans + c) % MOD;
                    }
                    p += dx;
                    q += dy;
                    k++;
                    if (p > L || q > H) break;

                }
            }

        return (int)ans;
    }
    int gcd(int x, int y) {
        if (x == 0 || y == 0) return Math.Max(x, y);
        return gcd(y, x % y);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int L, int H, int K) {
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
        ManualTest(10, 8, 6);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
