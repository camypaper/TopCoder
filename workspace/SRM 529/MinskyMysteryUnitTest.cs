using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long N,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("N:{0}", N);
        }
        int __result = new MinskyMystery().computeAnswer(N);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long N = 2L;
        Console.WriteLine("N:{0}", N);
        int __expected = 9;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MinskyMystery().computeAnswer(N);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long N = 3L;
        Console.WriteLine("N:{0}", N);
        int __expected = 27;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MinskyMystery().computeAnswer(N);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long N = 4L;
        Console.WriteLine("N:{0}", N);
        int __expected = 16;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MinskyMystery().computeAnswer(N);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long N = 2401L;
        Console.WriteLine("N:{0}", N);
        int __expected = 59058;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MinskyMystery().computeAnswer(N);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        long N = 24L;
        Console.WriteLine("N:{0}", N);
        int __expected = 86;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MinskyMystery().computeAnswer(N);
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
