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
    public void ManualTest(int[] x, int[] y)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        int __result = new SpecialCells().guess(x, y);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SpecialCells().guess(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SpecialCells().guess(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            1,
            2,
            1,
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            3,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SpecialCells().guess(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            1,
            1,
            2,
            2,
            3,
            3,
            4,
            4,
            5,
            5,
            6,
            6,
            7,
            7,
            8,
            8,
            9,
            9
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            3,
            1,
            2,
            3,
            1,
            2,
            3,
            1,
            2,
            3,
            1,
            2,
            3,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SpecialCells().guess(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            1,
            100000
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            100000
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SpecialCells().guess(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
