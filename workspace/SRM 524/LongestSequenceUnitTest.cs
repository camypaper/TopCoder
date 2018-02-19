using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] C,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("C:{0}", string.Join(" ",C)));
        }
        int __result = new LongestSequence().maxLength(C);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] C = new int[] {
            -2,
            3
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        int __expected = 3;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new LongestSequence().maxLength(C);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] C = new int[] {
            524
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new LongestSequence().maxLength(C);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] C = new int[] {
            1,
            -1
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new LongestSequence().maxLength(C);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] C = new int[] {
            11,
            -7
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        int __expected = 16;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new LongestSequence().maxLength(C);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] C = new int[] {
            -227,
            690,
            590,
            -524
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        int __expected = 713;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new LongestSequence().maxLength(C);
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
