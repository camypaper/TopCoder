using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long n, int k,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("k:{0}", k);
        }
        long __result = new ConsecutiveOnes().get(n, k);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long n = 1L;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        long __expected = 3L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConsecutiveOnes().get(n, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long n = 5L;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        long __expected = 6L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConsecutiveOnes().get(n, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long n = 7L;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        long __expected = 7L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConsecutiveOnes().get(n, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long n = 364269800189924L;
        Console.WriteLine("n:{0}", n);
        int k = 33;
        Console.WriteLine("k:{0}", k);
        long __expected = 364273356242943L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConsecutiveOnes().get(n, k);
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
