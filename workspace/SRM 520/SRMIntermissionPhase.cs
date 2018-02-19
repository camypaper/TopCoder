using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SRMIntermissionPhase {
    public int countWays(int[] p, string[] description) {
        const long MOD = (long)1e9 + 7;
        var dp = new long[200050];
        var C = new long[1 << 3, 200050];
        C[0, 0] = 1;
        for (int i = 1; i < 1 << 3; i++) {
            int l = -1;
            if (i / 4 == 1) l = 2;
            else if ((i / 2) % 2 == 1) l = 1;
            else l = 0;
            var id = i ^ (1 << l);
            for (int j = 0; j < 200050; j++) {
                if (C[id, j] == 0) continue;
                C[i, j + 1] = (C[i, j + 1] + C[id, j]) % MOD;
                C[i, j + p[l] + 1] = (C[i, j + p[l] + 1] + 2 * MOD - C[id, j]) % MOD;
            }
            for (int j = 0; j < 200050 - 1; j++)
                C[i, j + 1] = (0L + C[i, j] + C[i, j + 1]) % MOD;

        }
        for (int i = description.Length - 1; i >= 0; i--) {
            var min = 0;
            var max = 0;
            for (int j = 1; j < 200050; j++)
                dp[j] = (dp[j] + dp[j - 1]) % MOD;
            var next = new long[200050];
            var mask = 0;
            for (int j = 0; j < 3; j++)
                if (description[i][j] == 'Y') { min++; max += p[j]; mask |= 1 << j; }
            //Debug.WriteLine($"{min} {max}");
            for (int j = min; j <= max; j++) {
                if (i == description.Length - 1) next[j] = C[mask, j];
                else if (j > 0) next[j] = dp[j - 1] * C[mask, j] % MOD;
            }
            dp = next;
        }
        Debug.WriteLine(dp.Sum() % MOD);
        return (int)(dp.Sum() % MOD);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] points, string[] description) {
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
        ManualTest(new int[] { 25000, 45000, 90000 }, new string[] { "YYY" });
        ManualTest(new int[] { 30000, 60000, 110000 }, new string[] { "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY", "YYY" });
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
