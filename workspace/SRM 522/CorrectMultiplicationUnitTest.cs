using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int a, int b, int c,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("c:{0}", c);
        }
        long __result = new CorrectMultiplication().getMinimum(a, b, c);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int a = 19;
        Console.WriteLine("a:{0}", a);
        int b = 28;
        Console.WriteLine("b:{0}", b);
        int c = 522;
        Console.WriteLine("c:{0}", c);
        long __expected = 2L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CorrectMultiplication().getMinimum(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int a = 10;
        Console.WriteLine("a:{0}", a);
        int b = 30;
        Console.WriteLine("b:{0}", b);
        int c = 500;
        Console.WriteLine("c:{0}", c);
        long __expected = 11L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CorrectMultiplication().getMinimum(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int a = 11111;
        Console.WriteLine("a:{0}", a);
        int b = 11111;
        Console.WriteLine("b:{0}", b);
        int c = 123454321;
        Console.WriteLine("c:{0}", c);
        long __expected = 0L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CorrectMultiplication().getMinimum(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int a = 1000;
        Console.WriteLine("a:{0}", a);
        int b = 100;
        Console.WriteLine("b:{0}", b);
        int c = 10;
        Console.WriteLine("c:{0}", c);
        long __expected = 1089L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CorrectMultiplication().getMinimum(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int a = 399;
        Console.WriteLine("a:{0}", a);
        int b = 522;
        Console.WriteLine("b:{0}", b);
        int c = 199999;
        Console.WriteLine("c:{0}", c);
        long __expected = 24L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CorrectMultiplication().getMinimum(a, b, c);
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
