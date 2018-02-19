using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FractalPicture
{
    public double getLength(int x1, int y1, int x2, int y2)
    {
        final = new double[550];
        final[0] = 81 * 2 / 3;
        for (int i = 1; i < 500; i++)
            final[i] = final[i - 1] * 1 / 3;
        forest = new double[550];
        forest[499] = final[499] * 1.5;
        for (int i = 500 - 2; i >= 0; i--)
        {
            forest[i] = final[i] + 3 * forest[i + 1];

        }
        return f(0, x1, y1, x2, y2);
    }
    double[] final, forest;
    double f(int t, double x1, double y1, double x2, double y2)
    {
        if (t == 500) return 0;
        x1 = Math.Max(-10000, Math.Min(10000, x1));
        x2 = Math.Max(-10000, Math.Min(10000, x2));
        y1 = Math.Max(-10000, Math.Min(10000, y1));
        y2 = Math.Max(-10000, Math.Min(10000, y2));
        if (x2 < -27 || 27 < x1) return 0;
        if (y2 < 0 || 81 < y1) return 0;
        if (x1 <= -27 && x2 <= 27 && y1 <= 0 && 81 <= y2) return forest[t];
        var ret = 0.0;
        if (x1 <= -27 && x2 <= 27) ret += Math.Max(0, Math.Min(54, y2) - Math.Max(0, y1)) * final[t] / 54;
        ret += f(t + 1, x1 * 3, (y1 - 54) * 3, x2 * 3, (y2 - 54) * 3);
        ret += f(t + 1, (y1 - 54) * 3, -x2 * 3, (y2 - 54) * 3, -x1 * 3);
        ret += f(t + 1, (54 - y2) * 3, x1 * 3, (54 - y1) * 3, x2 * 3);
        return ret;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int x1, int y1, int x2, int y2)
    {
        return 0.0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);

    }
}
// CUT end
