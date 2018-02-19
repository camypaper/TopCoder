using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class LongestSequence {
    public int maxLength(int[] C) {
        var q = new Queue<int>();
        var l = 0; var r = 20050;
        for (int _ = 0; _ < 20; _++) {
            var m = (l + r) / 2;
            if (f(C, m)) l = m;
            else r = m;
        }
        return l > 20000 ? -1 : l;
    }
    bool f(int[] C, int m) {
        var vis = new bool[m + 1];
        vis[0] = true;
        var q = new Queue<int>();
        q.Enqueue(0);
        while (q.Count > 0) {
            var p = q.Dequeue();
            foreach (var x in C) {
                if (p + x < 0 || p + x > m) continue;
                if (p + x == 0) return false;
                if (vis[p + x]) continue;
                vis[p + x] = true;
                q.Enqueue(p + x);
            }
        }
        return true;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] C) {
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
