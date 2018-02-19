using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MinskyMystery {
    public int computeAnswer(long N) {
        if (N <= 1) return -1;
        const long MOD = (long)1e9 + 9;
        var div = N;
        for (int i = 2; i < 1000050; i++)
            if (div % i == 0) { div = i; break; }

        var ans = (4 * N % MOD) * ((div - 1) % MOD) % MOD;
        for (long i = 2; i <= div;) {
            var k = (N + i - 1) / i;
            var l = i; var r = div + 1;
            while (r - l > 1) {
                var m = (l + r) / 2;
                if ((N + m - 1) / m == k) l = m;
                else r = m;
            }
            k %= MOD;
            var len = (r - i) % MOD;
            ans += (len * k) % MOD;
            i = r;
        }
        ans = (ans + div) % MOD;
        ans = (ans + MOD - (N % MOD)) % MOD;
        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(long N) {
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
        for (int i = 2; i < 10000; i++)
            ManualTest(i);
        //ManualTest(199);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
