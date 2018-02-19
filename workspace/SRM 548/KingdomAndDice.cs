using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class KingdomAndDice {
    public double newFairness(int[] firstDie, int[] secondDie, int X) {
        var n = firstDie.Length;
        Array.Sort(firstDie);
        Array.Sort(secondDie);
        var a = new int[n + 1];
        var win = 0;
        for (int i = 0; i <= n; i++) {
            //[min,max]
            var min = 0;
            if (i != 0) min = secondDie[i - 1] + 1;
            var max = X;
            if (i != n) max = secondDie[i] - 1;
            if (max < min) continue;
            a[i] += max - min + 1;
            foreach (var x in firstDie) {
                if (x == 0) continue;
                if (min <= x && x <= max) {
                    win += i;
                    a[i]--;
                }
            }
            a[i] = Math.Min(n, a[i]);
        }
        a[0] += 51;
        var K = firstDie.Count(x => x == 0);
        var dp = new ulong[2555];
        dp[win] |= 1L << 0;
        for (int i = 0; i <= n; i++) {
            for (int j = 2500; j >= 0; j--) {
                for (int k = 1; k <= a[i]; k++)
                    if (j + i * k <= 2500)
                        dp[j + i * k] |= dp[j] << k;
            }
        }
        var p = n * n + 1;
        for (int i = 0; i <= 2500; i++) {
            if ((dp[i] >> K & 1) == 1) {
                if (Math.Abs(n * n - 2 * i) < Math.Abs(n * n - 2 * p)) {
                    p = i;
                }
            }

        }

        return 1.0 * p / (n * n);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int[] firstDie, int[] secondDie, int X) {
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
        ManualTest(new int[] { 0, 0, 0, 0 }, new int[] { 5, 6, 7, 8 }, 8);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
