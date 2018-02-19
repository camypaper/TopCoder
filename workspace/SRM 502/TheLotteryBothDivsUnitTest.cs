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
    public void ManualTest(string[] goodSuffixes)
    {
        Console.WriteLine(string.Format("goodSuffixes:{0}", string.Join(" ",goodSuffixes)));
        double __result = new TheLotteryBothDivs().find(goodSuffixes);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] goodSuffixes = new string[] {
            "4"
        };
        Console.WriteLine(string.Format("goodSuffixes:{0}", string.Join(" ", goodSuffixes)));
        double __expected = 0.1;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new TheLotteryBothDivs().find(goodSuffixes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        string[] goodSuffixes = new string[] {
            "4",
            "7"
        };
        Console.WriteLine(string.Format("goodSuffixes:{0}", string.Join(" ", goodSuffixes)));
        double __expected = 0.2;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new TheLotteryBothDivs().find(goodSuffixes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        string[] goodSuffixes = new string[] {
            "47",
            "47"
        };
        Console.WriteLine(string.Format("goodSuffixes:{0}", string.Join(" ", goodSuffixes)));
        double __expected = 0.01;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new TheLotteryBothDivs().find(goodSuffixes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        string[] goodSuffixes = new string[] {
            "47",
            "58",
            "4747",
            "502"
        };
        Console.WriteLine(string.Format("goodSuffixes:{0}", string.Join(" ", goodSuffixes)));
        double __expected = 0.021;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new TheLotteryBothDivs().find(goodSuffixes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        string[] goodSuffixes = new string[] {
            "8542861",
            "1954",
            "6",
            "523",
            "000000000",
            "5426",
            "8"
        };
        Console.WriteLine(string.Format("goodSuffixes:{0}", string.Join(" ", goodSuffixes)));
        double __expected = 0.201100101;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new TheLotteryBothDivs().find(goodSuffixes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
