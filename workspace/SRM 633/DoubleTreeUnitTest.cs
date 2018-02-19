using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] a, int[] b, int[] c, int[] d, int[] score,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine(string.Format("c:{0}", string.Join(" ",c)));
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        Console.WriteLine(string.Format("score:{0}", string.Join(" ",score)));
        }
        int __result = new DoubleTree().maximalScore(a, b, c, d, score);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] a = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            0,
            0,
            3
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] d = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] score = new int[] {
            1000,
            24,
            100,
            -200
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int __expected = 1024;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DoubleTree().maximalScore(a, b, c, d, score);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] a = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            0,
            0,
            3
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] d = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] score = new int[] {
            1000,
            24,
            100,
            200
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int __expected = 1324;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DoubleTree().maximalScore(a, b, c, d, score);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] a = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            0,
            0,
            3
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] d = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] score = new int[] {
            -1000,
            -24,
            -100,
            -200
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DoubleTree().maximalScore(a, b, c, d, score);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] a = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            0,
            0,
            3
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] d = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] score = new int[] {
            -1000,
            24,
            100,
            200
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int __expected = 200;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DoubleTree().maximalScore(a, b, c, d, score);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] a = new int[] {
            0,
            0,
            1,
            1,
            2,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            0,
            0,
            1,
            1,
            2,
            2
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] d = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] score = new int[] {
            -3,
            2,
            2,
            -1,
            2,
            2,
            -1
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DoubleTree().maximalScore(a, b, c, d, score);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int[] a = new int[] {
            0,
            0,
            1,
            1,
            2,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] d = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] score = new int[] {
            -3,
            2,
            2,
            -1,
            2,
            2,
            -1
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DoubleTree().maximalScore(a, b, c, d, score);
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
