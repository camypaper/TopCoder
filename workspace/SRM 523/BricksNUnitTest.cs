using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int w, int h, int k,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("w:{0}", w);
        Console.WriteLine("h:{0}", h);
        Console.WriteLine("k:{0}", k);
        }
        int __result = new BricksN().countStructures(w, h, k);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int w = 3;
        Console.WriteLine("w:{0}", w);
        int h = 1;
        Console.WriteLine("h:{0}", h);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 13;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new BricksN().countStructures(w, h, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int w = 3;
        Console.WriteLine("w:{0}", w);
        int h = 2;
        Console.WriteLine("h:{0}", h);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 83;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new BricksN().countStructures(w, h, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int w = 1;
        Console.WriteLine("w:{0}", w);
        int h = 5;
        Console.WriteLine("h:{0}", h);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 6;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new BricksN().countStructures(w, h, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int w = 10;
        Console.WriteLine("w:{0}", w);
        int h = 10;
        Console.WriteLine("h:{0}", h);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 288535435;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new BricksN().countStructures(w, h, k);
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
