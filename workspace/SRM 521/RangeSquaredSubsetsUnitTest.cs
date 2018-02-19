using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int nlow, int nhigh, int[] x, int[] y,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("nlow:{0}", nlow);
        Console.WriteLine("nhigh:{0}", nhigh);
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        }
        long __result = new RangeSquaredSubsets().countSubsets(nlow, nhigh, x, y);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int nlow = 5;
        Console.WriteLine("nlow:{0}", nlow);
        int nhigh = 5;
        Console.WriteLine("nhigh:{0}", nhigh);
        int[] x = new int[] {
            -5,
            0,
            5
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 5L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RangeSquaredSubsets().countSubsets(nlow, nhigh, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int nlow = 10;
        Console.WriteLine("nlow:{0}", nlow);
        int nhigh = 10;
        Console.WriteLine("nhigh:{0}", nhigh);
        int[] x = new int[] {
            -5,
            0,
            5
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 5L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RangeSquaredSubsets().countSubsets(nlow, nhigh, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int nlow = 1;
        Console.WriteLine("nlow:{0}", nlow);
        int nhigh = 100;
        Console.WriteLine("nhigh:{0}", nhigh);
        int[] x = new int[] {
            -5,
            0,
            5
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 6L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RangeSquaredSubsets().countSubsets(nlow, nhigh, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int nlow = 3;
        Console.WriteLine("nlow:{0}", nlow);
        int nhigh = 100000000;
        Console.WriteLine("nhigh:{0}", nhigh);
        int[] x = new int[] {
            -1,
            -1,
            -1,
            0,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -1,
            0,
            1,
            1,
            -1,
            0,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 21L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RangeSquaredSubsets().countSubsets(nlow, nhigh, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int nlow = 64;
        Console.WriteLine("nlow:{0}", nlow);
        int nhigh = 108;
        Console.WriteLine("nhigh:{0}", nhigh);
        int[] x = new int[] {
            -56,
            -234,
            12,
            324,
            -12,
            53,
            0,
            234,
            1,
            12,
            72
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            6,
            34,
            2,
            235,
            234,
            234,
            342,
            324,
            234,
            234,
            234
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 26L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RangeSquaredSubsets().countSubsets(nlow, nhigh, x, y);
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
