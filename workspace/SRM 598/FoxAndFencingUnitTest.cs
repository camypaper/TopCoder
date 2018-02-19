using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int mov1, int mov2, int rng1, int rng2, int d,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("mov1:{0}", mov1);
        Console.WriteLine("mov2:{0}", mov2);
        Console.WriteLine("rng1:{0}", rng1);
        Console.WriteLine("rng2:{0}", rng2);
        Console.WriteLine("d:{0}", d);
        }
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int mov1 = 1;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 58;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 1;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 58;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 2;
        Console.WriteLine("d:{0}", d);
        string __expected = "Ciel";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int mov1 = 2;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 1;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 1;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 100;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 50;
        Console.WriteLine("d:{0}", d);
        string __expected = "Liss";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int mov1 = 2;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 1;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 1;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 100;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 150;
        Console.WriteLine("d:{0}", d);
        string __expected = "Draw";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int mov1 = 100;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 100;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 100;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 100;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 100000000;
        Console.WriteLine("d:{0}", d);
        string __expected = "Draw";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int mov1 = 100;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 1;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 100;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 1;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 100000000;
        Console.WriteLine("d:{0}", d);
        string __expected = "Ciel";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int mov1 = 100;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 1;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 100;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 250;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 100000000;
        Console.WriteLine("d:{0}", d);
        string __expected = "Draw";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example6(bool fast = false)
    {
        Console.WriteLine("Example6");
        int mov1 = 100;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 1;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 100;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 150;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 100000000;
        Console.WriteLine("d:{0}", d);
        string __expected = "Ciel";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example7(bool fast = false)
    {
        Console.WriteLine("Example7");
        int mov1 = 100;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 50;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 100;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 1;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 100000000;
        Console.WriteLine("d:{0}", d);
        string __expected = "Ciel";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example8(bool fast = false)
    {
        Console.WriteLine("Example8");
        int mov1 = 100;
        Console.WriteLine("mov1:{0}", mov1);
        int mov2 = 150;
        Console.WriteLine("mov2:{0}", mov2);
        int rng1 = 100;
        Console.WriteLine("rng1:{0}", rng1);
        int rng2 = 1;
        Console.WriteLine("rng2:{0}", rng2);
        int d = 100000000;
        Console.WriteLine("d:{0}", d);
        string __expected = "Draw";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndFencing().WhoCanWin(mov1, mov2, rng1, rng2, d);
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
