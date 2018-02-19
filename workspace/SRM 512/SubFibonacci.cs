using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SubFibonacci {
    public int maxElements(int[] a) {
        var n = a.Length;
        if (n <= 4) return n;
        Array.Sort(a);
        var fib = new long[55, 2];
        fib[0, 0] = 1;
        fib[1, 1] = 1;
        for (int i = 2; i < 55; i++) {
            fib[i, 0] += fib[i - 1, 0] + fib[i - 2, 0];
            fib[i, 1] += fib[i - 1, 1] + fib[i - 2, 1];
        }
        //f_0 = a[i]
        var A = new HashSet<long>();
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                for (int k = 1; k < 50; k++) {
                    long p = a[i];
                    if (p * fib[k, 0] >= a[j]) continue;
                    long q = (a[j] - p * fib[k, 0]);
                    if (q % fib[k, 1] != 0) continue;
                    q /= fib[k, 1];
                    var mask = 0L;
                    mask |= 1L << i;
                    mask |= 1L << j;
                    for (int l = 2; l < 50; l++) {
                        var pq = p * fib[l, 0] + q * fib[l, 1];
                        if (pq > 100000000) break;
                        var id = Array.BinarySearch(a, (int)pq);
                        if (id >= 0) mask |= 1L << id;
                    }
                    A.Add(mask);
                }
        Debug.WriteLine(A.Count);
        var L = new int[n];
        var R = new int[n];
        foreach (var x in A) {
            var v = 0;
            for (int i = 0; i < n; i++)
                if ((x >> i & 1) == 1) v++;
            for (int i = 0, u = 0; i < n; i++) {
                if ((x >> i & 1) == 1) u++;
                L[i] = Math.Max(L[i], u);
                R[i] = Math.Max(R[i], v - u);
            }
        }
        var max = 0;
        for (int i = 0; i < n; i++)
            max = Math.Max(max, L[i] + R[i]);
        Debug.WriteLine(max);
        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] S) {
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
        ManualTest(new int[] { 999221, 999233, 999239, 999269, 999287, 999307, 999329, 999331, 999359, 999371, 999377, 999389, 999431, 999433, 999437, 999451, 999491, 999499, 999521, 999529, 999541, 999553, 999563, 999599, 999611, 999613, 999623, 999631, 999653, 999667, 999671, 999683, 999721, 999727, 999749, 999763, 999769, 999773, 999809, 999853, 999863, 999883, 999907, 999917, 999931, 999953, 999959, 999961, 999979, 999983 });
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
