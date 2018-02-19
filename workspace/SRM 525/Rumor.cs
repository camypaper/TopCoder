using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Rumor {
    public int getMinimum(string knowledge, string[] graph) {
        var n = knowledge.Length;
        var g = new int[n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (graph[i][j] == 'Y')
                    g[i] |= 1 << j;
        var mask = 0;
        var all = (1 << n) - 1;
        for (int i = 0; i < n; i++)
            if (knowledge[i] == 'Y') mask |= 1 << i;
        var min = 100000;
        for (int pri = 0; pri < 1 << n; pri++) {
            var a = mask;
            var b = mask;
            var go = new int[n];
            for (int d = 0; d < 50; d++) {
                if (a == all && b == all)
                    min = Math.Min(min, d);
                var na = a;
                var nb = b;
                for (int i = 0; i < n; i++) {
                    var nna = a;
                    if ((a >> i & 1) == 1) nna |= g[i];
                    var nnb = b;
                    if ((b >> i & 1) == 1) nnb |= g[i];
                    if (a == nna) nb |= nnb;
                    else if (b == nnb) na |= nna;
                    else if ((pri >> i & 1) == 0) na |= nna;
                    else nb |= nnb;
                }
                a = na;
                b = nb;
            }
        }
        return min >= 100000 ? -1 : min;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string knowledge, string[] graph) {
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
        Test(Example5);

    }
}
// CUT end
