using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int height, int width, long S,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("height:{0}", height);
        Console.WriteLine("width:{0}", width);
        Console.WriteLine("S:{0}", S);
        }
        long __result = new RectangularSum().minimalArea(height, width, S);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int height = 2;
        Console.WriteLine("height:{0}", height);
        int width = 3;
        Console.WriteLine("width:{0}", width);
        long S = 8L;
        Console.WriteLine("S:{0}", S);
        long __expected = 4L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RectangularSum().minimalArea(height, width, S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int height = 3;
        Console.WriteLine("height:{0}", height);
        int width = 3;
        Console.WriteLine("width:{0}", width);
        long S = 10L;
        Console.WriteLine("S:{0}", S);
        long __expected = -1L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RectangularSum().minimalArea(height, width, S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int height = 3;
        Console.WriteLine("height:{0}", height);
        int width = 3;
        Console.WriteLine("width:{0}", width);
        long S = 36L;
        Console.WriteLine("S:{0}", S);
        long __expected = 9L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RectangularSum().minimalArea(height, width, S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int height = 25;
        Console.WriteLine("height:{0}", height);
        int width = 25;
        Console.WriteLine("width:{0}", width);
        long S = 16000L;
        Console.WriteLine("S:{0}", S);
        long __expected = 32L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RectangularSum().minimalArea(height, width, S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int height = 1000000;
        Console.WriteLine("height:{0}", height);
        int width = 1000000;
        Console.WriteLine("width:{0}", width);
        long S = 1000000000000L;
        Console.WriteLine("S:{0}", S);
        long __expected = 2L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new RectangularSum().minimalArea(height, width, S);
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
