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
    public void ManualTest(string[] garden)
    {
        Console.WriteLine(string.Format("garden:{0}", string.Join(" ",garden)));
        string[] __result = new ColorfulGarden().rearrange(garden);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        string[] garden = new string[] {
            "aa",
            "bb"
        };
        Console.WriteLine(string.Format("garden:{0}", string.Join(" ", garden)));
        string[] __expected = new string[] {
            "ab",
            "ba"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new ColorfulGarden().rearrange(garden);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        string[] garden = new string[] {
            "xxxx",
            "xxxx"
        };
        Console.WriteLine(string.Format("garden:{0}", string.Join(" ", garden)));
        string[] __expected = new string[] {
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new ColorfulGarden().rearrange(garden);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        string[] garden = new string[] {
            "abcd",
            "abcd"
        };
        Console.WriteLine(string.Format("garden:{0}", string.Join(" ", garden)));
        string[] __expected = new string[] {
            "abcd",
            "dcba"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new ColorfulGarden().rearrange(garden);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        string[] garden = new string[] {
            "abcdefghijklm",
            "nopqrstuvwxyz"
        };
        Console.WriteLine(string.Format("garden:{0}", string.Join(" ", garden)));
        string[] __expected = new string[] {
            "abcdefghijklm",
            "nopqrstuvwxyz"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new ColorfulGarden().rearrange(garden);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        string[] garden = new string[] {
            "aaa",
            "aab"
        };
        Console.WriteLine(string.Format("garden:{0}", string.Join(" ", garden)));
        string[] __expected = new string[] {
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new ColorfulGarden().rearrange(garden);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
