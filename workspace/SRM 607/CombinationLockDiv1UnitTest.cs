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
    public void ManualTest(string[] P, string[] Q)
    {
        Console.WriteLine(string.Format("P:{0}", string.Join(" ",P)));
        Console.WriteLine(string.Format("Q:{0}", string.Join(" ",Q)));
        int __result = new CombinationLockDiv1().minimumMoves(P, Q);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] P = new string[] {
            "123"
        };
        Console.WriteLine(string.Format("P:{0}", string.Join(" ", P)));
        string[] Q = new string[] {
            "112"
        };
        Console.WriteLine(string.Format("Q:{0}", string.Join(" ", Q)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CombinationLockDiv1().minimumMoves(P, Q);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] P = new string[] {
            "1"
        };
        Console.WriteLine(string.Format("P:{0}", string.Join(" ", P)));
        string[] Q = new string[] {
            "7"
        };
        Console.WriteLine(string.Format("Q:{0}", string.Join(" ", Q)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CombinationLockDiv1().minimumMoves(P, Q);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] P = new string[] {
            "6",
            "07"
        };
        Console.WriteLine(string.Format("P:{0}", string.Join(" ", P)));
        string[] Q = new string[] {
            "",
            "60",
            "7"
        };
        Console.WriteLine(string.Format("Q:{0}", string.Join(" ", Q)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CombinationLockDiv1().minimumMoves(P, Q);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] P = new string[] {
            "1234"
        };
        Console.WriteLine(string.Format("P:{0}", string.Join(" ", P)));
        string[] Q = new string[] {
            "4567"
        };
        Console.WriteLine(string.Format("Q:{0}", string.Join(" ", Q)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CombinationLockDiv1().minimumMoves(P, Q);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] P = new string[] {
            "020"
        };
        Console.WriteLine(string.Format("P:{0}", string.Join(" ", P)));
        string[] Q = new string[] {
            "909"
        };
        Console.WriteLine(string.Format("Q:{0}", string.Join(" ", Q)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CombinationLockDiv1().minimumMoves(P, Q);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] P = new string[] {
            "4423232218340"
        };
        Console.WriteLine(string.Format("P:{0}", string.Join(" ", P)));
        string[] Q = new string[] {
            "6290421476245"
        };
        Console.WriteLine(string.Format("Q:{0}", string.Join(" ", Q)));
        int __expected = 18;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CombinationLockDiv1().minimumMoves(P, Q);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
