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
    public void ManualTest(string[] afterFourClicks)
    {
        Console.WriteLine(string.Format("afterFourClicks:{0}", string.Join(" ",afterFourClicks)));
        int __result = new FleaCircus().countArrangements(afterFourClicks);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] afterFourClicks = new string[] {
            "1 2 0 3"
        };
        Console.WriteLine(string.Format("afterFourClicks:{0}", string.Join(" ", afterFourClicks)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleaCircus().countArrangements(afterFourClicks);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] afterFourClicks = new string[] {
            "1 2 ",
            "0 3"
        };
        Console.WriteLine(string.Format("afterFourClicks:{0}", string.Join(" ", afterFourClicks)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleaCircus().countArrangements(afterFourClicks);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] afterFourClicks = new string[] {
            "0 1 2"
        };
        Console.WriteLine(string.Format("afterFourClicks:{0}", string.Join(" ", afterFourClicks)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleaCircus().countArrangements(afterFourClicks);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] afterFourClicks = new string[] {
            "0 1 2 3 5 4"
        };
        Console.WriteLine(string.Format("afterFourClicks:{0}", string.Join(" ", afterFourClicks)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleaCircus().countArrangements(afterFourClicks);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] afterFourClicks = new string[] {
            "3 6 7 9 8 2 1",
            "0 5 1 0 4"
        };
        Console.WriteLine(string.Format("afterFourClicks:{0}", string.Join(" ", afterFourClicks)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleaCircus().countArrangements(afterFourClicks);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] afterFourClicks = new string[] {
            "1 0 7 5 6 3 4 2"
        };
        Console.WriteLine(string.Format("afterFourClicks:{0}", string.Join(" ", afterFourClicks)));
        int __expected = 48;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleaCircus().countArrangements(afterFourClicks);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
