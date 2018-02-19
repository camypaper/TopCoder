using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] S,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("S:{0}", string.Join(" ",S)));
        }
        int __result = new SubFibonacci().maxElements(S);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] S = new int[] {
            8,
            1,
            20,
            3,
            10
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SubFibonacci().maxElements(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] S = new int[] {
            19,
            47,
            50,
            58,
            77,
            99
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SubFibonacci().maxElements(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] S = new int[] {
            512
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SubFibonacci().maxElements(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] S = new int[] {
            3,
            5,
            7,
            10,
            13,
            15,
            20,
            90
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int __expected = 7;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SubFibonacci().maxElements(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] S = new int[] {
            1,
            2,
            3,
            5,
            8,
            13,
            21,
            34,
            55,
            89
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int __expected = 10;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SubFibonacci().maxElements(S);
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
