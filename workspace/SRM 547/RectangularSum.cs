using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RectangularSum {
    public long minimalArea(int height, int width, long S) {
        S *= 2;
        var ans = long.MaxValue;
        var D = new List<long>();
        for (long i = 1; i * i <= S; i++) {
            if (S % i == 0) {
                D.Add(i);
                if (i != S / i)
                    D.Add(S / i);
            }
        }
        D.Sort();
        var n = D.Count;
        for (int h = 0; h < n; h++)
            for (int hw = h; hw < n; hw++) {
                if (D[hw] % D[h] != 0) continue;
                var w = D.BinarySearch(D[hw] / D[h]);
                var ss = S / D[hw];
                ss -= width * (D[h] - 1) + D[w] - 1;
                //Debug.WriteLine($"{D[h]} {D[w]} {D[hw]} {ss}");
                if (ss < 0) continue;
                if (ss % 2 != 0) continue;
                ss /= 2;
                if (ss >= 1L * height * width) continue;
                var ph = ss / width;
                var pw = ss % width;
                if (pw + D[w] > width) continue;
                if (ph + D[h] > height) continue;
                ans = Math.Min(ans, D[hw]);

            }
        if (ans == long.MaxValue) return -1;
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(int height, int width, long S) {
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
        //ManualTest(1, 1, 963761198400, false);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
