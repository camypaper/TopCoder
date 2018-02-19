using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] x, int[] y,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        }
        int __result = new IntersectingConvexHull().count(x, y);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] x = new int[] {
            1,
            0,
            -1,
            -1,
            0,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            1,
            -1,
            -2,
            -1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 14;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IntersectingConvexHull().count(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] x = new int[] {
            444,
            -646,
            367,
            302,
            -506,
            810
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -530,
            660,
            872,
            -78,
            -621,
            77
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 10;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IntersectingConvexHull().count(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] x = new int[] {
            -737,
            -245,
            -51,
            943,
            -7,
            1000,
            -976,
            -723
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -355,
            898,
            -372,
            -585,
            -98,
            -53,
            490,
            -954
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 900;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IntersectingConvexHull().count(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] x = new int[] {
            -928,
            852,
            840,
            813,
            -564,
            -594,
            -667,
            838,
            -74,
            -675,
            -530,
            -476,
            -154,
            702,
            817,
            969,
            845,
            592,
            867,
            -330
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -898,
            682,
            604,
            22,
            -452,
            901,
            464,
            -624,
            -272,
            -792,
            -906,
            36,
            249,
            -287,
            871,
            877,
            446,
            910,
            943,
            427
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 296398747;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IntersectingConvexHull().count(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    bool check(double ex, double res)
    {
        var d = Math.Abs(res - ex);
        if (d <= 1e-9) return true;
        d /= Math.Abs(ex);
        if (d <= 1e-9) return true;
        return false;
    }
    bool check(double[] ex, double[] res)
    {
        if (ex.Length != res.Length) return false;
        for (int i = 0; i < ex.Length; i++)
            if (!check(ex[i], res[i])) return false;
        return true;
    }
    bool check<T>(T ex, T res)
        where T : IComparable<T>
    {
        return ex.CompareTo(res) == 0;
    }
    bool check<T>(T[] ex, T[] res)
        where T : IComparable<T>
    {
        if (ex.Length != res.Length) return false;
        for (int i = 0; i < ex.Length; i++)
            if (!check(ex[i], res[i])) return false;
        return true;
    }
}
