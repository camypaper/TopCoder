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
    public void ManualTest(int[] w1, int[] w2)
    {
        Console.WriteLine(string.Format("w1:{0}", string.Join(" ",w1)));
        Console.WriteLine(string.Format("w2:{0}", string.Join(" ",w2)));
        int __result = new BiconnectedDiv1().minimize(w1, w2);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] w1 = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("w1:{0}", string.Join(" ", w1)));
        int[] w2 = new int[] {
            3
        };
        Console.WriteLine(string.Format("w2:{0}", string.Join(" ", w2)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BiconnectedDiv1().minimize(w1, w2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] w1 = new int[] {
            3,
            0,
            4
        };
        Console.WriteLine(string.Format("w1:{0}", string.Join(" ", w1)));
        int[] w2 = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("w2:{0}", string.Join(" ", w2)));
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BiconnectedDiv1().minimize(w1, w2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] w1 = new int[] {
            3,
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("w1:{0}", string.Join(" ", w1)));
        int[] w2 = new int[] {
            3,
            6,
            3
        };
        Console.WriteLine(string.Format("w2:{0}", string.Join(" ", w2)));
        int __expected = 18;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BiconnectedDiv1().minimize(w1, w2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] w1 = new int[] {
            7243,
            7525,
            8467,
            6351,
            9453,
            8456,
            8175,
            5874,
            6869,
            7400,
            6438,
            8926,
            6876
        };
        Console.WriteLine(string.Format("w1:{0}", string.Join(" ", w1)));
        int[] w2 = new int[] {
            2642,
            1743,
            3546,
            4100,
            2788,
            3019,
            2678,
            1935,
            1790,
            2674,
            3775,
            1920
        };
        Console.WriteLine(string.Format("w2:{0}", string.Join(" ", w2)));
        int __expected = 46729;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BiconnectedDiv1().minimize(w1, w2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
