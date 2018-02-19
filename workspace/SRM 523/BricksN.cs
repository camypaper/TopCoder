using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BricksN {
    public int countStructures(int W, int H, int K) {
        const long MOD = (long)1e9 + 7;
        var s = new long[W + 1];
        s[0] = 1;
        for (int i = 0; i < W; i++)
            for (int j = 1; j <= K; j++)
                if (i + j <= W) s[i + j] = (s[i] + s[i + j]) % MOD;
        Debug.WriteLine(s.AsJoinedString());
        //dp[h,w] =just height,maximum w, pat
        var dp = new long[H + 1, W + 1];
        for (int i = 0; i <= H; i++)
            for (int j = 0; j <= W; j++)
                dp[i, j] = -1;
        Func<int, int, long> dfs = null;
        dfs = (h, w) => {
            if (h == 0) return 1;
            if (w == 0) return 0;
            if (dp[h, w] != -1) return dp[h, w];
            long ret = dfs(h, w - 1);//pass
            ret += s[w] * dfs(h - 1, w);//all
            for (int k = 1; k < w; k++) {
                for (int hh = 0; hh < h; hh++)
                    for (int hi = 0; hi <= h; hi++) {
                        var a = dfs(hh, k) * s[k] % MOD;
                        var b = dfs(hi, w - k - 1);
                        if (hh != h - 1 && hi != h) continue;
                        ret += (a * b) % MOD;
                    }
            }
            ret %= MOD;



            return dp[h, w] = ret;
        };
        var ans = 0L;
        for (int i = 0; i <= H; i++)
            ans += dfs(i, W);

        return (int)(ans % MOD);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int w, int h, int k) {
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

    }
}
// CUT end
