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
    public void ManualTest(int A, int B, int C)
    {
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        Console.WriteLine("C:{0}", C);
        string __result = new BearPlaysDiv2().equalPiles(A, B, C);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int A = 10;
        Console.WriteLine("A:{0}", A);
        int B = 15;
        Console.WriteLine("B:{0}", B);
        int C = 35;
        Console.WriteLine("C:{0}", C);
        string __expected = "possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPlaysDiv2().equalPiles(A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int A = 1;
        Console.WriteLine("A:{0}", A);
        int B = 1;
        Console.WriteLine("B:{0}", B);
        int C = 2;
        Console.WriteLine("C:{0}", C);
        string __expected = "impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPlaysDiv2().equalPiles(A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int A = 4;
        Console.WriteLine("A:{0}", A);
        int B = 6;
        Console.WriteLine("B:{0}", B);
        int C = 8;
        Console.WriteLine("C:{0}", C);
        string __expected = "impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPlaysDiv2().equalPiles(A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int A = 18;
        Console.WriteLine("A:{0}", A);
        int B = 18;
        Console.WriteLine("B:{0}", B);
        int C = 18;
        Console.WriteLine("C:{0}", C);
        string __expected = "possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPlaysDiv2().equalPiles(A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int A = 225;
        Console.WriteLine("A:{0}", A);
        int B = 500;
        Console.WriteLine("B:{0}", B);
        int C = 475;
        Console.WriteLine("C:{0}", C);
        string __expected = "possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPlaysDiv2().equalPiles(A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
