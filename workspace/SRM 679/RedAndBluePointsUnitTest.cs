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
    public void ManualTest(int[] blueX, int[] blueY, int[] redX, int[] redY)
    {
        Console.WriteLine(string.Format("blueX:{0}", string.Join(" ",blueX)));
        Console.WriteLine(string.Format("blueY:{0}", string.Join(" ",blueY)));
        Console.WriteLine(string.Format("redX:{0}", string.Join(" ",redX)));
        Console.WriteLine(string.Format("redY:{0}", string.Join(" ",redY)));
        int __result = new RedAndBluePoints().find(blueX, blueY, redX, redY);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] blueX = new int[] {
            0,
            0,
            10,
            10
        };
        Console.WriteLine(string.Format("blueX:{0}", string.Join(" ", blueX)));
        int[] blueY = new int[] {
            0,
            10,
            0,
            10
        };
        Console.WriteLine(string.Format("blueY:{0}", string.Join(" ", blueY)));
        int[] redX = new int[] {
            100
        };
        Console.WriteLine(string.Format("redX:{0}", string.Join(" ", redX)));
        int[] redY = new int[] {
            120
        };
        Console.WriteLine(string.Format("redY:{0}", string.Join(" ", redY)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RedAndBluePoints().find(blueX, blueY, redX, redY);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] blueX = new int[] {
            0,
            0,
            10,
            10
        };
        Console.WriteLine(string.Format("blueX:{0}", string.Join(" ", blueX)));
        int[] blueY = new int[] {
            0,
            10,
            0,
            10
        };
        Console.WriteLine(string.Format("blueY:{0}", string.Join(" ", blueY)));
        int[] redX = new int[] {
            3
        };
        Console.WriteLine(string.Format("redX:{0}", string.Join(" ", redX)));
        int[] redY = new int[] {
            4
        };
        Console.WriteLine(string.Format("redY:{0}", string.Join(" ", redY)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RedAndBluePoints().find(blueX, blueY, redX, redY);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] blueX = new int[] {
            0,
            0,
            10,
            10
        };
        Console.WriteLine(string.Format("blueX:{0}", string.Join(" ", blueX)));
        int[] blueY = new int[] {
            0,
            10,
            0,
            10
        };
        Console.WriteLine(string.Format("blueY:{0}", string.Join(" ", blueY)));
        int[] redX = new int[] {
            3,
            6
        };
        Console.WriteLine(string.Format("redX:{0}", string.Join(" ", redX)));
        int[] redY = new int[] {
            2,
            7
        };
        Console.WriteLine(string.Format("redY:{0}", string.Join(" ", redY)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RedAndBluePoints().find(blueX, blueY, redX, redY);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] blueX = new int[] {
            0
        };
        Console.WriteLine(string.Format("blueX:{0}", string.Join(" ", blueX)));
        int[] blueY = new int[] {
            0
        };
        Console.WriteLine(string.Format("blueY:{0}", string.Join(" ", blueY)));
        int[] redX = new int[] {
            1
        };
        Console.WriteLine(string.Format("redX:{0}", string.Join(" ", redX)));
        int[] redY = new int[] {
            1
        };
        Console.WriteLine(string.Format("redY:{0}", string.Join(" ", redY)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RedAndBluePoints().find(blueX, blueY, redX, redY);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] blueX = new int[] {
            5,
            6,
            6
        };
        Console.WriteLine(string.Format("blueX:{0}", string.Join(" ", blueX)));
        int[] blueY = new int[] {
            9,
            0,
            5
        };
        Console.WriteLine(string.Format("blueY:{0}", string.Join(" ", blueY)));
        int[] redX = new int[] {
            7
        };
        Console.WriteLine(string.Format("redX:{0}", string.Join(" ", redX)));
        int[] redY = new int[] {
            6
        };
        Console.WriteLine(string.Format("redY:{0}", string.Join(" ", redY)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RedAndBluePoints().find(blueX, blueY, redX, redY);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
