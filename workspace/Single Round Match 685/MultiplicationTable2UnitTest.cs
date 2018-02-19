using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int[] table)
    {
        Console.WriteLine(string.Format("table:{0}", string.Join(" ",table)));
        int __result = new MultiplicationTable2().minimalGoodSet(table);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] table = new int[] {
            1,
            1,
            2,
            3,
            1,
            0,
            3,
            2,
            2,
            0,
            1,
            3,
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MultiplicationTable2().minimalGoodSet(table);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] table = new int[] {
            0,
            1,
            2,
            3,
            1,
            2,
            3,
            0,
            2,
            3,
            0,
            1,
            3,
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MultiplicationTable2().minimalGoodSet(table);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] table = new int[] {
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            2,
            3,
            3,
            3,
            3,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MultiplicationTable2().minimalGoodSet(table);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] table = new int[] {
            0
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MultiplicationTable2().minimalGoodSet(table);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
