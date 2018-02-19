using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int n,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("n:{0}", n);
        }
        string __result = new GameOfInterval().construct(n);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int n = 4;
        Console.WriteLine("n:{0}", n);
        string __expected = "0102";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new GameOfInterval().construct(n);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int n = 6;
        Console.WriteLine("n:{0}", n);
        string __expected = "00010102020303040405000301040205";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new GameOfInterval().construct(n);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int n = 5;
        Console.WriteLine("n:{0}", n);
        string __expected = "00010001";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new GameOfInterval().construct(n);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int n = 80;
        Console.WriteLine("n:{0}", n);
        string __expected = "";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new GameOfInterval().construct(n);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int n = 81;
        Console.WriteLine("n:{0}", n);
        string __expected = "00010203";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new GameOfInterval().construct(n);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int n = 1;
        Console.WriteLine("n:{0}", n);
        string __expected = "";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new GameOfInterval().construct(n);
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
