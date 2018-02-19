using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int n, int s, int t,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("t:{0}", t);
        }
        int __result = new NonCoprimeGraph().distance(n, s, t);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int n = 10;
        Console.WriteLine("n:{0}", n);
        int s = 8;
        Console.WriteLine("s:{0}", s);
        int t = 9;
        Console.WriteLine("t:{0}", t);
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new NonCoprimeGraph().distance(n, s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int n = 10;
        Console.WriteLine("n:{0}", n);
        int s = 6;
        Console.WriteLine("s:{0}", s);
        int t = 9;
        Console.WriteLine("t:{0}", t);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new NonCoprimeGraph().distance(n, s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int n = 100;
        Console.WriteLine("n:{0}", n);
        int s = 89;
        Console.WriteLine("s:{0}", s);
        int t = 97;
        Console.WriteLine("t:{0}", t);
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new NonCoprimeGraph().distance(n, s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int n = 100;
        Console.WriteLine("n:{0}", n);
        int s = 97;
        Console.WriteLine("s:{0}", s);
        int t = 97;
        Console.WriteLine("t:{0}", t);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new NonCoprimeGraph().distance(n, s, t);
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
