using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] d, int[] x, int[] y,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        }
        int __result = new CoastGuard().count(d, x, y);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] d = new int[] {
            -2,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] x = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CoastGuard().count(d, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] d = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] x = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            10,
            10
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CoastGuard().count(d, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] d = new int[] {
            -2,
            2,
            98,
            102
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] x = new int[] {
            0,
            1,
            100,
            101
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CoastGuard().count(d, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] d = new int[] {
            1,
            109,
            229,
            294,
            589,
            615,
            741,
            822,
            859,
            1000
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] x = new int[] {
            546,
            850,
            287,
            452,
            864,
            874,
            529,
            879,
            818,
            589
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            414,
            176,
            191,
            15,
            764,
            825,
            204,
            477,
            34,
            460
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 400;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CoastGuard().count(d, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] d = new int[] {
            -1,
            0,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] x = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CoastGuard().count(d, x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int[] d = new int[] {
            0
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] x = new int[] {
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CoastGuard().count(d, x, y);
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
