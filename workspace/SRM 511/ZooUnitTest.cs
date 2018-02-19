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
    public void ManualTest(int[] answers)
    {
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ",answers)));
        long __result = new Zoo().theCount(answers);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] answers = new int[] {
            0,
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Zoo().theCount(answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] answers = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Zoo().theCount(answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] answers = new int[] {
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Zoo().theCount(answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] answers = new int[] {
            1,
            0,
            2,
            0,
            1
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        long __expected = 8L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Zoo().theCount(answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] answers = new int[] {
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Zoo().theCount(answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
