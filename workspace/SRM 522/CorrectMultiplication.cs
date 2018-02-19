using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CorrectMultiplication {
    public long getMinimum(int a, int b, int c) {


        return f(a, b, c);
    }
    long f(long a, long b, long c) {
        var min = long.MaxValue;
        for (int _ = 0; _ < 2; _++) {
            for (int i = 1; i <= 100000; i++) {
                //
                {
                    var k = (c / i);
                    for (long kk = k - 5; kk <= k + 5; kk++) {
                        long x = kk * i;
                        if (x <= 0) continue;
                        var da = Math.Abs(a - i);
                        var dc = Math.Abs(c - x);
                        var db = Math.Abs(b - kk);
                        min = Math.Min(min, da + db + dc);
                    }
                }
                for (int j = 1; i * j <= 2000000; j++) {
                    var da = Math.Abs(a - i);
                    var db = Math.Abs(j - b);
                    var dc = Math.Abs(c - i * j);
                    min = Math.Min(min, da + db + dc);

                }
            }
            Swap(ref a, ref b);
        }
        return min;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(int a, int b, int c) {
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

    }
}
// CUT end
