using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GogoXMarisaKirisima {
    public int solve(string[] choices) {
        var n = choices.Length;
        var g = Enumerate(n, x => new bool[n]);
        for (int i = 0; i < n; i++)
            g[i][i] = true;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                g[i][j] |= choices[i][j] == 'Y';
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    g[i][j] |= g[i][k] & g[k][j];
        if (!g[0][n - 1]) return 0;
        var ans = 2;
        for (int i = 0; i < n; i++) {
            if (g[0][i] && g[i][n - 1]) {
                ans--;
                for (int j = 0; j < n; j++)
                    if (choices[i][j] == 'Y' && g[j][n - 1]) {
                        //Debug.WriteLine($"{i} {j}");
                        ans++;
                    }
            }
        }
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] choices) {
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
