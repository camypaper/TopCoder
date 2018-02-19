using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long digits, int divisor,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("digits:{0}", digits);
        Console.WriteLine("divisor:{0}", divisor);
        }
        int __result = new IncreasingNumber().countNumbers(digits, divisor);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long digits = 2L;
        Console.WriteLine("digits:{0}", digits);
        int divisor = 12;
        Console.WriteLine("divisor:{0}", divisor);
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingNumber().countNumbers(digits, divisor);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long digits = 3L;
        Console.WriteLine("digits:{0}", digits);
        int divisor = 111;
        Console.WriteLine("divisor:{0}", divisor);
        int __expected = 9;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingNumber().countNumbers(digits, divisor);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long digits = 452L;
        Console.WriteLine("digits:{0}", digits);
        int divisor = 10;
        Console.WriteLine("divisor:{0}", divisor);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingNumber().countNumbers(digits, divisor);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long digits = 6L;
        Console.WriteLine("digits:{0}", digits);
        int divisor = 58;
        Console.WriteLine("divisor:{0}", divisor);
        int __expected = 38;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingNumber().countNumbers(digits, divisor);
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
