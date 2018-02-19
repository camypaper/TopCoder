using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FindPolygons {
    public double minimumPolygon(int L) {
        if (L <= 2) return -1;
        var S = Enumerate(L + 2, x => new List<KeyValuePair<int, int>>());
        for (int i = 1; i <= L; i++)
            for (int j = 1; j <= L; j++) {
                var d = i * i + j * j;
                var dd = (int)Math.Sqrt(d);
                if (dd * dd != d) continue;
                if (dd <= L) S[dd].Add(new KeyValuePair<int, int>(i, j));
            }
        var min = double.MaxValue;
        for (int i = 1; i <= L; i++)
            for (int j = i; j <= L; j++) {
                if (i + j > L) break;
                var rem = L - i - j;
                var ma = Math.Max(j, rem);
                var mi = Math.Min(i, rem);
                rem *= rem;
                foreach (var pp in S[i])
                    foreach (var p in S[j]) {
                        var px = p.Key;
                        var py = p.Value;
                        if (px * pp.Key + py * pp.Value != i * j) {
                            var qx = pp.Key - px;
                            var qy = pp.Value - py;
                            if (rem == qx * qx + qy * qy) {
                                min = Math.Min(min, ma - mi);
                            }

                        }
                        {
                            var qx = pp.Key + px;
                            var qy = pp.Value - py;
                            if (rem == qx * qx + qy * qy) {
                                min = Math.Min(min, ma - mi);
                            }

                        }
                    }
                foreach (var p in S[j]) {
                    var px = p.Key;
                    var py = p.Value;
                    {
                        var qx = px - i;
                        var qy = py;
                        if (rem == qx * qx + qy * qy) {
                            min = Math.Min(min, ma - mi);
                        }

                    }
                    {
                        var qx = px + i;
                        var qy = py;
                        if (rem == qx * qx + qy * qy) {
                            min = Math.Min(min, ma - mi);
                        }

                    }
                }
            }
        if (L % 2 == 0 && min == double.MaxValue) {
            for (int i = 1; i <= L / 2; i++) {
                var l = i * 2;
                var rem = L - l;
                if (rem < 0) break;
                rem /= 2;
                min = Math.Min(min, Math.Abs(i - rem));

            }
        }
        if (min == double.MaxValue) return -1;
        return min;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int L) {
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
        Test(Example2);
        Test(Example0);
        Test(Example1);
        Test(Example3);

    }
}
// CUT end
