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
    public void ManualTest(int[] p)
    {
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        string __result = new ParenthesesAndPermutation().getSequence(p);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] p = new int[] {
            2,
            0,
            3,
            1
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        string __expected = "(())";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ParenthesesAndPermutation().getSequence(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] p = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ParenthesesAndPermutation().getSequence(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] p = new int[] {
            4,
            5,
            6,
            7,
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        string __expected = "(())(())";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ParenthesesAndPermutation().getSequence(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] p = new int[] {
            9,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            1,
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ParenthesesAndPermutation().getSequence(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] p = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        string __expected = "()";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ParenthesesAndPermutation().getSequence(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
