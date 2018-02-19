using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MagicalGirlLevelTwoDivOne {
    public int theCount(string[] palette, int n, int m) {
        const long MOD = (long)1e9 + 7;
        var h = palette.Length;
        var w = palette[0].Length;
        var s = new DisjointSet(h * w);
        for (int i = 0; i < h; i++)
            for (int j = 0; j < w; j++) {
                if (i + n < h) s.Unite(i * w + j, (i + n) * w + j);
                if (j + m < w) s.Unite(i * w + j, i * w + j + m);
            }
        var a = new int[h * w, 3];
        for (int i = 0; i < h; i++)
            for (int j = 0; j < w; j++) {
                if (palette[i][j] == '.') a[s[i * w + j], 2]++;
                else a[s[i * w + j], (palette[i][j] - '0') % 2]++;
            }
        var pow = new long[h * w + 5, 2];
        for (int i = (int)(pow[0, 0] = pow[0, 1] = 1); i < h * w + 5; i++) {
            pow[i, 0] = pow[i - 1, 0] * 4 % MOD;
            pow[i, 1] = pow[i - 1, 1] * 5 % MOD;
        }
        var dp = new long[1 << m];
        var OK = new int[1 << m];
        for (int i = 0; i < 1 << m; i++)
            for (int j = 0; j < m; j++) if ((i >> j & 1) == 1) OK[i]++;
        dp[0] = 1;
        for (int i = 0; i < n; i++) {
            var next = new long[1 << m];
            for (int mask = 0; mask < 1 << m; mask++) {
                dp[mask] %= MOD;
                if (dp[mask] == 0) continue;
                //Debug.WriteLine($"{i} {mask} {dp[mask]}");
                for (int nmask = 0; nmask < 1 << m; nmask++) {
                    if (OK[nmask] % 2 == 0) continue;
                    var ok = true;
                    var cnt = new int[2];
                    for (int j = 0; j < m; j++) {
                        if (a[s[i * w + j], 0] > 0 && a[s[i * w + j], 1] > 0)
                            return 0;
                        if (a[s[i * w + j], (nmask >> j & 1) ^ 1] > 0) ok = false;
                        cnt[nmask >> j & 1] += a[s[i * w + j], 2];

                    }
                    if (ok) {
                        next[mask ^ nmask] += ((dp[mask] * pow[cnt[0], 0] % MOD) * pow[cnt[1], 1]) % MOD;
                    }
                }
            }
            dp = next;
        }
        return (int)(dp.Last() % MOD);
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] palette, int n, int m) {
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
        Test(Example3);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
#region DisjointSet
public class DisjointSet {
    int[] par;
    byte[] rank;
    public DisjointSet(int n) {
        par = new int[n];
        for (int i = 0; i < n; i++)
            par[i] = -1;
        rank = new byte[n];
    }
    public int this[int id] {
        get {
            if ((par[id] < 0)) return id;
            return par[id] = this[par[id]];
        }
    }
    public bool Unite(int x, int y) {
        x = this[x]; y = this[y];
        if (x == y) return false;
        if (rank[x] < rank[y]) { var z = x; x = y; y = z; }
        par[x] += par[y];
        par[y] = x;
        if (rank[x] == rank[y])
            rank[x]++;
        return true;
    }
    public int Size(int x) { return -par[this[x]]; }
    public bool IsUnited(int x, int y) { return this[x] == this[y]; }

}
#endregion