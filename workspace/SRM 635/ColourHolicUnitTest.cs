using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);    }
    public void ManualTest(int[] n)
    {
        Console.WriteLine(string.Format("n:{0}", string.Join(" ",n)));
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] n = new int[] {
            1,
            0,
            2,
            3
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] n = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] n = new int[] {
            42,
            42,
            42,
            9001
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] n = new int[] {
            8,
            0,
            0,
            8
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] n = new int[] {
            0,
            5,
            1,
            3
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] n = new int[] {
            4,
            2,
            1,
            3
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int __expected = 1074;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] n = new int[] {
            15,
            900,
            357,
            22
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int[] n = new int[] {
            110,
            30000,
            200,
            29999
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int __expected = 118115350;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColourHolic().countSequences(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
