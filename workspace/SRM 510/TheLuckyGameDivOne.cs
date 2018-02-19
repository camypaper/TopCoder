using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TheLuckyGameDivOne {
    public int find(long a, long b, long jLen, long bLen) {
        var L = new List<long>();
        var xs = new List<long>(); xs.Add(a); xs.Add(a + 1);
        for (int k = 1; k <= 10; k++)
            for (int i = 0; i < 1 << k; i++) {
                var v = 0L;
                for (int j = 0; j < k; j++)
                    if ((i >> j & 1) == 0) v = v * 10 + 4;
                    else v = v * 10 + 7;
                if (a <= v && v <= b)
                    L.Add(v);
                xs.Add(v - jLen - 1);
                xs.Add(v - jLen);
                xs.Add(v - jLen - 1);
                xs.Add(v - 1);
                xs.Add(v);
                xs.Add(v + 1);
                xs.Add(v - bLen - 1);
                xs.Add(v - bLen);
                xs.Add(v - bLen + 1);
            }
        L = L.Distinct().ToList();
        L.Sort();
        xs = xs.Distinct().ToList(); xs.Sort();
        Debug.WriteLine(L.Count);
        var n = xs.Count;
        var cnt = new int[n + 1];
        for (int i = 0; i < n; i++) {
            var p = L.BinarySearch(xs[i]);
            if (p >= 0) cnt[i + 1]++;
            cnt[i + 1] += cnt[i];
        }
        var val = new int[n];
        for (int i = 0; i < n; i++) {
            var p = xs.BinarySearch(xs[i] + bLen);
            if (p < 0) p = ~p;
            val[i] = cnt[p] - cnt[i];
        }
        Debug.WriteLine(L.AsJoinedString());
        var max = 0;
        for (int i = 0; i < n; i++) {
            if (xs[i] < a) continue;
            var R = xs[i] + jLen;
            if (R > b + 1) continue;
            var mi = val[i];
            for (int j = i; j < n; j++)
                if (xs[j] + bLen <= R) mi = Math.Min(mi, val[j]);
            max = Math.Max(max, mi);
        }
        Debug.WriteLine(max);
        return max;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(long a, long b, long jLen, long bLen) {
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
        ManualTest(3434727064, 5306990644, 661022424, 577260426);
        ManualTest(4, 7, 4, 2);
        ManualTest(1, 4747, 446, 373);
        ManualTest(77, 474, 96, 65);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
