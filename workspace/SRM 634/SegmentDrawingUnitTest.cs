using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] x, int[] y, int[] redScore, int[] blueScore,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        Console.WriteLine(string.Format("redScore:{0}", string.Join(" ",redScore)));
        Console.WriteLine(string.Format("blueScore:{0}", string.Join(" ",blueScore)));
        }
        int __result = new SegmentDrawing().maxScore(x, y, redScore, blueScore);
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
            0,
            1,
            0,
            -1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            0,
            -1,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int[] redScore = new int[] {
            0,
            1,
            2,
            3,
            1,
            0,
            6,
            4,
            2,
            6,
            0,
            5,
            3,
            4,
            5,
            0
        };
        Console.WriteLine(string.Format("redScore:{0}", string.Join(" ", redScore)));
        int[] blueScore = new int[] {
            0,
            2,
            3,
            7,
            2,
            0,
            4,
            6,
            3,
            4,
            0,
            5,
            7,
            6,
            5,
            0
        };
        Console.WriteLine(string.Format("blueScore:{0}", string.Join(" ", blueScore)));
        int __expected = 27;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SegmentDrawing().maxScore(x, y, redScore, blueScore);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] x = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int[] redScore = new int[] {
            0,
            101,
            101,
            0
        };
        Console.WriteLine(string.Format("redScore:{0}", string.Join(" ", redScore)));
        int[] blueScore = new int[] {
            0,
            100,
            100,
            0
        };
        Console.WriteLine(string.Format("blueScore:{0}", string.Join(" ", blueScore)));
        int __expected = 101;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SegmentDrawing().maxScore(x, y, redScore, blueScore);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] x = new int[] {
            -3,
            -1,
            -1,
            1,
            1,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            -2,
            2,
            -2,
            2,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int[] redScore = new int[] {
            0,
            2,
            1,
            2,
            1,
            2,
            2,
            0,
            2,
            1,
            2,
            1,
            1,
            2,
            0,
            2,
            1,
            2,
            2,
            1,
            2,
            0,
            2,
            1,
            1,
            2,
            1,
            2,
            0,
            2,
            2,
            1,
            2,
            1,
            2,
            0
        };
        Console.WriteLine(string.Format("redScore:{0}", string.Join(" ", redScore)));
        int[] blueScore = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            21,
            0,
            0,
            0,
            0,
            21,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("blueScore:{0}", string.Join(" ", blueScore)));
        int __expected = 25;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SegmentDrawing().maxScore(x, y, redScore, blueScore);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] x = new int[] {
            -100,
            100,
            0,
            -10,
            10,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            100,
            10,
            10,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int[] redScore = new int[] {
            0,
            96,
            96,
            25,
            25,
            25,
            96,
            0,
            96,
            25,
            25,
            25,
            96,
            96,
            0,
            25,
            25,
            25,
            25,
            25,
            25,
            0,
            10,
            10,
            25,
            25,
            25,
            10,
            0,
            10,
            25,
            25,
            25,
            10,
            10,
            0
        };
        Console.WriteLine(string.Format("redScore:{0}", string.Join(" ", redScore)));
        int[] blueScore = new int[] {
            0,
            30,
            30,
            20,
            20,
            20,
            30,
            0,
            30,
            20,
            20,
            20,
            30,
            30,
            0,
            20,
            20,
            20,
            20,
            20,
            20,
            0,
            86,
            86,
            20,
            20,
            20,
            86,
            0,
            86,
            20,
            20,
            20,
            86,
            86,
            0
        };
        Console.WriteLine(string.Format("blueScore:{0}", string.Join(" ", blueScore)));
        int __expected = 546;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SegmentDrawing().maxScore(x, y, redScore, blueScore);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] x = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            4,
            9,
            16,
            25,
            36,
            49,
            64,
            81,
            100
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int[] redScore = new int[] {
            0,
            15,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            15,
            0,
            15,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            2,
            15,
            0,
            15,
            2,
            3,
            4,
            5,
            6,
            7,
            3,
            2,
            15,
            0,
            15,
            2,
            3,
            4,
            5,
            6,
            4,
            3,
            2,
            15,
            0,
            15,
            2,
            3,
            4,
            5,
            5,
            4,
            3,
            2,
            15,
            0,
            15,
            2,
            3,
            4,
            6,
            5,
            4,
            3,
            2,
            15,
            0,
            15,
            2,
            3,
            7,
            6,
            5,
            4,
            3,
            2,
            15,
            0,
            15,
            2,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            15,
            0,
            15,
            9,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            15,
            0
        };
        Console.WriteLine(string.Format("redScore:{0}", string.Join(" ", redScore)));
        int[] blueScore = new int[] {
            0,
            0,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            0,
            0,
            0,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            2,
            0,
            0,
            0,
            2,
            3,
            4,
            5,
            6,
            7,
            3,
            2,
            0,
            0,
            0,
            2,
            3,
            4,
            5,
            6,
            4,
            3,
            2,
            0,
            0,
            100,
            2,
            3,
            4,
            5,
            5,
            4,
            3,
            2,
            100,
            0,
            0,
            2,
            3,
            4,
            6,
            5,
            4,
            3,
            2,
            0,
            0,
            0,
            2,
            3,
            7,
            6,
            5,
            4,
            3,
            2,
            0,
            0,
            0,
            2,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            0,
            0,
            0,
            9,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            0,
            0
        };
        Console.WriteLine(string.Format("blueScore:{0}", string.Join(" ", blueScore)));
        int __expected = 300;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SegmentDrawing().maxScore(x, y, redScore, blueScore);
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
