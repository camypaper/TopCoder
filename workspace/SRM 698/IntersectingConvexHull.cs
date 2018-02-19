using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Point = System.Numerics.Complex;

public class IntersectingConvexHull
{
    public int count(int[] x, int[] y)
    {
        var n = x.Length;
        var p = Enumerate(n, i => new Point(x[i], y[i]));
        ModInteger ans = 0;
        var binomial = Enumerate(n + 1, t => new ModInteger[n + 1]);
        binomial[0][0] = 1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                binomial[i + 1][j] += binomial[i][j];
                binomial[i + 1][j + 1] += binomial[i][j];
            }
        for (int i = 3; i <= n; i++)
            for (int j = 3; i + j <= n; j++)
                ans += binomial[n][i] * binomial[n - i][j];
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                var l = 0;
                var r = 0;
                for (int k = 0; k < n; k++)
                {
                    if (i == k || j == k) continue;
                    if (Geometry.CCW(p[i], p[j], p[k]) == 1) l++;
                    if (Geometry.CCW(p[i], p[j], p[k]) == -1) r++;
                }
                if (l < 2) continue;
                if (r < 2) continue;
                var c = ModInteger.Pow(2, l) - 1 - l;
                var d = ModInteger.Pow(2, r) - 1 - r;
                ans -= 2 * c * d;

            }

        return (int)ans.num;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] x, int[] y)
    {
        return 0;
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
#region Functions
static public partial class Geometry
{
    public const double EPS = 1e-8;
    static public double Cross(Point a, Point b)
    {
        return (Point.Conjugate(a) * b).Imaginary;
    }
    static public double Dot(Point a, Point b)
    {
        return (Point.Conjugate(a) * b).Real;
    }
    static public int CCW(Point a, Point b, Point c)
    {
        b -= a; c -= a;
        if (Cross(b, c) > 0) return 1;//CCW
        if (Cross(b, c) < 0) return -1;//CW
        if (Dot(b, c) < 0) return 2;//C-A-B
        if (b.Magnitude < c.Magnitude) return -2;//A-B-C
        return 0;
    }
    static public int Compare(Point a, Point b)
    {
        if (a.Real != b.Real)
            return (a.Real > b.Real) ? 1 : -1;
        else if (a.Imaginary != b.Imaginary)
            return a.Imaginary > b.Imaginary ? 1 : -1;
        return 0;
    }
    static public double Norm(Point p)
    {
        return p.Magnitude * p.Magnitude;
    }
}
#endregion

#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
    public static ModInteger Pow(ModInteger v, long k)
    {
        ModInteger ret = 1;
        var n = k;
        for (; n > 0; n >>= 1, v *= v)
        {
            if ((n & 1) == 1)
                ret = ret * v;
        }
        return ret;
    }
}
#endregion