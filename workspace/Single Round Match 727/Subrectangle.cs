using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Subrectangle {
    public int minMissed(string S) {
        if (S == "" || S.Distinct().Count() == 1) return 0;
        var A = new List<int[]>();
        foreach (var x in S) {
            var v = x == '.' ? 0 : 1;
            if (A.Count == 0) A.Add(new int[] { v, 1 });
            else {
                if (A[A.Count - 1][0] == v) A[A.Count - 1][1]++;
                else A.Add(new int[] { v, 1 });
            }
        }
        foreach (var x in A) Debug.WriteLine(x.AsJoinedString());
        var u = 0;
        for (int i = 0; i <= 300; i++)
            for (int j = 1; j <= 300; j++)
                for (int k = 0; i + j + k <= 300; k++) {
                    for (int l = 0; l < 300; l++)
                        u++;
                }
        Debug.WriteLine(u * 300);
        return 0;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string S) {
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
        Test(Example6);
        Test(Example7);

    }
}
// CUT end
