using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] cars, int[] districts, string[] roads, int inverseWalkSpeed, int inverseDriveSpeed,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("cars:{0}", string.Join(" ",cars)));
        Console.WriteLine(string.Format("districts:{0}", string.Join(" ",districts)));
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ",roads)));
        Console.WriteLine("inverseWalkSpeed:{0}", inverseWalkSpeed);
        Console.WriteLine("inverseDriveSpeed:{0}", inverseDriveSpeed);
        }
        int __result = new SlimeXGrandSlimeAuto().travel(cars, districts, roads, inverseWalkSpeed, inverseDriveSpeed);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] cars = new int[] {
            1
        };
        Console.WriteLine(string.Format("cars:{0}", string.Join(" ", cars)));
        int[] districts = new int[] {
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("districts:{0}", string.Join(" ", districts)));
        string[] roads = new string[] {
            "..0.",
            "...1",
            "0..2",
            ".12."
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int inverseWalkSpeed = 5;
        Console.WriteLine("inverseWalkSpeed:{0}", inverseWalkSpeed);
        int inverseDriveSpeed = 1;
        Console.WriteLine("inverseDriveSpeed:{0}", inverseDriveSpeed);
        int __expected = 36;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SlimeXGrandSlimeAuto().travel(cars, districts, roads, inverseWalkSpeed, inverseDriveSpeed);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] cars = new int[] {
            1
        };
        Console.WriteLine(string.Format("cars:{0}", string.Join(" ", cars)));
        int[] districts = new int[] {
            2,
            0
        };
        Console.WriteLine(string.Format("districts:{0}", string.Join(" ", districts)));
        string[] roads = new string[] {
            ".A.",
            "A.B",
            ".B."
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int inverseWalkSpeed = 2;
        Console.WriteLine("inverseWalkSpeed:{0}", inverseWalkSpeed);
        int inverseDriveSpeed = 1;
        Console.WriteLine("inverseDriveSpeed:{0}", inverseDriveSpeed);
        int __expected = 262;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SlimeXGrandSlimeAuto().travel(cars, districts, roads, inverseWalkSpeed, inverseDriveSpeed);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] cars = new int[] {
            2,
            2
        };
        Console.WriteLine(string.Format("cars:{0}", string.Join(" ", cars)));
        int[] districts = new int[] {
            1,
            2,
            1
        };
        Console.WriteLine(string.Format("districts:{0}", string.Join(" ", districts)));
        string[] roads = new string[] {
            ".a4",
            "a..",
            "4.."
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int inverseWalkSpeed = 3;
        Console.WriteLine("inverseWalkSpeed:{0}", inverseWalkSpeed);
        int inverseDriveSpeed = 1;
        Console.WriteLine("inverseDriveSpeed:{0}", inverseDriveSpeed);
        int __expected = 95;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SlimeXGrandSlimeAuto().travel(cars, districts, roads, inverseWalkSpeed, inverseDriveSpeed);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] cars = new int[] {
            1
        };
        Console.WriteLine(string.Format("cars:{0}", string.Join(" ", cars)));
        int[] districts = new int[] {
            2,
            0
        };
        Console.WriteLine(string.Format("districts:{0}", string.Join(" ", districts)));
        string[] roads = new string[] {
            ".B.",
            "B.A",
            ".A."
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int inverseWalkSpeed = 2;
        Console.WriteLine("inverseWalkSpeed:{0}", inverseWalkSpeed);
        int inverseDriveSpeed = 1;
        Console.WriteLine("inverseDriveSpeed:{0}", inverseDriveSpeed);
        int __expected = 262;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SlimeXGrandSlimeAuto().travel(cars, districts, roads, inverseWalkSpeed, inverseDriveSpeed);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] cars = new int[] {
            2,
            5,
            1,
            2
        };
        Console.WriteLine(string.Format("cars:{0}", string.Join(" ", cars)));
        int[] districts = new int[] {
            1,
            5,
            1,
            2,
            4
        };
        Console.WriteLine(string.Format("districts:{0}", string.Join(" ", districts)));
        string[] roads = new string[] {
            ".12.4.",
            "1....7",
            "2..3..",
            "..3..5",
            "4.....",
            ".7.5.."
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int inverseWalkSpeed = 53;
        Console.WriteLine("inverseWalkSpeed:{0}", inverseWalkSpeed);
        int inverseDriveSpeed = 37;
        Console.WriteLine("inverseDriveSpeed:{0}", inverseDriveSpeed);
        int __expected = 1259;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SlimeXGrandSlimeAuto().travel(cars, districts, roads, inverseWalkSpeed, inverseDriveSpeed);
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
