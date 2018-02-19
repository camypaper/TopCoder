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
    public void ManualTest(int A, int B)
    {
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        int __result = new TaroJiroDividing().getNumber(A, B);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int A = 8;
        Console.WriteLine("A:{0}", A);
        int B = 4;
        Console.WriteLine("B:{0}", B);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TaroJiroDividing().getNumber(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int A = 4;
        Console.WriteLine("A:{0}", A);
        int B = 7;
        Console.WriteLine("B:{0}", B);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TaroJiroDividing().getNumber(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int A = 12;
        Console.WriteLine("A:{0}", A);
        int B = 12;
        Console.WriteLine("B:{0}", B);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TaroJiroDividing().getNumber(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int A = 24;
        Console.WriteLine("A:{0}", A);
        int B = 96;
        Console.WriteLine("B:{0}", B);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TaroJiroDividing().getNumber(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int A = 1000000000;
        Console.WriteLine("A:{0}", A);
        int B = 999999999;
        Console.WriteLine("B:{0}", B);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TaroJiroDividing().getNumber(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
