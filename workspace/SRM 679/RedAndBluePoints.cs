using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Point = System.Numerics.Complex;
public class RedAndBluePoints
{
    public int find(int[] blueX, int[] blueY, int[] redX, int[] redY)
    {
        var n = blueX.Length;
        var m = redX.Length;
        var P = new Point[n];
        var Q = new Point[m];
        for (int i = 0; i < n; i++)
            P[i] = new Point(blueX[i], blueY[i]);
        for (int i = 0; i < m; i++)
            Q[i] = new Point(redX[i], redY[i]);
        return f(P, Q);
    }
    int f(Point[] P, Point[] Q)
    {
        var max = 0;
        var cnt = new int[P.Length + Q.Length, P.Length + Q.Length, P.Length + Q.Length];
        for (int i = 0; i < P.Length + Q.Length; i++)
        {
            for (int j = i + 1; j < P.Length + Q.Length; j++)
            {
                for (int k = j + 1; k < P.Length + Q.Length; k++)
                {
                    var p = new Point[3];
                    p[0] = i < P.Length ? P[i] : Q[i - P.Length];
                    p[1] = j < P.Length ? P[j] : Q[j - P.Length];
                    p[2] = k < P.Length ? P[k] : Q[k - P.Length];
                    if (Geometry.CCW(p[0], p[1], p[2]) == -1)
                        Swap(ref p[1], ref p[2]);
                    int x = 0;
                    for (int q = 0; q < Q.Length; q++)
                    {
                        if (Geometry.Contains(p, Q[q]) == State.IN) { x = -100000; break; }
                    }
                    if (x >= 0)
                    {
                        for (int q = 0; q < P.Length; q++)
                            if (Geometry.Contains(p, P[q]) == State.IN) x++;

                    }

                    cnt[i, j, k] = cnt[i, k, j] = cnt[j, i, k] = cnt[j, k, i] = cnt[k, i, j] = cnt[k, j, i] = x;
                }
            }
        }
        for (int id = 0; id < P.Length; id++)
        {
            var R = new List<P>();
            for (int j = 0; j < P.Length; j++)
            {
                if (id != j) R.Add(new P(P[j] - P[id], true, j));
            }
            for (int j = 0; j < Q.Length; j++)
            {
                R.Add(new P(P[j] - P[id], false, P.Length + j));
            }
            R.Sort((l, r) => l.p.Phase.CompareTo(r.p.Phase));
            var n = R.Count;
            for (int i = 0; i < n; i++)
            {
                var dp = new int[n + 1];
                for (int j = 0; j < n + 1; j++)
                    dp[j] = -1000000;
                dp[0] = 0;
                for (int y = 1; y <= n; y++)
                {
                    for (int x = 0; x < y; x++)
                    {
                        var add = cnt[id, R[(x + i) % n].id, R[(y + i) % n].id];
                        dp[y] = Math.Max(dp[y], add + dp[x]);
                    }
                    if (R[(y + i) % n].Blue) dp[y]++;
                }
                max = Math.Max(max, dp[n]);
            }

        }
        return max + 1;
    }



    struct P
    {
        public Point p;
        public int id;
        public bool Blue;
        public P(Point point, bool blue, int i) : this()
        {
            p = point;
            Blue = blue;
            id = i;
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
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
#region Contains
static public partial class Geometry
{
    static public State Contains(Point[] P, Point p)
    {
        bool con = false;
        for (int i = 0; i < P.Length; i++)
        {
            var a = P[i] - p;
            var b = P[(i + 1) % P.Length] - p;
            if (a.Imaginary > b.Imaginary) { var tmp = b; b = a; a = tmp; }
            if (a.Imaginary <= 0 && 0 < b.Imaginary) if (Cross(a, b) < 0) con ^= true;
            if (Cross(a, b) == 0 && Dot(a, b) <= 0) return State.ON;
        }
        return con ? State.IN : State.OUT;
    }

}
public enum State { OUT, ON, IN }
#endregion