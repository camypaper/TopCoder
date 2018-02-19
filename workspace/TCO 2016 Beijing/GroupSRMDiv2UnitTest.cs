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
    public void ManualTest(int[] t)
    {
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int __result = new GroupSRMDiv2().FindGroups(t);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] t = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GroupSRMDiv2().FindGroups(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] t = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GroupSRMDiv2().FindGroups(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] t = new int[] {
            2,
            2
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GroupSRMDiv2().FindGroups(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] t = new int[] {
            2,
            2,
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GroupSRMDiv2().FindGroups(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] t = new int[] {
            3,
            3,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GroupSRMDiv2().FindGroups(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] t = new int[] {
            2,
            3,
            2,
            3,
            2,
            3,
            2,
            1,
            1,
            2,
            2
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GroupSRMDiv2().FindGroups(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
