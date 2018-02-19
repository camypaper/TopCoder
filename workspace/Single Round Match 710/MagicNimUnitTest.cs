using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] arr,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ",arr)));
        }
        string __result = new MagicNim().findWinner(arr);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] arr = new int[] {
            1
        };
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ", arr)));
        string __expected = "Alice";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new MagicNim().findWinner(arr);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] arr = new int[] {
            2
        };
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ", arr)));
        string __expected = "Bob";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new MagicNim().findWinner(arr);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] arr = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ", arr)));
        string __expected = "Alice";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new MagicNim().findWinner(arr);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] arr = new int[] {
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ", arr)));
        string __expected = "Alice";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new MagicNim().findWinner(arr);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] arr = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ", arr)));
        string __expected = "Bob";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new MagicNim().findWinner(arr);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int[] arr = new int[] {
            4,
            4,
            2
        };
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ", arr)));
        string __expected = "Alice";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new MagicNim().findWinner(arr);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example6(bool fast = false)
    {
        Console.WriteLine("Example6");
        int[] arr = new int[] {
            50,
            50,
            50,
            50,
            50,
            50,
            50,
            50,
            50,
            50
        };
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ", arr)));
        string __expected = "Alice";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new MagicNim().findWinner(arr);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example7(bool fast = false)
    {
        Console.WriteLine("Example7");
        int[] arr = new int[] {
            6,
            7
        };
        Console.WriteLine(string.Format("arr:{0}", string.Join(" ", arr)));
        string __expected = "Bob";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new MagicNim().findWinner(arr);
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
