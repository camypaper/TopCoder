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
    public void ManualTest(int init)
    {
        Console.WriteLine("init:{0}", init);
        int __result = new CarrotJumping().theJump(init);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int init = 125000000;
        Console.WriteLine("init:{0}", init);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotJumping().theJump(init);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int init = 281250001;
        Console.WriteLine("init:{0}", init);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotJumping().theJump(init);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int init = 18426114;
        Console.WriteLine("init:{0}", init);
        int __expected = 58;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotJumping().theJump(init);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int init = 4530664;
        Console.WriteLine("init:{0}", init);
        int __expected = 478;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotJumping().theJump(init);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int init = 705616876;
        Console.WriteLine("init:{0}", init);
        int __expected = 100000;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotJumping().theJump(init);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int init = 852808441;
        Console.WriteLine("init:{0}", init);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CarrotJumping().theJump(init);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
