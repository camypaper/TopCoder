using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] firstDie, int[] secondDie, int X,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("firstDie:{0}", string.Join(" ",firstDie)));
        Console.WriteLine(string.Format("secondDie:{0}", string.Join(" ",secondDie)));
        Console.WriteLine("X:{0}", X);
        }
        double __result = new KingdomAndDice().newFairness(firstDie, secondDie, X);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] firstDie = new int[] {
            0,
            2,
            7,
            0
        };
        Console.WriteLine(string.Format("firstDie:{0}", string.Join(" ", firstDie)));
        int[] secondDie = new int[] {
            6,
            3,
            8,
            10
        };
        Console.WriteLine(string.Format("secondDie:{0}", string.Join(" ", secondDie)));
        int X = 12;
        Console.WriteLine("X:{0}", X);
        double __expected = 0.4375;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new KingdomAndDice().newFairness(firstDie, secondDie, X);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] firstDie = new int[] {
            0,
            2,
            7,
            0
        };
        Console.WriteLine(string.Format("firstDie:{0}", string.Join(" ", firstDie)));
        int[] secondDie = new int[] {
            6,
            3,
            8,
            10
        };
        Console.WriteLine(string.Format("secondDie:{0}", string.Join(" ", secondDie)));
        int X = 10;
        Console.WriteLine("X:{0}", X);
        double __expected = 0.375;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new KingdomAndDice().newFairness(firstDie, secondDie, X);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] firstDie = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("firstDie:{0}", string.Join(" ", firstDie)));
        int[] secondDie = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("secondDie:{0}", string.Join(" ", secondDie)));
        int X = 47;
        Console.WriteLine("X:{0}", X);
        double __expected = 0.5;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new KingdomAndDice().newFairness(firstDie, secondDie, X);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] firstDie = new int[] {
            19,
            50,
            4
        };
        Console.WriteLine(string.Format("firstDie:{0}", string.Join(" ", firstDie)));
        int[] secondDie = new int[] {
            26,
            100,
            37
        };
        Console.WriteLine(string.Format("secondDie:{0}", string.Join(" ", secondDie)));
        int X = 1000;
        Console.WriteLine("X:{0}", X);
        double __expected = 0.2222222222222222;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new KingdomAndDice().newFairness(firstDie, secondDie, X);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] firstDie = new int[] {
            6371,
            0,
            6256,
            1852,
            0,
            0,
            6317,
            3004,
            5218,
            9012
        };
        Console.WriteLine(string.Format("firstDie:{0}", string.Join(" ", firstDie)));
        int[] secondDie = new int[] {
            1557,
            6318,
            1560,
            4519,
            2012,
            6316,
            6315,
            1559,
            8215,
            1561
        };
        Console.WriteLine(string.Format("secondDie:{0}", string.Join(" ", secondDie)));
        int X = 10000;
        Console.WriteLine("X:{0}", X);
        double __expected = 0.49;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new KingdomAndDice().newFairness(firstDie, secondDie, X);
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
