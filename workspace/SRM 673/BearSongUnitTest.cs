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
    public void ManualTest(int[] notes)
    {
        Console.WriteLine(string.Format("notes:{0}", string.Join(" ",notes)));
        int __result = new BearSong().countRareNotes(notes);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] notes = new int[] {
            9,
            10,
            7,
            8,
            9
        };
        Console.WriteLine(string.Format("notes:{0}", string.Join(" ", notes)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSong().countRareNotes(notes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] notes = new int[] {
            8,
            8,
            7,
            6,
            7,
            3,
            5,
            10,
            9,
            3
        };
        Console.WriteLine(string.Format("notes:{0}", string.Join(" ", notes)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSong().countRareNotes(notes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] notes = new int[] {
            234,
            462,
            715,
            596,
            906
        };
        Console.WriteLine(string.Format("notes:{0}", string.Join(" ", notes)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSong().countRareNotes(notes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] notes = new int[] {
            17
        };
        Console.WriteLine(string.Format("notes:{0}", string.Join(" ", notes)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSong().countRareNotes(notes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] notes = new int[] {
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000
        };
        Console.WriteLine(string.Format("notes:{0}", string.Join(" ", notes)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSong().countRareNotes(notes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
