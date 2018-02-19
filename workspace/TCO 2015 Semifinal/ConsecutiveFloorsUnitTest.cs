using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] x, int[] y,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        }
        string __result = new ConsecutiveFloors().isConsistent(x, y);
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
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            3,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Consistent";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConsecutiveFloors().isConsistent(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] x = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Inconsistent";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConsecutiveFloors().isConsistent(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] x = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            6,
            3,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Consistent";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConsecutiveFloors().isConsistent(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] x = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            6,
            4,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Inconsistent";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConsecutiveFloors().isConsistent(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] x = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            30,
            20,
            10
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Consistent";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConsecutiveFloors().isConsistent(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int[] x = new int[] {
            477381380,
            518025930,
            570087601,
            737384427
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            933387341,
            532515987,
            318113054,
            112496297
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Consistent";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConsecutiveFloors().isConsistent(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example6(bool fast = false)
    {
        Console.WriteLine("Example6");
        int[] x = new int[] {
            308943472,
            309514623,
            420739506,
            433180054,
            824938090
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            825002165,
            692190478,
            565185585,
            520367469,
            109640379
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Inconsistent";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConsecutiveFloors().isConsistent(x, y);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example7(bool fast = false)
    {
        Console.WriteLine("Example7");
        int[] x = new int[] {
            120488476,
            120910581,
            191235701,
            273389056,
            325781420,
            732516446
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            984130593,
            891325429,
            628742451,
            440622881,
            368262567,
            198194666
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Inconsistent";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConsecutiveFloors().isConsistent(x, y);
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
