using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);    }
    public void ManualTest(string[] love)
    {
        Console.WriteLine(string.Format("love:{0}", string.Join(" ",love)));
        int __result = new Incubator().maxMagicalGirls(love);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] love = new string[] {
            "NY",
            "NN"
        };
        Console.WriteLine(string.Format("love:{0}", string.Join(" ", love)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Incubator().maxMagicalGirls(love);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] love = new string[] {
            "NYN",
            "NNY",
            "NNN"
        };
        Console.WriteLine(string.Format("love:{0}", string.Join(" ", love)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Incubator().maxMagicalGirls(love);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] love = new string[] {
            "NNYNN",
            "NNYNN",
            "NNNYY",
            "NNNNN",
            "NNNNN"
        };
        Console.WriteLine(string.Format("love:{0}", string.Join(" ", love)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Incubator().maxMagicalGirls(love);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] love = new string[] {
            "NNNNN",
            "NYNNN",
            "NYNYN",
            "YNYNN",
            "NNNNN"
        };
        Console.WriteLine(string.Format("love:{0}", string.Join(" ", love)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Incubator().maxMagicalGirls(love);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] love = new string[] {
            "NNNNN",
            "NNNNN",
            "NNNNN",
            "NNNNN",
            "NNNNN"
        };
        Console.WriteLine(string.Format("love:{0}", string.Join(" ", love)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Incubator().maxMagicalGirls(love);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] love = new string[] {
            "NNYNNNNN",
            "NNNYNNNN",
            "NNNNYNNN",
            "NNYNNNNN",
            "NNNNNYYN",
            "NNNYNNNY",
            "NNNNNNNN",
            "NNNNNNNN"
        };
        Console.WriteLine(string.Format("love:{0}", string.Join(" ", love)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Incubator().maxMagicalGirls(love);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        string[] love = new string[] {
            "Y"
        };
        Console.WriteLine(string.Format("love:{0}", string.Join(" ", love)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Incubator().maxMagicalGirls(love);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
