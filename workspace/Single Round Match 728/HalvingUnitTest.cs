using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] a,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        }
        int __result = new Halving().minSteps(a);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] a = new int[] {
            11,
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 3;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Halving().minSteps(a);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] a = new int[] {
            1000000000,
            1000000000,
            1000000000,
            1000000000
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Halving().minSteps(a);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] a = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 10;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Halving().minSteps(a);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] a = new int[] {
            13,
            13,
            7,
            11,
            13,
            11
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 11;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Halving().minSteps(a);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] a = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Halving().minSteps(a);
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
