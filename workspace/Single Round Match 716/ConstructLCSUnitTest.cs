using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int ab, int bc, int ca,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("ab:{0}", ab);
        Console.WriteLine("bc:{0}", bc);
        Console.WriteLine("ca:{0}", ca);
        }
        string __result = new ConstructLCS().construct(ab, bc, ca);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int ab = 3;
        Console.WriteLine("ab:{0}", ab);
        int bc = 4;
        Console.WriteLine("bc:{0}", bc);
        int ca = 2;
        Console.WriteLine("ca:{0}", ca);
        string __expected = "101 1010101 1111";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConstructLCS().construct(ab, bc, ca);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int ab = 7;
        Console.WriteLine("ab:{0}", ab);
        int bc = 4;
        Console.WriteLine("bc:{0}", bc);
        int ca = 4;
        Console.WriteLine("ca:{0}", ca);
        string __expected = "10101010 1010101 1011";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConstructLCS().construct(ab, bc, ca);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int ab = 8;
        Console.WriteLine("ab:{0}", ab);
        int bc = 7;
        Console.WriteLine("bc:{0}", bc);
        int ca = 8;
        Console.WriteLine("ca:{0}", ca);
        string __expected = "110101001011 010101101 10101010";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConstructLCS().construct(ab, bc, ca);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int ab = 8;
        Console.WriteLine("ab:{0}", ab);
        int bc = 6;
        Console.WriteLine("bc:{0}", bc);
        int ca = 7;
        Console.WriteLine("ca:{0}", ca);
        string __expected = "110101010 10101010 1111010";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConstructLCS().construct(ab, bc, ca);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int ab = 15;
        Console.WriteLine("ab:{0}", ab);
        int bc = 17;
        Console.WriteLine("bc:{0}", bc);
        int ca = 19;
        Console.WriteLine("ca:{0}", ca);
        string __expected = "000100101101111011000 11110111010011101010 100100001010101001010101000011111";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConstructLCS().construct(ab, bc, ca);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int ab = 50;
        Console.WriteLine("ab:{0}", ab);
        int bc = 50;
        Console.WriteLine("bc:{0}", bc);
        int ca = 50;
        Console.WriteLine("ca:{0}", ca);
        string __expected = "11111111111111111111111111111111111111111111111111 11111111111111111111111111111111111111111111111111 11111111111111111111111111111111111111111111111111";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ConstructLCS().construct(ab, bc, ca);
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
