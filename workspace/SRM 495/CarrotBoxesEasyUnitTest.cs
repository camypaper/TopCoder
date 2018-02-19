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
    public void ManualTest(int[] carrots, int K)
    {
        Console.WriteLine(string.Format("carrots:{0}", string.Join(" ",carrots)));
        Console.WriteLine("K:{0}", K);
        int __result = new CarrotBoxesEasy().theIndex(carrots, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] carrots = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("carrots:{0}", string.Join(" ", carrots)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotBoxesEasy().theIndex(carrots, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] carrots = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("carrots:{0}", string.Join(" ", carrots)));
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotBoxesEasy().theIndex(carrots, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] carrots = new int[] {
            4,
            9,
            5
        };
        Console.WriteLine(string.Format("carrots:{0}", string.Join(" ", carrots)));
        int K = 18;
        Console.WriteLine("K:{0}", K);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotBoxesEasy().theIndex(carrots, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] carrots = new int[] {
            13,
            75,
            24,
            55
        };
        Console.WriteLine(string.Format("carrots:{0}", string.Join(" ", carrots)));
        int K = 140;
        Console.WriteLine("K:{0}", K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotBoxesEasy().theIndex(carrots, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] carrots = new int[] {
            14,
            36,
            52,
            86,
            27,
            97,
            3,
            67
        };
        Console.WriteLine(string.Format("carrots:{0}", string.Join(" ", carrots)));
        int K = 300;
        Console.WriteLine("K:{0}", K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotBoxesEasy().theIndex(carrots, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
