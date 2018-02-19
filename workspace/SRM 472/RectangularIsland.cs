using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RectangularIsland
{
    public double theProbablity(int width, int height, int x, int y, int steps)
    {

        var p = 1.0;
        solve(width, height, x, y, steps);

        var table = new LimitedCombinationTable(steps);
        for (int w = 0; w <= steps; w++)
        {
            var h = steps - w;
            var q = (dpw[w] + dph[h] - dpw[w] * dph[h]) * table[steps, w];
            p -= q;
        }


        return p;
    }
    double[] dpw, dph;
    public void solve(int width, int height, int x, int y, int steps)
    {
        var DPW = new double[width];
        var DPH = new double[height];
        DPW[x] = DPH[y] = 1;
        dpw = new double[steps + 1];
        dph = new double[steps + 1];
        for (int i = 0; i <= steps; i++)
        {
            dpw[i] = dph[i] = 1;
            var nW = new double[width];
            for (int j = 0; j < width; j++)
            {
                var q = DPW[j];
                dpw[i] -= q;
                if (i < steps)
                {
                    if (j - 1 >= 0) nW[j - 1] += q / 2;
                    if (j + 1 < width) nW[j + 1] += q / 2;
                }
            }
            var nH = new double[height];
            for (int j = 0; j < height; j++)
            {
                var q = DPH[j];
                dph[i] -= q;
                if (i < steps)
                {
                    if (j - 1 >= 0) nH[j - 1] += q / 2;
                    if (j + 1 < height) nH[j + 1] += q / 2;
                }
            }
            DPW = nW;
            DPH = nH;
        }
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
        test.ManualTest(2, 2, 0, 1, 5);
    }
}
// CUT end

public class LimitedCombinationTable
{
    public int N;
    double[] nCr;
    //const long mod = (long)1e9;
    public LimitedCombinationTable(int n)
    {
        N = n;
        nCr = new double[n + 2];
        nCr[0] = 1;
        for (int i = 0; i < n; i++)
        {
            var next = new double[n + 2];
            for (int j = 0; j <= i; j++)
            {
                next[j] += nCr[j] / 2.0;
                next[j + 1] += nCr[j] / 2.0;
            }
            nCr = next;
        }
    }
    public double this[int n, int r]
    {
        get
        {
            if (n != N) throw new Exception();
            if (r < 0 || r > N) return 0;
            return nCr[r];
        }
    }

}