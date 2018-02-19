using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int L,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("L:{0}", L);
        }
        double __result = new FindPolygons().minimumPolygon(L);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int L = 4;
        Console.WriteLine("L:{0}", L);
        double __expected = 0.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new FindPolygons().minimumPolygon(L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int L = 5;
        Console.WriteLine("L:{0}", L);
        double __expected = -1.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new FindPolygons().minimumPolygon(L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int L = 12;
        Console.WriteLine("L:{0}", L);
        double __expected = 2.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new FindPolygons().minimumPolygon(L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int L = 4984;
        Console.WriteLine("L:{0}", L);
        double __expected = 819.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new FindPolygons().minimumPolygon(L);
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
