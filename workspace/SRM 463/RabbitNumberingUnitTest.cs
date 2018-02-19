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
    public void ManualTest(int[] maxNumber)
    {
        Console.WriteLine(string.Format("maxNumber:{0}", string.Join(" ",maxNumber)));
        int __result = new RabbitNumbering().theCount(maxNumber);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] maxNumber = new int[] {
            5
        };
        Console.WriteLine(string.Format("maxNumber:{0}", string.Join(" ", maxNumber)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumbering().theCount(maxNumber);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] maxNumber = new int[] {
            4,
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("maxNumber:{0}", string.Join(" ", maxNumber)));
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumbering().theCount(maxNumber);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] maxNumber = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("maxNumber:{0}", string.Join(" ", maxNumber)));
        int __expected = 35;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumbering().theCount(maxNumber);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] maxNumber = new int[] {
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("maxNumber:{0}", string.Join(" ", maxNumber)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumbering().theCount(maxNumber);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] maxNumber = new int[] {
            25,
            489,
            76,
            98,
            704,
            98,
            768,
            39,
            697,
            8,
            56,
            74,
            36,
            95,
            87,
            2,
            968,
            4,
            920,
            54,
            873,
            90
        };
        Console.WriteLine(string.Format("maxNumber:{0}", string.Join(" ", maxNumber)));
        int __expected = 676780400;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumbering().theCount(maxNumber);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
