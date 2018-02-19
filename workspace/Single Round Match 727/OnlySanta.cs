using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class OnlySanta {
    public string solve(string S) {
        var p = 0;
        var s = "SATAN&";
        var SB = new StringBuilder();

        foreach (var x in S) {
            if (x == s[p]) {
                p++;
                if (p == 3) SB.Append("N");
            }
            SB.Append(x);
        }
        Debug.WriteLine(p);
        if (p == 0) { SB.Append("SANTA"); }
        else if (p == 1) { SB.Append("ANTA"); }
        else if (p == 2) { SB.Append("NTA"); }
        else if (p == 3) SB.Append("A");

        if (!check(Naive_Test(S))) {
            Debug.WriteLine("otak");
        }

        return SB.ToString();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(string s) {
        var n = s.Length;
        var dp = Enumerate(1010, x => new int[5]);
        for (int i = n - 1; i >= 0; i--) {
            for (int j = 0; j < 5; j++)
                dp[i][j] = dp[i + 1][j];
            if (s[i] == 'A') {
                dp[i][0] = Math.Max(dp[i][0], 1);
                dp[i][0] = Math.Max(dp[i][0], 1 + dp[i + 1][1]);
            }
            if (s[i] == 'T') dp[i][1] = 1;
            if (s[i] == 'S') {
                dp[i][2] = Math.Max(dp[i][2], 1);
                dp[i][2] = Math.Max(dp[i][2], 1 + dp[i + 1][0]);
            }

        }
        if (dp[0][2] < 3) {
            {
                Debug.WriteLine(s + "SANTA");
                return s + "SANTA";
            }
        }
        {
            var j = -1;
            for (int i = n - 1; i >= 0; i--) {
                if (s[i] == 'A') {
                    if (dp[i][0] >= 2) {
                        j = i; break;
                    }
                }
            }
            var ans = "";
            for (int i = 0; i < n; i++) {
                ans += s[i];
                if (i == j) ans += "N";
            }
            ans += "A";
            Debug.WriteLine(ans);
            return ans;
        }
    }
    public bool check(string s) {
        var P = "SATAN&";
        var Q = "SANTA&";
        var p = 0;
        var q = 0;
        foreach (var x in s) {
            if (x == P[p]) p++;
            if (x == Q[q]) q++;
        }
        return s.Length < 1050 && p < 5 && q == 5;

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
        ManualTest("NSATASATASATA", false);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);
        Test(Example6);
        Test(Example7);

    }
}
// CUT end
