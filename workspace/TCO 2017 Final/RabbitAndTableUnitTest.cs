using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] x,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        }
        int __result = new RabbitAndTable().count(x);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] x = new int[] {
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RabbitAndTable().count(x);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] x = new int[] {
            3,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RabbitAndTable().count(x);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] x = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RabbitAndTable().count(x);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] x = new int[] {
            15,
            15,
            15,
            15,
            15,
            15,
            15,
            15,
            15,
            15,
            15,
            15,
            15,
            15,
            15
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 382958538;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RabbitAndTable().count(x);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] x = new int[] {
            3,
            2,
            2,
            1,
            5,
            4,
            4,
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 272;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RabbitAndTable().count(x);
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
