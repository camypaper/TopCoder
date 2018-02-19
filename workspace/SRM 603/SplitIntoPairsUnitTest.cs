using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, 5, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            case 5: Example5(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] A = Scanner.In.int_array();
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        int X = Scanner.In.@int();
        Console.WriteLine("X:{0}", X);
        int __result = new SplitIntoPairs().makepairs(A, X);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] A, int X)
    {
                        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
                        Console.WriteLine("X:{0}", X);
                int __result = new SplitIntoPairs().makepairs(A, X);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] A = new int[] {
            2,
            -1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int X = -1;
        Console.WriteLine("X:{0}", X);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SplitIntoPairs().makepairs(A, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            1,
            -1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int X = -1;
        Console.WriteLine("X:{0}", X);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SplitIntoPairs().makepairs(A, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            -5,
            -4,
            2,
            3
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int X = -1;
        Console.WriteLine("X:{0}", X);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SplitIntoPairs().makepairs(A, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            5,
            -7,
            8,
            -2,
            -5,
            3
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int X = -7;
        Console.WriteLine("X:{0}", X);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SplitIntoPairs().makepairs(A, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            3,
            4,
            5,
            6,
            6,
            -6,
            -4,
            -10,
            -1,
            -9
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int X = -2;
        Console.WriteLine("X:{0}", X);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SplitIntoPairs().makepairs(A, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] A = new int[] {
            1000000,
            1000000
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int X = -5;
        Console.WriteLine("X:{0}", X);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SplitIntoPairs().makepairs(A, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
