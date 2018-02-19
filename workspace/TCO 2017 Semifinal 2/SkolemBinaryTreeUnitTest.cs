using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int k,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("k:{0}", k);
        }
        int[] __result = new SkolemBinaryTree().construct(k);
        if(!__fast)
        {
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            0,
            1,
            1,
            5,
            5,
            6,
            6,
            2,
            2,
            4,
            4,
            3,
            3,
            7
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new SkolemBinaryTree().construct(k);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            3,
            4,
            4,
            2,
            2,
            1,
            1,
            0,
            1,
            5
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new SkolemBinaryTree().construct(k);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int k = 5;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            4,
            9,
            9,
            3,
            3,
            5,
            5,
            2,
            2,
            6,
            6,
            8,
            8,
            0,
            0,
            1,
            1,
            7
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new SkolemBinaryTree().construct(k);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
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
