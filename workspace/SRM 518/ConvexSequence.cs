using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ConvexSequence {
    public long getMinimum(int[] a) {

        //satisfy
        //a[i+1] - a[i] >= a[i]-a[i-1]
        //b[i]>=b[i-1]  where b[i] = a[i+1]-a[i]
        //c[i]>=0 where c[i] >= b[i+1]-b[i]
        //operation
        //1. b[0]++//not needed
        //2. b[i]--,b[i+1]++
        //3. b[n-1]-- not needed
        //2. c[i-1]--,c[i]+=2,c[i+1]--
        var n = a.Length;
        if (n <= 2) return 0;
        var b = new long[n - 1];
        var c = new long[n - 2];
        for (int i = 0; i < n - 1; i++)
            b[i] = a[i + 1] - a[i];
        Debug.WriteLine(b.AsJoinedString());
        for (int i = 0; i < n - 2; i++)
            c[i] = b[i + 1] - b[i];
        Debug.WriteLine(c.AsJoinedString());
        Debug.WriteLine(c.Sum());
        long ans = 0;
        for (; ; ) {
            var go = false;
            //Debug.WriteLine(c.AsJoinedString());
            for (int i = 0; i < n - 2; i++) {
                if (c[i] < 0) {
                    var d = -c[i];
                    var k = (d + 1) / 2;
                    ans += k;
                    c[i] += 2 * k;
                    if (i != 0) c[i - 1] -= k;
                    if (i != n - 3) c[i + 1] -= k;
                    go = true;
                    //break;
                }
            }
            if (!go) return ans;
        }
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public long Naive_Test(int[] a) {
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
