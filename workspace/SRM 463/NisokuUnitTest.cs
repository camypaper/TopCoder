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
    public void ManualTest(double[] cards)
    {
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ",cards)));
        double __result = new Nisoku().theMax(cards);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        double[] cards = new double[] {
            5,
            8
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        double __expected = 40.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Nisoku().theMax(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        double[] cards = new double[] {
            1.5,
            1.8
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        double __expected = 3.3;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Nisoku().theMax(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        double[] cards = new double[] {
            8.26,
            7.54,
            3.2567
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        double __expected = 202.82857868;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Nisoku().theMax(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        double[] cards = new double[] {
            1.5,
            1.7,
            1.6,
            1.5
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        double __expected = 9.920000000000002;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Nisoku().theMax(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        double[] cards = new double[] {
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        double __expected = 1.0E50;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Nisoku().theMax(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
