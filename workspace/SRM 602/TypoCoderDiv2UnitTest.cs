using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] rating = Scanner.In.int_array();
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ",rating)));
        int __result = new TypoCoderDiv2().count(rating);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] rating)
    {
                        Console.WriteLine(string.Format("rating:{0}", string.Join(" ",rating)));
                int __result = new TypoCoderDiv2().count(rating);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] rating = new int[] {
            1000,
            1200,
            1199
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv2().count(rating);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] rating = new int[] {
            1500,
            2200,
            900,
            3000
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv2().count(rating);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] rating = new int[] {
            600,
            700,
            800,
            900,
            1000,
            1100,
            1199
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv2().count(rating);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] rating = new int[] {
            0,
            4000,
            0,
            4000,
            4000,
            0,
            0
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv2().count(rating);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] rating = new int[] {
            575,
            1090,
            3271,
            2496,
            859,
            2708,
            3774,
            2796,
            1616,
            2552,
            3783,
            2435,
            1111,
            526,
            562
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv2().count(rating);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
