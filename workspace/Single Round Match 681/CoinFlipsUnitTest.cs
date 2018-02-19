using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(int[] vals, int prob)
    {
        Console.WriteLine(string.Format("vals:{0}", string.Join(" ",vals)));
        Console.WriteLine("prob:{0}", prob);
        double __result = new CoinFlips().getExpectation(vals, prob);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] vals = new int[] {
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("vals:{0}", string.Join(" ", vals)));
        int prob = 500000000;
        Console.WriteLine("prob:{0}", prob);
        double __expected = 2.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CoinFlips().getExpectation(vals, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] vals = new int[] {
            5,
            1,
            4,
            2,
            3
        };
        Console.WriteLine(string.Format("vals:{0}", string.Join(" ", vals)));
        int prob = 100000000;
        Console.WriteLine("prob:{0}", prob);
        double __expected = 4.985392200480001;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CoinFlips().getExpectation(vals, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] vals = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("vals:{0}", string.Join(" ", vals)));
        int prob = 0;
        Console.WriteLine("prob:{0}", prob);
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CoinFlips().getExpectation(vals, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] vals = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("vals:{0}", string.Join(" ", vals)));
        int prob = 1000000000;
        Console.WriteLine("prob:{0}", prob);
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CoinFlips().getExpectation(vals, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] vals = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };
        Console.WriteLine(string.Format("vals:{0}", string.Join(" ", vals)));
        int prob = 250000000;
        Console.WriteLine("prob:{0}", prob);
        double __expected = 130.25145424313288;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CoinFlips().getExpectation(vals, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example5()
    {
        int[] vals = new int[] {
            3,
            1,
            4,
            1,
            5,
            9,
            2,
            6,
            5,
            3,
            5,
            8,
            9,
            7,
            9,
            3,
            2,
            3,
            8,
            5,
            6,
            2,
            6,
            4,
            3,
            3,
            8,
            3,
            2,
            7,
            9,
            5
        };
        Console.WriteLine(string.Format("vals:{0}", string.Join(" ", vals)));
        int prob = 123456789;
        Console.WriteLine("prob:{0}", prob);
        double __expected = 481.6707820920715;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CoinFlips().getExpectation(vals, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
