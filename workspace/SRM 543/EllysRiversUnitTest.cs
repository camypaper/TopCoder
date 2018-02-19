using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int length, int walk, int[] width, int[] speed,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("length:{0}", length);
        Console.WriteLine("walk:{0}", walk);
        Console.WriteLine(string.Format("width:{0}", string.Join(" ",width)));
        Console.WriteLine(string.Format("speed:{0}", string.Join(" ",speed)));
        }
        double __result = new EllysRivers().getMin(length, walk, width, speed);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int length = 10;
        Console.WriteLine("length:{0}", length);
        int walk = 3;
        Console.WriteLine("walk:{0}", walk);
        int[] width = new int[] {
            5,
            2,
            3
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        int[] speed = new int[] {
            5,
            2,
            7
        };
        Console.WriteLine(string.Format("speed:{0}", string.Join(" ", speed)));
        double __expected = 3.231651964071508;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new EllysRivers().getMin(length, walk, width, speed);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int length = 10000;
        Console.WriteLine("length:{0}", length);
        int walk = 211;
        Console.WriteLine("walk:{0}", walk);
        int[] width = new int[] {
            911
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        int[] speed = new int[] {
            207
        };
        Console.WriteLine(string.Format("speed:{0}", string.Join(" ", speed)));
        double __expected = 48.24623664712219;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new EllysRivers().getMin(length, walk, width, speed);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int length = 1337;
        Console.WriteLine("length:{0}", length);
        int walk = 2;
        Console.WriteLine("walk:{0}", walk);
        int[] width = new int[] {
            100,
            200,
            300,
            400
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        int[] speed = new int[] {
            11,
            12,
            13,
            14
        };
        Console.WriteLine(string.Format("speed:{0}", string.Join(" ", speed)));
        double __expected = 128.57830549575695;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new EllysRivers().getMin(length, walk, width, speed);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int length = 77;
        Console.WriteLine("length:{0}", length);
        int walk = 119;
        Console.WriteLine("walk:{0}", walk);
        int[] width = new int[] {
            11,
            12,
            13,
            14
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        int[] speed = new int[] {
            100,
            200,
            300,
            400
        };
        Console.WriteLine(string.Format("speed:{0}", string.Join(" ", speed)));
        double __expected = 0.3842077071089629;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new EllysRivers().getMin(length, walk, width, speed);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int length = 7134;
        Console.WriteLine("length:{0}", length);
        int walk = 1525;
        Console.WriteLine("walk:{0}", walk);
        int[] width = new int[] {
            11567,
            19763,
            11026,
            10444,
            24588,
            22263,
            17709,
            11181,
            15292,
            28895,
            15039,
            18744,
            19985,
            13795,
            26697,
            18812,
            25655,
            13620,
            28926,
            12393
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        int[] speed = new int[] {
            1620,
            1477,
            2837,
            2590,
            1692,
            2270,
            1655,
            1078,
            2683,
            1475,
            1383,
            1153,
            1862,
            1770,
            1671,
            2318,
            2197,
            1768,
            1979,
            1057
        };
        Console.WriteLine(string.Format("speed:{0}", string.Join(" ", speed)));
        double __expected = 214.6509731258811;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new EllysRivers().getMin(length, walk, width, speed);
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
