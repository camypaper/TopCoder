using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string labels, int[] parents,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("labels:{0}", labels);
        Console.WriteLine(string.Format("parents:{0}", string.Join(" ",parents)));
        }
        int __result = new DengklekGaneshAndTree().getCount(labels, parents);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string labels = "seems";
        Console.WriteLine("labels:{0}", labels);
        int[] parents = new int[] {
            0,
            1,
            0,
            3
        };
        Console.WriteLine(string.Format("parents:{0}", string.Join(" ", parents)));
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DengklekGaneshAndTree().getCount(labels, parents);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string labels = "like";
        Console.WriteLine("labels:{0}", labels);
        int[] parents = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("parents:{0}", string.Join(" ", parents)));
        int __expected = 7;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DengklekGaneshAndTree().getCount(labels, parents);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string labels = "a";
        Console.WriteLine("labels:{0}", labels);
        int[] parents = new int[] {
        };
        Console.WriteLine(string.Format("parents:{0}", string.Join(" ", parents)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DengklekGaneshAndTree().getCount(labels, parents);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string labels = "coincidence";
        Console.WriteLine("labels:{0}", labels);
        int[] parents = new int[] {
            0,
            1,
            2,
            0,
            2,
            1,
            4,
            7,
            7,
            6
        };
        Console.WriteLine(string.Format("parents:{0}", string.Join(" ", parents)));
        int __expected = 218;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DengklekGaneshAndTree().getCount(labels, parents);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string labels = "topcoderopenroundtwobgoodluckhavefun";
        Console.WriteLine("labels:{0}", labels);
        int[] parents = new int[] {
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0
        };
        Console.WriteLine(string.Format("parents:{0}", string.Join(" ", parents)));
        int __expected = 147418098;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DengklekGaneshAndTree().getCount(labels, parents);
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
