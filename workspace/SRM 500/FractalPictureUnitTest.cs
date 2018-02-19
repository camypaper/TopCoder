using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int x1, int y1, int x2, int y2,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("x1:{0}", x1);
        Console.WriteLine("y1:{0}", y1);
        Console.WriteLine("x2:{0}", x2);
        Console.WriteLine("y2:{0}", y2);
        }
        double __result = new FractalPicture().getLength(x1, y1, x2, y2);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int x1 = -1;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 0;
        Console.WriteLine("y1:{0}", y1);
        int x2 = 1;
        Console.WriteLine("x2:{0}", x2);
        int y2 = 53;
        Console.WriteLine("y2:{0}", y2);
        double __expected = 53.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new FractalPicture().getLength(x1, y1, x2, y2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int x1 = 1;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 1;
        Console.WriteLine("y1:{0}", y1);
        int x2 = 10;
        Console.WriteLine("x2:{0}", x2);
        int y2 = 10;
        Console.WriteLine("y2:{0}", y2);
        double __expected = 0.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new FractalPicture().getLength(x1, y1, x2, y2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int x1 = -10;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 54;
        Console.WriteLine("y1:{0}", y1);
        int x2 = 10;
        Console.WriteLine("x2:{0}", x2);
        int y2 = 55;
        Console.WriteLine("y2:{0}", y2);
        double __expected = 21.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new FractalPicture().getLength(x1, y1, x2, y2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int x1 = 14;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 45;
        Console.WriteLine("y1:{0}", y1);
        int x2 = 22;
        Console.WriteLine("x2:{0}", x2);
        int y2 = 54;
        Console.WriteLine("y2:{0}", y2);
        double __expected = 2999.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new FractalPicture().getLength(x1, y1, x2, y2);
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
