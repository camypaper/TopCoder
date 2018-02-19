using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int[] parent)
    {
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ",parent)));
        int[] __result = new EllysTree().getMoves(parent);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int[] parent = new int[] {
            9,
            13,
            7,
            9,
            8,
            14,
            14,
            0,
            6,
            9,
            2,
            2,
            5,
            5,
            7
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] __expected = new int[] {
            1,
            5,
            2,
            11,
            13,
            12,
            8,
            3,
            7,
            15,
            14,
            4,
            6,
            9,
            10
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new EllysTree().getMoves(parent);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int[] parent = new int[] {
            3,
            4,
            5,
            0,
            2
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] __expected = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new EllysTree().getMoves(parent);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int[] parent = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] __expected = new int[] {
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new EllysTree().getMoves(parent);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int[] parent = new int[] {
            0,
            6,
            6,
            2,
            6,
            1,
            3,
            5
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] __expected = new int[] {
            2,
            4,
            1,
            3,
            7,
            6,
            5,
            8
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new EllysTree().getMoves(parent);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
