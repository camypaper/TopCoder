using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int N, int maxR, int maxG, int maxB, int startR, int startG, int startB, int d1, int d2,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("maxR:{0}", maxR);
        Console.WriteLine("maxG:{0}", maxG);
        Console.WriteLine("maxB:{0}", maxB);
        Console.WriteLine("startR:{0}", startR);
        Console.WriteLine("startG:{0}", startG);
        Console.WriteLine("startB:{0}", startB);
        Console.WriteLine("d1:{0}", d1);
        Console.WriteLine("d2:{0}", d2);
        }
        double __result = new RandomColoring().getProbability(N, maxR, maxG, maxB, startR, startG, startB, d1, d2);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int maxR = 5;
        Console.WriteLine("maxR:{0}", maxR);
        int maxG = 1;
        Console.WriteLine("maxG:{0}", maxG);
        int maxB = 1;
        Console.WriteLine("maxB:{0}", maxB);
        int startR = 2;
        Console.WriteLine("startR:{0}", startR);
        int startG = 0;
        Console.WriteLine("startG:{0}", startG);
        int startB = 0;
        Console.WriteLine("startB:{0}", startB);
        int d1 = 0;
        Console.WriteLine("d1:{0}", d1);
        int d2 = 1;
        Console.WriteLine("d2:{0}", d2);
        double __expected = 0.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RandomColoring().getProbability(N, maxR, maxG, maxB, startR, startG, startB, d1, d2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int maxR = 5;
        Console.WriteLine("maxR:{0}", maxR);
        int maxG = 1;
        Console.WriteLine("maxG:{0}", maxG);
        int maxB = 1;
        Console.WriteLine("maxB:{0}", maxB);
        int startR = 2;
        Console.WriteLine("startR:{0}", startR);
        int startG = 0;
        Console.WriteLine("startG:{0}", startG);
        int startB = 0;
        Console.WriteLine("startB:{0}", startB);
        int d1 = 0;
        Console.WriteLine("d1:{0}", d1);
        int d2 = 1;
        Console.WriteLine("d2:{0}", d2);
        double __expected = 0.22222222222222227;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RandomColoring().getProbability(N, maxR, maxG, maxB, startR, startG, startB, d1, d2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int N = 7;
        Console.WriteLine("N:{0}", N);
        int maxR = 4;
        Console.WriteLine("maxR:{0}", maxR);
        int maxG = 2;
        Console.WriteLine("maxG:{0}", maxG);
        int maxB = 2;
        Console.WriteLine("maxB:{0}", maxB);
        int startR = 0;
        Console.WriteLine("startR:{0}", startR);
        int startG = 0;
        Console.WriteLine("startG:{0}", startG);
        int startB = 0;
        Console.WriteLine("startB:{0}", startB);
        int d1 = 3;
        Console.WriteLine("d1:{0}", d1);
        int d2 = 3;
        Console.WriteLine("d2:{0}", d2);
        double __expected = 1.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RandomColoring().getProbability(N, maxR, maxG, maxB, startR, startG, startB, d1, d2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int maxR = 7;
        Console.WriteLine("maxR:{0}", maxR);
        int maxG = 8;
        Console.WriteLine("maxG:{0}", maxG);
        int maxB = 9;
        Console.WriteLine("maxB:{0}", maxB);
        int startR = 1;
        Console.WriteLine("startR:{0}", startR);
        int startG = 2;
        Console.WriteLine("startG:{0}", startG);
        int startB = 3;
        Console.WriteLine("startB:{0}", startB);
        int d1 = 0;
        Console.WriteLine("d1:{0}", d1);
        int d2 = 10;
        Console.WriteLine("d2:{0}", d2);
        double __expected = 0.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RandomColoring().getProbability(N, maxR, maxG, maxB, startR, startG, startB, d1, d2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int maxR = 7;
        Console.WriteLine("maxR:{0}", maxR);
        int maxG = 8;
        Console.WriteLine("maxG:{0}", maxG);
        int maxB = 9;
        Console.WriteLine("maxB:{0}", maxB);
        int startR = 1;
        Console.WriteLine("startR:{0}", startR);
        int startG = 2;
        Console.WriteLine("startG:{0}", startG);
        int startB = 3;
        Console.WriteLine("startB:{0}", startB);
        int d1 = 4;
        Console.WriteLine("d1:{0}", d1);
        int d2 = 10;
        Console.WriteLine("d2:{0}", d2);
        double __expected = 0.37826245943967396;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RandomColoring().getProbability(N, maxR, maxG, maxB, startR, startG, startB, d1, d2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int maxR = 3;
        Console.WriteLine("maxR:{0}", maxR);
        int maxG = 2;
        Console.WriteLine("maxG:{0}", maxG);
        int maxB = 2;
        Console.WriteLine("maxB:{0}", maxB);
        int startR = 1;
        Console.WriteLine("startR:{0}", startR);
        int startG = 0;
        Console.WriteLine("startG:{0}", startG);
        int startB = 0;
        Console.WriteLine("startB:{0}", startB);
        int d1 = 1;
        Console.WriteLine("d1:{0}", d1);
        int d2 = 2;
        Console.WriteLine("d2:{0}", d2);
        double __expected = 0.09090909090909148;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RandomColoring().getProbability(N, maxR, maxG, maxB, startR, startG, startB, d1, d2);
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
