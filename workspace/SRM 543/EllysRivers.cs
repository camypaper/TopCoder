using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EllysRivers {
    public double getMin(int length, int walk, int[] width, int[] speed) {
        var n = width.Length;
        var iter = new int[n];
        var ans = double.MaxValue;
        for (int rem = length; rem >= 0; rem--) {
            var v = 0.0;
            for (int j = 0; j < n; j++) {
                long dx = width[j];
                long dy = iter[j];
                v += Math.Sqrt(dx * dx + dy * dy) / speed[j];
            }
            v += 1.0 * rem / walk;
            ans = Math.Min(ans, v);
            if (rem == 0) break;
            var add = double.MaxValue;
            var id = -1;
            for (int j = 0; j < n; j++) {
                long dx = width[j];
                long dy = iter[j];
                var p = Math.Sqrt(dx * dx + dy * dy) / speed[j];
                var q = Math.Sqrt(dx * dx + (dy + 1) * (dy + 1)) / speed[j];
                if (add > q - p) {
                    add = q - p;
                    id = j;
                }
            }
            iter[id]++;
        }

        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int length, int walk, int[] width, int[] speed) {
        return 0.0;
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
