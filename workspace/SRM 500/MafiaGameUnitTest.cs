using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int N, int[] decisions,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("decisions:{0}", string.Join(" ",decisions)));
        }
        double __result = new MafiaGame().probabilityToLose(N, decisions);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] decisions = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("decisions:{0}", string.Join(" ", decisions)));
        double __expected = 1.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MafiaGame().probabilityToLose(N, decisions);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] decisions = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("decisions:{0}", string.Join(" ", decisions)));
        double __expected = 0.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MafiaGame().probabilityToLose(N, decisions);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int N = 20;
        Console.WriteLine("N:{0}", N);
        int[] decisions = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            18,
            19,
            0
        };
        Console.WriteLine(string.Format("decisions:{0}", string.Join(" ", decisions)));
        double __expected = 0.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MafiaGame().probabilityToLose(N, decisions);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int N = 23;
        Console.WriteLine("N:{0}", N);
        int[] decisions = new int[] {
            17,
            10,
            3,
            14,
            22,
            5,
            11,
            10,
            22,
            3,
            14,
            5,
            11,
            17
        };
        Console.WriteLine(string.Format("decisions:{0}", string.Join(" ", decisions)));
        double __expected = 0.14285714285714285;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new MafiaGame().probabilityToLose(N, decisions);
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
