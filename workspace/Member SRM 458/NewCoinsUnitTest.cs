using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);    }
    public void ManualTest(int[] price)
    {
        Console.WriteLine(string.Format("price:{0}", string.Join(" ",price)));
        int __result = new NewCoins().minCoins(price);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] price = new int[] {
            25,
            102
        };
        Console.WriteLine(string.Format("price:{0}", string.Join(" ", price)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NewCoins().minCoins(price);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] price = new int[] {
            58
        };
        Console.WriteLine(string.Format("price:{0}", string.Join(" ", price)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NewCoins().minCoins(price);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] price = new int[] {
            1,
            4,
            5,
            9,
            16
        };
        Console.WriteLine(string.Format("price:{0}", string.Join(" ", price)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NewCoins().minCoins(price);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] price = new int[] {
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("price:{0}", string.Join(" ", price)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NewCoins().minCoins(price);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] price = new int[] {
            28,
            569,
            587,
            256,
            15,
            87,
            927,
            4,
            589,
            73,
            98,
            87,
            597,
            163,
            6,
            498
        };
        Console.WriteLine(string.Format("price:{0}", string.Join(" ", price)));
        int __expected = 62;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NewCoins().minCoins(price);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
