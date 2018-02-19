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
    public void ManualTest(int[] tree)
    {
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ",tree)));
        int __result = new TreeAndVertex().get(tree);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] tree = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeAndVertex().get(tree);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] tree = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeAndVertex().get(tree);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] tree = new int[] {
            0,
            0,
            2,
            2
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeAndVertex().get(tree);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] tree = new int[] {
            0,
            0,
            0,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeAndVertex().get(tree);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] tree = new int[] {
            0,
            1,
            2,
            0,
            1,
            5,
            6,
            1,
            7,
            4,
            2,
            5,
            5,
            8,
            6,
            2,
            14,
            12,
            18,
            10,
            0,
            6,
            18,
            2,
            20,
            11,
            0,
            11,
            7,
            12,
            17,
            3,
            18,
            31,
            14,
            34,
            30,
            11,
            9
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeAndVertex().get(tree);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
