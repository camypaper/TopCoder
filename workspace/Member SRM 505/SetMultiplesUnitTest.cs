using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long A, long B, long C, long D,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        Console.WriteLine("C:{0}", C);
        Console.WriteLine("D:{0}", D);
        }
        long __result = new SetMultiples().smallestSubset(A, B, C, D);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long A = 1L;
        Console.WriteLine("A:{0}", A);
        long B = 1L;
        Console.WriteLine("B:{0}", B);
        long C = 2L;
        Console.WriteLine("C:{0}", C);
        long D = 2L;
        Console.WriteLine("D:{0}", D);
        long __expected = 1L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new SetMultiples().smallestSubset(A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long A = 1L;
        Console.WriteLine("A:{0}", A);
        long B = 2L;
        Console.WriteLine("B:{0}", B);
        long C = 3L;
        Console.WriteLine("C:{0}", C);
        long D = 4L;
        Console.WriteLine("D:{0}", D);
        long __expected = 2L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new SetMultiples().smallestSubset(A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long A = 2L;
        Console.WriteLine("A:{0}", A);
        long B = 3L;
        Console.WriteLine("B:{0}", B);
        long C = 5L;
        Console.WriteLine("C:{0}", C);
        long D = 7L;
        Console.WriteLine("D:{0}", D);
        long __expected = 3L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new SetMultiples().smallestSubset(A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long A = 1L;
        Console.WriteLine("A:{0}", A);
        long B = 10L;
        Console.WriteLine("B:{0}", B);
        long C = 100L;
        Console.WriteLine("C:{0}", C);
        long D = 1000L;
        Console.WriteLine("D:{0}", D);
        long __expected = 500L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new SetMultiples().smallestSubset(A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        long A = 1000000000L;
        Console.WriteLine("A:{0}", A);
        long B = 2000000000L;
        Console.WriteLine("B:{0}", B);
        long C = 9000000000L;
        Console.WriteLine("C:{0}", C);
        long D = 10000000000L;
        Console.WriteLine("D:{0}", D);
        long __expected = 1254365078L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new SetMultiples().smallestSubset(A, B, C, D);
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
