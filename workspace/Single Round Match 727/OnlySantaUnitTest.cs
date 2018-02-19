using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string S,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("S:{0}", S);
        }
        string __result = new OnlySanta().solve(S);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string S = "STANA";
        Console.WriteLine("S:{0}", S);
        string __expected = "STANTA";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new OnlySanta().solve(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string S = "STN";
        Console.WriteLine("S:{0}", S);
        string __expected = "SANTNA";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new OnlySanta().solve(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string S = "RATSNOOOA";
        Console.WriteLine("S:{0}", S);
        string __expected = "DEARATSNOOOSANTA";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new OnlySanta().solve(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string S = "SXAYNTA";
        Console.WriteLine("S:{0}", S);
        string __expected = "OOOOSOXAYNTOOOOAOOO";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new OnlySanta().solve(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string S = "SNTA";
        Console.WriteLine("S:{0}", S);
        string __expected = "SANTA";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new OnlySanta().solve(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string S = "ASNTA";
        Console.WriteLine("S:{0}", S);
        string __expected = "SASNTAS";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new OnlySanta().solve(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example6(bool fast = false)
    {
        Console.WriteLine("Example6");
        string S = "NIELATA";
        Console.WriteLine("S:{0}", S);
        string __expected = "SANIELATAJA";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new OnlySanta().solve(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example7(bool fast = false)
    {
        Console.WriteLine("Example7");
        string S = "X";
        Console.WriteLine("S:{0}", S);
        string __expected = "SSAAXNNTTAA";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new OnlySanta().solve(S);
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
