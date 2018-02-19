using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ThreePoints
{
    public long countColoring(int N, int xzero, int xmul, int xadd, int xmod, int yzero, int ymul, int yadd, int ymod)
    {
        var X = new long[N];
        var Y = new long[N];
        X[0] = xzero;
        Y[0] = yzero;
        for (int i = 1; i < N; i++)
        {
            X[i] = (X[i - 1] * xmul + xadd) % xmod;
            Y[i] = (Y[i - 1] * ymul + yadd) % ymod;
        }
        var ans = solve(N, X, Y);
        return ans;
    }
    public long solve(int n, long[] X, long[] Y)
    {
        const int SZ = 548;
        var xs = X.ToList();
        xs.Sort();
        var ys = Y.ToList();
        ys.Sort();
        for (int i = 0; i < n; i++)
        {
            X[i] = xs.BinarySearch(X[i]);
            Y[i] = ys.BinarySearch(Y[i]);
        }
        Array.Sort(X, Y);

        var L = Enumerate(SZ, x => new int[SZ]);
        var R = Enumerate(SZ, x => new int[SZ]);
        var LIN = new int[SZ];
        var RIN = new int[SZ];
        var IN = new int[SZ];
        for (int i = 0; i < n; i++)
        {
            var x = Y[i] / SZ;
            var y = Y[i] % SZ;
            R[x][y]++;
            RIN[x]++;
        }
        long ans = 0;
        for (int i = 0; i < n; i++)
        {
            var x = Y[i] / SZ;
            var y = Y[i] % SZ;
            {
                R[x][y]--;
                RIN[x]--;
                var u = 0;
                var v = 0;
                for (int p = 0; p < SZ; p++)
                {
                    v += u * R[x][y];
                    u += L[x][p];
                }
                IN[x] = v;
            }

            {
                long val = 0;
                long cnt = 0;
                for (int p = 0; p < x; p++)
                {
                    val += cnt * RIN[p];
                    val += IN[p];
                    cnt += LIN[p];
                }
                for (int p = 0; p < y; p++)
                {
                    val += cnt * R[x][p];
                    cnt += L[x][p];
                }
                ans += val;
            }

            {
                LIN[x]++;
                L[x][y]++;
                var u = 0;
                var v = 0;
                for (int p = 0; p < SZ; p++)
                {
                    v += u * R[x][p];
                    u += L[x][p];
                }
                IN[x] = v;
            }
        }

        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
