using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int Ns, int Nb, int L,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("Ns:{0}", Ns);
        Console.WriteLine("Nb:{0}", Nb);
        Console.WriteLine("L:{0}", L);
        }
        int __result = new CubePacking().getMinimumVolume(Ns, Nb, L);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int Ns = 2;
        Console.WriteLine("Ns:{0}", Ns);
        int Nb = 2;
        Console.WriteLine("Nb:{0}", Nb);
        int L = 2;
        Console.WriteLine("L:{0}", L);
        int __expected = 20;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CubePacking().getMinimumVolume(Ns, Nb, L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int Ns = 19;
        Console.WriteLine("Ns:{0}", Ns);
        int Nb = 1;
        Console.WriteLine("Nb:{0}", Nb);
        int L = 2;
        Console.WriteLine("L:{0}", L);
        int __expected = 27;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CubePacking().getMinimumVolume(Ns, Nb, L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int Ns = 51;
        Console.WriteLine("Ns:{0}", Ns);
        int Nb = 7;
        Console.WriteLine("Nb:{0}", Nb);
        int L = 5;
        Console.WriteLine("L:{0}", L);
        int __expected = 950;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CubePacking().getMinimumVolume(Ns, Nb, L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int Ns = 12345;
        Console.WriteLine("Ns:{0}", Ns);
        int Nb = 987;
        Console.WriteLine("Nb:{0}", Nb);
        int L = 10;
        Console.WriteLine("L:{0}", L);
        int __expected = 999400;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new CubePacking().getMinimumVolume(Ns, Nb, L);
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
