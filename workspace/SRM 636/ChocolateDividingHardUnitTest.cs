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
    public void ManualTest(string[] chocolate)
    {
        Console.WriteLine(string.Format("chocolate:{0}", string.Join(" ",chocolate)));
        int __result = new ChocolateDividingHard().findBest(chocolate);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] chocolate = new string[] {
            "95998",
            "21945",
            "23451",
            "99798",
            "74083"
        };
        Console.WriteLine(string.Format("chocolate:{0}", string.Join(" ", chocolate)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChocolateDividingHard().findBest(chocolate);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] chocolate = new string[] {
            "12942",
            "23456",
            "99798",
            "98998",
            "67675"
        };
        Console.WriteLine(string.Format("chocolate:{0}", string.Join(" ", chocolate)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChocolateDividingHard().findBest(chocolate);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] chocolate = new string[] {
            "129420",
            "234560",
            "997980",
            "989980",
            "676760"
        };
        Console.WriteLine(string.Format("chocolate:{0}", string.Join(" ", chocolate)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChocolateDividingHard().findBest(chocolate);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] chocolate = new string[] {
            "75356291270936062",
            "61879202375922897",
            "36129319478450361",
            "06320615547656937",
            "45254744307868843",
            "14920689266495048",
            "71727226106159490",
            "91771159776736563",
            "94812939088509638",
            "56115984810304444",
            "76317596217857418",
            "59753883189643338"
        };
        Console.WriteLine(string.Format("chocolate:{0}", string.Join(" ", chocolate)));
        int __expected = 44;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChocolateDividingHard().findBest(chocolate);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
