using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] cityX, int[] cityY, int[] villageX, int[] villageY,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("cityX:{0}", string.Join(" ",cityX)));
        Console.WriteLine(string.Format("cityY:{0}", string.Join(" ",cityY)));
        Console.WriteLine(string.Format("villageX:{0}", string.Join(" ",villageX)));
        Console.WriteLine(string.Format("villageY:{0}", string.Join(" ",villageY)));
        }
        double __result = new KingdomXCitiesandVillages().determineLength(cityX, cityY, villageX, villageY);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] cityX = new int[] {
            3
        };
        Console.WriteLine(string.Format("cityX:{0}", string.Join(" ", cityX)));
        int[] cityY = new int[] {
            0
        };
        Console.WriteLine(string.Format("cityY:{0}", string.Join(" ", cityY)));
        int[] villageX = new int[] {
            3,
            3
        };
        Console.WriteLine(string.Format("villageX:{0}", string.Join(" ", villageX)));
        int[] villageY = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("villageY:{0}", string.Join(" ", villageY)));
        double __expected = 2.5;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new KingdomXCitiesandVillages().determineLength(cityX, cityY, villageX, villageY);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] cityX = new int[] {
            1,
            4,
            7,
            10
        };
        Console.WriteLine(string.Format("cityX:{0}", string.Join(" ", cityX)));
        int[] cityY = new int[] {
            5,
            5,
            5,
            5
        };
        Console.WriteLine(string.Format("cityY:{0}", string.Join(" ", cityY)));
        int[] villageX = new int[] {
            1,
            4,
            7,
            10
        };
        Console.WriteLine(string.Format("villageX:{0}", string.Join(" ", villageX)));
        int[] villageY = new int[] {
            4,
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("villageY:{0}", string.Join(" ", villageY)));
        double __expected = 4.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new KingdomXCitiesandVillages().determineLength(cityX, cityY, villageX, villageY);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] cityX = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("cityX:{0}", string.Join(" ", cityX)));
        int[] cityY = new int[] {
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("cityY:{0}", string.Join(" ", cityY)));
        int[] villageX = new int[] {
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("villageX:{0}", string.Join(" ", villageX)));
        int[] villageY = new int[] {
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("villageY:{0}", string.Join(" ", villageY)));
        double __expected = 4.166666666666667;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new KingdomXCitiesandVillages().determineLength(cityX, cityY, villageX, villageY);
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
