using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAndFencing {
    public string WhoCanWin(int mov1, int mov2, int rng1, int rng2, int d) {
        if (mov1 + rng1 >= d) return "Ciel";
        if (mov2 + rng2 - mov1 >= d) return "Liss";
        if (mov1 < mov2) {
            if (2 * mov1 + rng1 + 1 <= mov2 + rng2) return "Liss";
            else return "Draw";
        }
        else if (mov1 == mov2) {
            return "Draw";
        }
        else {//mov1 > mov2
            if (2 * mov2 + rng2 + 1 <= mov1 + rng1) return "Ciel";
            else return "Draw";
        }
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(int mov1, int mov2, int rng1, int rng2, int d) {
        return "";
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
        Test(Example6);
        Test(Example7);
        Test(Example8);

    }
}
// CUT end
