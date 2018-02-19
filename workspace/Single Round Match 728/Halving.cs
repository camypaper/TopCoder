using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Halving {
    public int minSteps(int[] a) {
        var min = 10000000;
        for (int i = 0; i < 30; i++)
        {
            min = Math.Min(min, sol(i, a.ToArray()));
            Debug.WriteLine(min);
        }
        return min;
    }
    Random rnd = new Random();
    int sol(int k, int[] a) {
        var n = a.Length;
        var min = new HashSet<int>();
        var max = new HashSet<int>();
        cnt = 0;
        foreach (var x in a)
        {
            min.Add(mi(k, x));
            max.Add(ma(k, x));
        }

        if (min.Count == 1 || max.Count == 1) return cnt / 2;
        return int.MaxValue;
    }
    int cnt = 0;
    int otaku = -1;
    int mi(int k, int x) {
        var h = 0;
        for (int i = 30; i >= 0; i--)
            if ((x >> i & 1) == 1) { h = i; break; }
        var d = h - k;
        if (d < 0) return otaku--;
        cnt += d;
        var y = x >> d;
        return y;
    }
    int ma(int k, int x) {
        var h = 0;
        for (int i = 30; i >= 0; i--)
            if ((x >> i & 1) == 1) { h = i; break; }
        var d = h - k;
        if (d < 0) return otaku--;
        var y = x >> d;
        cnt += d;
        if ((x & ((1 << k) - 1)) > 0) return y | 1;
        return y;

    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] a) {
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
