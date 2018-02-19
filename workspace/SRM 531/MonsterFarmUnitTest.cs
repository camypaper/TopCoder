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
    public void ManualTest(string[] transforms)
    {
        Console.WriteLine(string.Format("transforms:{0}", string.Join(" ",transforms)));
        int __result = new MonsterFarm().numMonsters(transforms);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] transforms = new string[] {
            "1"
        };
        Console.WriteLine(string.Format("transforms:{0}", string.Join(" ", transforms)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonsterFarm().numMonsters(transforms);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] transforms = new string[] {
            "1 1"
        };
        Console.WriteLine(string.Format("transforms:{0}", string.Join(" ", transforms)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonsterFarm().numMonsters(transforms);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] transforms = new string[] {
            "2",
            "3",
            "1"
        };
        Console.WriteLine(string.Format("transforms:{0}", string.Join(" ", transforms)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonsterFarm().numMonsters(transforms);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] transforms = new string[] {
            "1",
            "3 4",
            "2",
            "2"
        };
        Console.WriteLine(string.Format("transforms:{0}", string.Join(" ", transforms)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonsterFarm().numMonsters(transforms);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] transforms = new string[] {
            "2 2",
            "3",
            "4 4 4",
            "5",
            "6",
            "7 7 7 7",
            "7"
        };
        Console.WriteLine(string.Format("transforms:{0}", string.Join(" ", transforms)));
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonsterFarm().numMonsters(transforms);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] transforms = new string[] {
            "2 3",
            "5 7",
            "2 4",
            "5",
            "6",
            "4",
            "7"
        };
        Console.WriteLine(string.Format("transforms:{0}", string.Join(" ", transforms)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonsterFarm().numMonsters(transforms);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
