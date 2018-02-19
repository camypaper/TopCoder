using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] range, int[] amount,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("range:{0}", string.Join(" ",range)));
        Console.WriteLine(string.Format("amount:{0}", string.Join(" ",amount)));
        }
        double __result = new MagicBlizzard().expectation(range, amount);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] range = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("range:{0}", string.Join(" ", range)));
        int[] amount = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("amount:{0}", string.Join(" ", amount)));
        double __expected = 2.2222222222222223;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MagicBlizzard().expectation(range, amount);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] range = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("range:{0}", string.Join(" ", range)));
        int[] amount = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("amount:{0}", string.Join(" ", amount)));
        double __expected = 3.666666666666667;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MagicBlizzard().expectation(range, amount);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] range = new int[] {
            5,
            2,
            6,
            5
        };
        Console.WriteLine(string.Format("range:{0}", string.Join(" ", range)));
        int[] amount = new int[] {
            1,
            2,
            2,
            3
        };
        Console.WriteLine(string.Format("amount:{0}", string.Join(" ", amount)));
        double __expected = 8.46525111252384;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MagicBlizzard().expectation(range, amount);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] range = new int[] {
            7,
            11,
            2,
            13,
            3,
            19,
            5,
            17
        };
        Console.WriteLine(string.Format("range:{0}", string.Join(" ", range)));
        int[] amount = new int[] {
            16,
            8,
            4,
            15,
            12,
            9,
            10,
            6
        };
        Console.WriteLine(string.Format("amount:{0}", string.Join(" ", amount)));
        double __expected = 98.55659436211914;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MagicBlizzard().expectation(range, amount);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] range = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("range:{0}", string.Join(" ", range)));
        int[] amount = new int[] {
            10000,
            10000,
            10000,
            10000,
            10000,
            10000,
            10000,
            10000,
            10000,
            10000
        };
        Console.WriteLine(string.Format("amount:{0}", string.Join(" ", amount)));
        double __expected = 1.0E10;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MagicBlizzard().expectation(range, amount);
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
