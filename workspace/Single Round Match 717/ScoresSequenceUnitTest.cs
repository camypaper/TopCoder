using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] s,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
        }
        int __result = new ScoresSequence().count(s);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] s = new int[] {
            2,
            0,
            1
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 6;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScoresSequence().count(s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] s = new int[] {
            1,
            0,
            2
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 6;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScoresSequence().count(s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] s = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 9;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScoresSequence().count(s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] s = new int[] {
            0,
            2,
            8,
            4,
            3,
            9,
            1,
            5,
            7,
            6
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 55;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScoresSequence().count(s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] s = new int[] {
            22,
            20,
            14,
            13,
            17,
            15,
            12,
            18,
            23,
            15,
            21,
            26,
            33,
            5,
            19,
            9,
            37,
            0,
            25,
            28,
            4,
            12,
            35,
            32,
            25,
            7,
            31,
            6,
            2,
            29,
            10,
            33,
            36,
            27,
            39,
            28,
            40,
            3,
            8,
            38,
            3
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 1422;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScoresSequence().count(s);
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
