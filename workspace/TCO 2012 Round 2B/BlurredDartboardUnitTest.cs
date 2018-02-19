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
    public void ManualTest(int[] points, int P)
    {
        Console.WriteLine(string.Format("points:{0}", string.Join(" ",points)));
        Console.WriteLine("P:{0}", P);
        int __result = new BlurredDartboard().minThrows(points, P);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] points = new int[] {
            0,
            3,
            4,
            0,
            0
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        int P = 8;
        Console.WriteLine("P:{0}", P);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlurredDartboard().minThrows(points, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] points = new int[] {
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        int P = 15;
        Console.WriteLine("P:{0}", P);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlurredDartboard().minThrows(points, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] points = new int[] {
            4,
            7,
            8,
            1,
            3,
            2,
            6,
            5
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        int P = 2012;
        Console.WriteLine("P:{0}", P);
        int __expected = 252;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlurredDartboard().minThrows(points, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] points = new int[] {
            0,
            0,
            5,
            0,
            0,
            0,
            1,
            3,
            0,
            0
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        int P = 2012;
        Console.WriteLine("P:{0}", P);
        int __expected = 307;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlurredDartboard().minThrows(points, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] points = new int[] {
            0,
            2,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            9,
            0,
            0,
            6,
            0,
            0,
            0,
            4,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        int P = 1000000000;
        Console.WriteLine("P:{0}", P);
        int __expected = 84656087;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlurredDartboard().minThrows(points, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
