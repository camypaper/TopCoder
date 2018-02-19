using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Point = System.Numerics.Complex;
public class ArmyTeleportation
{
    public string ifPossible(int[] x1, int[] y1, int[] x2, int[] y2, int[] xt, int[] yt)
    {
        return f(x1, y1, x2, y2, xt, yt) ? "possible" : "impossible";
    }
    bool f(int[] x1, int[] y1, int[] x2, int[] y2, int[] xt, int[] yt)
    {
        var n = x1.Length;
        var vx = new List<int>();
        var vy = new List<int>();
        for (int i = 0; i < 2; i++)
        {
            vx.Add(2 * (xt[2] - xt[i]));
            vy.Add(2 * (yt[2] - yt[i]));
        }
        for (int i = 0; i < vx.Count; i++)
            Debug.WriteLine("{0} {1}", vx[i], vy[i]);
        if (g(x1, x2, y1, y2, vx, vy)) return true;
        for (int i = 0; i < 3; i++)
        {
            var X = x1.ToArray();
            var Y = y1.ToArray();
            for (int j = 0; j < n; j++)
            {
                X[j] = 2 * xt[i] - x1[j];
                Y[j] = 2 * yt[i] - y1[j];
            }
            if (g(X, x2, Y, y2, vx, vy)) return true;
        }


        return false;
    }
    bool g(int[] x1, int[] x2, int[] y1, int[] y2, List<int> vx, List<int> vy)
    {
        int n = x1.Length;
        Array.Sort(x1, y1);
        Array.Sort(x2, y2);
        var dx = x2[0] - x1[0];
        var dy = y2[0] - y1[0];
        for (int j = 0; j < n; j++)
        {
            if (dx != x2[j] - x1[j])
                return false;
            if (dy != y2[j] - y1[j])
                return false;
        }
        Debug.WriteLine("{0} {1}", dx, dy);
        for (long i = -5000000; i < 5000000; i++)
        {
            var u = dx + i * vx[0];
            var v = dy + i * vy[0];
            if (u != 0 && vx[1] == 0) continue;
            if (v != 0 && vy[1] == 0) continue;
            if (vx[1] == 0) return v % vy[1] == 0;
            if (vy[1] == 0) return u % vx[1] == 0;
            if (u % vx[1] != 0) continue;
            if (v % vy[1] != 0) continue;
            if (u / vx[1] == v / vy[1]) return true;
        }
        return false;
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
        test.ManualTest(
            new int[] { -959770, 970513, -183963, -740889, -992328, -372694, 105305, -667251, -203486, 449375, 244294, -236648, 586292, -52195, -712418, -910032, -935851, 628018, -23726, -744469, 631925, 622494, -935713, -430082, 719157, -318948, -898838, 416778, -385952, 806355, 415515, 421712, -35297, 504726, -278827, 508554, 543581, 157957, 637968, 77940, 334660, 759261, -125521, -560773, -166076, -316233, -629835, -338112, 650200, -945618 },
            new int[] { 124484, 129882, -589600, -691836, -379042, 344182, 911187, -720552, -373694, 61566, 366348, 956195, 678187, 867516, -304279, -699170, 345702, -546702, 527551, 138739, -933466, 439266, 984099, 585359, -447938, -353542, 710848, 301062, 342537, -7372, -653856, -176628, 507275, -335977, 361482, -490067, 882744, -460587, 9130, 701442, -460204, -262952, 441935, 2448, -194708, 148808, -184728, -866851, 275610, 602717 },
            new int[] { 586292, -125521, 415515, -278827, 543581, -236648, -338112, -166076, -318948, -560773, -945618, -959770, 628018, -992328, 759261, -935713, -629835, 631925, -935851, 970513, -744469, -316233, 157957, 416778, -667251, -712418, -52195, -203486, 508554, 449375, -740889, -35297, 77940, 105305, 334660, 806355, 421712, 719157, 637968, -372694, -23726, -910032, -430082, -183963, 622494, -385952, -898838, 244294, 650200, 504726 },
            new int[] { 678187, 441935, -653856, 361482, 882744, 956195, -866851, -194708, -353542, 2448, 602717, 124484, -546702, -379042, -262952, 984099, -184728, -933466, 345702, 129882, 138739, 148808, -460587, 301062, -720552, -304279, 867516, -373694, -490067, 61566, -691836, 507275, 701442, 911187, -460204, -7372, -176628, -447938, 9130, 344182, 527551, -699170, 585359, -589600, 439266, 342537, 710848, 366348, 275610, -335977 },
            new int[] { -684847, 38839, -716290 },
            new int[] { 681271, 364500, 65270 });
    }
}
// CUT end
#region gcd,lcm
static public partial class MathEx
{

    static public long GCD(long x, long y)
    {
        byte i = 0;
        while (x != 0 && y != 0)
        {
            if (i == 0)
                y %= x;
            else x %= y;
            i ^= 1;
        }
        return x == 0 ? y : x;
    }


}
#endregion