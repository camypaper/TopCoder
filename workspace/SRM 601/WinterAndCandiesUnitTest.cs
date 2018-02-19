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
        int[] type = Scanner.In.int_array();
        Console.WriteLine(string.Format("type:{0}", string.Join(" ",type)));
        int __result = new WinterAndCandies().getNumber(type);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] type)
    {
                        Console.WriteLine(string.Format("type:{0}", string.Join(" ",type)));
                int __result = new WinterAndCandies().getNumber(type);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] type = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("type:{0}", string.Join(" ", type)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndCandies().getNumber(type);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] type = new int[] {
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("type:{0}", string.Join(" ", type)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndCandies().getNumber(type);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] type = new int[] {
            1,
            3,
            2,
            5,
            7,
            4,
            5,
            4
        };
        Console.WriteLine(string.Format("type:{0}", string.Join(" ", type)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndCandies().getNumber(type);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] type = new int[] {
            1,
            1,
            2,
            2,
            3,
            3,
            4,
            4,
            5,
            5
        };
        Console.WriteLine(string.Format("type:{0}", string.Join(" ", type)));
        int __expected = 62;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndCandies().getNumber(type);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] type = new int[] {
            2
        };
        Console.WriteLine(string.Format("type:{0}", string.Join(" ", type)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndCandies().getNumber(type);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
