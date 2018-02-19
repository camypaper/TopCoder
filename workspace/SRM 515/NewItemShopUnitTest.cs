using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int swords, string[] customers,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("swords:{0}", swords);
        Console.WriteLine(string.Format("customers:{0}", string.Join(" ",customers)));
        }
        double __result = new NewItemShop().getMaximum(swords, customers);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int swords = 1;
        Console.WriteLine("swords:{0}", swords);
        string[] customers = new string[] {
            "8,1,80 16,100,11",
            "12,10,100"
        };
        Console.WriteLine(string.Format("customers:{0}", string.Join(" ", customers)));
        double __expected = 19.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new NewItemShop().getMaximum(swords, customers);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int swords = 2;
        Console.WriteLine("swords:{0}", swords);
        string[] customers = new string[] {
            "8,1,80 16,100,11",
            "12,10,100"
        };
        Console.WriteLine(string.Format("customers:{0}", string.Join(" ", customers)));
        double __expected = 21.8;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new NewItemShop().getMaximum(swords, customers);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int swords = 1;
        Console.WriteLine("swords:{0}", swords);
        string[] customers = new string[] {
            "0,90,25 2,90,25 4,90,25 6,90,25",
            "7,100,80"
        };
        Console.WriteLine(string.Format("customers:{0}", string.Join(" ", customers)));
        double __expected = 90.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new NewItemShop().getMaximum(swords, customers);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int swords = 3;
        Console.WriteLine("swords:{0}", swords);
        string[] customers = new string[] {
            "17,31,41 20,59,26 23,53,5",
            "19,89,79",
            "16,32,38 22,46,26",
            "18,43,38 21,32,7"
        };
        Console.WriteLine(string.Format("customers:{0}", string.Join(" ", customers)));
        double __expected = 135.5121414;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new NewItemShop().getMaximum(swords, customers);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int swords = 5;
        Console.WriteLine("swords:{0}", swords);
        string[] customers = new string[] {
            "1,1,10",
            "2,2,9",
            "3,3,8",
            "4,4,7",
            "5,5,6",
            "6,6,5",
            "7,7,4",
            "8,8,3",
            "9,9,2",
            "10,10,1"
        };
        Console.WriteLine(string.Format("customers:{0}", string.Join(" ", customers)));
        double __expected = 2.1999744634845344;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new NewItemShop().getMaximum(swords, customers);
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
