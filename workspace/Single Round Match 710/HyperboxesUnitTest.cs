using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int n, int m, int k,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        Console.WriteLine("k:{0}", k);
        }
        int __result = new Hyperboxes().findCount(n, m, k);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 10;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 10;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 100;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 140;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int n = 710;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int k = 710;
        Console.WriteLine("k:{0}", k);
        int __expected = 980029536;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example6(bool fast = false)
    {
        Console.WriteLine("Example6");
        int n = 10;
        Console.WriteLine("n:{0}", n);
        int m = 6;
        Console.WriteLine("m:{0}", m);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example7(bool fast = false)
    {
        Console.WriteLine("Example7");
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int m = 5;
        Console.WriteLine("m:{0}", m);
        int k = 987;
        Console.WriteLine("k:{0}", k);
        int __expected = 457998142;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example8(bool fast = false)
    {
        Console.WriteLine("Example8");
        int n = 1000000000;
        Console.WriteLine("n:{0}", n);
        int m = 6;
        Console.WriteLine("m:{0}", m);
        int k = 1000000000;
        Console.WriteLine("k:{0}", k);
        int __expected = 907279660;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Hyperboxes().findCount(n, m, k);
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
