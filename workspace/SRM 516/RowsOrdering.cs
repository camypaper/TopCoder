using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RowsOrdering {
    public int order(string[] rows) {
        var v = new Dictionary<char, int>();
        for (int i = 0; i < 26; i++) {
            v[(char)(i + 'a')] = i + 1;
            v[(char)(i + 'A')] = i + 1 + 26;
        }
        var n = rows.Length;
        var m = rows[0].Length;
        var sum = new int[m];
        for (int j = 0; j < m; j++) {
            var cnt = new int[52];
            for (int i = 0; i < n; i++)
                cnt[v[rows[i][j]]]++;
            Array.Sort(cnt); Array.Reverse(cnt);
            Debug.WriteLine(cnt.AsJoinedString());
            for (int i = 0; i < 52; i++)
                sum[j] += cnt[i] * i;
        }
        Array.Sort(sum); Array.Reverse(sum);
        Debug.WriteLine(sum.AsJoinedString());
        const long MOD = (long)1e9 + 7;
        long ans = 0;
        long C = 1;
        foreach (var x in sum) {
            ans = (ans + x * C) % MOD;
            C = (C * 50) % MOD;
        }
        ans += n;
        ans %= MOD;
        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] rows) {
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
