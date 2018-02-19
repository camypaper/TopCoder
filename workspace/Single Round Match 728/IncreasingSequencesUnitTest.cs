using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] L, int[] R,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("L:{0}", string.Join(" ",L)));
        Console.WriteLine(string.Format("R:{0}", string.Join(" ",R)));
        }
        int __result = new IncreasingSequences().count(L, R);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] L = new int[] {
            1,
            3,
            1,
            4
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            6,
            5,
            4,
            6
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingSequences().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] L = new int[] {
            10,
            30
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            20,
            40
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 121;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingSequences().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] L = new int[] {
            30,
            10
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            40,
            20
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingSequences().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] L = new int[] {
            4,
            46,
            46,
            35,
            20,
            77,
            20
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            41,
            65,
            84,
            90,
            49,
            86,
            88
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 2470;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingSequences().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] L = new int[] {
            1
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            1000000000
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 1755647;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new IncreasingSequences().count(L, R);
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
