using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] p, int[] S,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        Console.WriteLine(string.Format("S:{0}", string.Join(" ",S)));
        }
        string __result = new JumpDistancesOnTree().isPossible(p, S);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] p = new int[] {
            0,
            1,
            1,
            0,
            4,
            4
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] S = new int[] {
            2,
            4
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        string __expected = "Possible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new JumpDistancesOnTree().isPossible(p, S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] p = new int[] {
            0,
            1,
            1,
            0,
            4,
            4
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] S = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        string __expected = "Impossible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new JumpDistancesOnTree().isPossible(p, S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] p = new int[] {
            0,
            1,
            1,
            0,
            4,
            4
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] S = new int[] {
            3,
            4
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        string __expected = "Impossible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new JumpDistancesOnTree().isPossible(p, S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] p = new int[] {
            0,
            1,
            2,
            3,
            4,
            0,
            6,
            7,
            8,
            9
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] S = new int[] {
            2,
            4,
            6,
            8,
            10
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        string __expected = "Impossible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new JumpDistancesOnTree().isPossible(p, S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] p = new int[] {
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] S = new int[] {
            1
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        string __expected = "Possible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new JumpDistancesOnTree().isPossible(p, S);
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
