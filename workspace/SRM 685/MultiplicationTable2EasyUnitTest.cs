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
    public void ManualTest(int[] table, int[] t)
    {
        Console.WriteLine(string.Format("table:{0}", string.Join(" ",table)));
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        string __result = new MultiplicationTable2Easy().isGoodSet(table, t);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] table = new int[] {
            1,
            1,
            2,
            3,
            1,
            0,
            2,
            3,
            3,
            3,
            0,
            3,
            2,
            2,
            2,
            0
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int[] t = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "Good";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MultiplicationTable2Easy().isGoodSet(table, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] table = new int[] {
            1,
            1,
            2,
            3,
            1,
            0,
            2,
            3,
            3,
            3,
            0,
            3,
            2,
            2,
            2,
            0
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int[] t = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "Not Good";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MultiplicationTable2Easy().isGoodSet(table, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] table = new int[] {
            1,
            1,
            2,
            3,
            1,
            0,
            2,
            3,
            3,
            3,
            0,
            3,
            2,
            2,
            2,
            0
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int[] t = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "Good";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MultiplicationTable2Easy().isGoodSet(table, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] table = new int[] {
            1,
            1,
            2,
            3,
            1,
            0,
            2,
            3,
            3,
            3,
            0,
            3,
            2,
            2,
            2,
            0
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int[] t = new int[] {
            1
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "Not Good";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MultiplicationTable2Easy().isGoodSet(table, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] table = new int[] {
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int[] t = new int[] {
            2,
            4,
            5
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "Good";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MultiplicationTable2Easy().isGoodSet(table, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] table = new int[] {
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table)));
        int[] t = new int[] {
            0,
            1,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "Not Good";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MultiplicationTable2Easy().isGoodSet(table, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
