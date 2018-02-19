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
    public void ManualTest(int[] c, int[] s)
    {
        Console.WriteLine(string.Format("c:{0}", string.Join(" ",c)));
        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
        string __result = new ScoringSystems().isEquivalent(c, s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] c = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] s = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Equivalent";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ScoringSystems().isEquivalent(c, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] c = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] s = new int[] {
            2,
            2
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Not Equivalent";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ScoringSystems().isEquivalent(c, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] c = new int[] {
            30,
            50,
            20
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] s = new int[] {
            49,
            50,
            1
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Equivalent";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ScoringSystems().isEquivalent(c, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] c = new int[] {
            250,
            500,
            1000
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] s = new int[] {
            300,
            600,
            900
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Not Equivalent";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ScoringSystems().isEquivalent(c, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] c = new int[] {
            6,
            6,
            6,
            6,
            6,
            8,
            8,
            8,
            8,
            8
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int[] s = new int[] {
            5,
            5,
            5,
            5,
            5,
            7,
            7,
            7,
            7,
            7
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Not Equivalent";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ScoringSystems().isEquivalent(c, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
