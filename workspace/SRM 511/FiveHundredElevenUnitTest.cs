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
    public void ManualTest(int[] cards)
    {
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ",cards)));
        string __result = new FiveHundredEleven().theWinner(cards);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] cards = new int[] {
            3,
            5,
            7,
            9,
            510
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        string __expected = "Fox Ciel";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FiveHundredEleven().theWinner(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] cards = new int[] {
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        string __expected = "Toastman";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FiveHundredEleven().theWinner(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] cards = new int[] {
            511
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        string __expected = "Toastman";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FiveHundredEleven().theWinner(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] cards = new int[] {
            5,
            58,
            192,
            256
        };
        Console.WriteLine(string.Format("cards:{0}", string.Join(" ", cards)));
        string __expected = "Fox Ciel";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FiveHundredEleven().theWinner(cards);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
