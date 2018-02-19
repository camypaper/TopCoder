using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
using Point = System.Numerics.Complex;
public class NoRightTurnDiv2
{
    public int[] findPath(int[] x, int[] y)
    {
        var n = x.Length;
        var ps = new Point[n];
        for (int i = 0; i < n; i++)
            ps[i] = new Point(x[i], y[i]);
        var vs = new bool[n];
        var ret = new int[n];
        var s = 0;
        for (int i = 0; i < n; i++)
            if (x[i] < x[s] || (x[i] == x[s] && y[i] < y[s]))
                s = i;
        ret[0] = s;
        vs[s] = true;
        for (int i = 1; i < n; i++)
        {
            var k = -1;
            for (int j = 0; j < n; j++)
                if (!vs[j] && (k == -1 || Geometry.CCW(ps[s], ps[j], ps[k]) == 1))
                    k = j;
            s = k;
            ret[i] = s;
            vs[s] = true;
        }
        return ret;
    }
}
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
        if (Cross(b, c) > 0) return 1;
        if (Cross(b, c) < 0) return -1;
        if (Dot(b, c) < 0) return 2;
        if (b.Magnitude < c.Magnitude) return -2;
        return 0;
    }

}
