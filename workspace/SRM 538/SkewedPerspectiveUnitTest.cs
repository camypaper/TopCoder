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
    public void ManualTest(int[] cubes, int B, int w)
    {
        Console.WriteLine(string.Format("cubes:{0}", string.Join(" ",cubes)));
        Console.WriteLine("B:{0}", B);
        Console.WriteLine("w:{0}", w);
        int __result = new SkewedPerspective().countThem(cubes, B, w);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] cubes = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("cubes:{0}", string.Join(" ", cubes)));
        int B = 1;
        Console.WriteLine("B:{0}", B);
        int w = 2;
        Console.WriteLine("w:{0}", w);
        int __expected = 19;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkewedPerspective().countThem(cubes, B, w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] cubes = new int[] {
            1
        };
        Console.WriteLine(string.Format("cubes:{0}", string.Join(" ", cubes)));
        int B = 3;
        Console.WriteLine("B:{0}", B);
        int w = 2;
        Console.WriteLine("w:{0}", w);
        int __expected = 19;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkewedPerspective().countThem(cubes, B, w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] cubes = new int[] {
        };
        Console.WriteLine(string.Format("cubes:{0}", string.Join(" ", cubes)));
        int B = 5;
        Console.WriteLine("B:{0}", B);
        int w = 5;
        Console.WriteLine("w:{0}", w);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkewedPerspective().countThem(cubes, B, w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] cubes = new int[] {
            7,
            7,
            7
        };
        Console.WriteLine(string.Format("cubes:{0}", string.Join(" ", cubes)));
        int B = 0;
        Console.WriteLine("B:{0}", B);
        int w = 8;
        Console.WriteLine("w:{0}", w);
        int __expected = 301226488;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkewedPerspective().countThem(cubes, B, w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
