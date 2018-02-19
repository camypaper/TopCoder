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
    public void ManualTest(int apple, int kiwi, int grape)
    {
        Console.WriteLine("apple:{0}", apple);
        Console.WriteLine("kiwi:{0}", kiwi);
        Console.WriteLine("grape:{0}", grape);
        int __result = new FruitTrees().maxDist(apple, kiwi, grape);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int apple = 1;
        Console.WriteLine("apple:{0}", apple);
        int kiwi = 5;
        Console.WriteLine("kiwi:{0}", kiwi);
        int grape = 8;
        Console.WriteLine("grape:{0}", grape);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FruitTrees().maxDist(apple, kiwi, grape);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int apple = 3;
        Console.WriteLine("apple:{0}", apple);
        int kiwi = 3;
        Console.WriteLine("kiwi:{0}", kiwi);
        int grape = 6;
        Console.WriteLine("grape:{0}", grape);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FruitTrees().maxDist(apple, kiwi, grape);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int apple = 40;
        Console.WriteLine("apple:{0}", apple);
        int kiwi = 30;
        Console.WriteLine("kiwi:{0}", kiwi);
        int grape = 20;
        Console.WriteLine("grape:{0}", grape);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FruitTrees().maxDist(apple, kiwi, grape);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int apple = 899;
        Console.WriteLine("apple:{0}", apple);
        int kiwi = 1073;
        Console.WriteLine("kiwi:{0}", kiwi);
        int grape = 1147;
        Console.WriteLine("grape:{0}", grape);
        int __expected = 14;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FruitTrees().maxDist(apple, kiwi, grape);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int apple = 2000;
        Console.WriteLine("apple:{0}", apple);
        int kiwi = 2000;
        Console.WriteLine("kiwi:{0}", kiwi);
        int grape = 2000;
        Console.WriteLine("grape:{0}", grape);
        int __expected = 666;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FruitTrees().maxDist(apple, kiwi, grape);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
