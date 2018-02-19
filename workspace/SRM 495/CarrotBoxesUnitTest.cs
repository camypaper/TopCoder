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
    public void ManualTest(string[] information)
    {
        Console.WriteLine(string.Format("information:{0}", string.Join(" ",information)));
        double __result = new CarrotBoxes().theProbability(information);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] information = new string[] {
            "YYYYY",
            "NYNNN",
            "NNYNN",
            "NNNYN",
            "NNNNY"
        };
        Console.WriteLine(string.Format("information:{0}", string.Join(" ", information)));
        double __expected = 0.8;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CarrotBoxes().theProbability(information);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        string[] information = new string[] {
            "YNNNN",
            "NYNNN",
            "NNYNN",
            "NNNYN",
            "NNNNY"
        };
        Console.WriteLine(string.Format("information:{0}", string.Join(" ", information)));
        double __expected = 0.2;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CarrotBoxes().theProbability(information);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        string[] information = new string[] {
            "Y"
        };
        Console.WriteLine(string.Format("information:{0}", string.Join(" ", information)));
        double __expected = 1.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CarrotBoxes().theProbability(information);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        string[] information = new string[] {
            "YNNNN",
            "YYNNN",
            "YNYNN",
            "NNNYY",
            "NNNYY"
        };
        Console.WriteLine(string.Format("information:{0}", string.Join(" ", information)));
        double __expected = 0.6;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CarrotBoxes().theProbability(information);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        string[] information = new string[] {
            "YYYNNNYN",
            "NYNNNNYN",
            "NNYNNNNN",
            "NYNYNNNN",
            "YNNNYNNY",
            "NNYNNYNN",
            "NNNNYNYN",
            "NNYNNNNY"
        };
        Console.WriteLine(string.Format("information:{0}", string.Join(" ", information)));
        double __expected = 0.875;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CarrotBoxes().theProbability(information);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example5()
    {
        string[] information = new string[] {
            "YNNNNNNNNYNNNNNNNNNN",
            "NYNNNNNNNNNNNNNNNNNN",
            "NNYNNNNNNNYNNNNNYNNN",
            "NNNYNYNNNNNNNNYNNNNN",
            "NNNNYNNNNNNNNNYNNNNY",
            "NNNNNYNNNNNNNNNNNNNY",
            "NNNNYNYNYNNNNNNNNNNN",
            "NNNNNNNYNNNYYNNNNNNN",
            "NNNNNNNNYNNNNNNNNNNN",
            "YNNNNNNNNYNNNNNYNNNN",
            "NNNNNNNNNNYNNNNNNNNN",
            "NYNNNNNNNNNYNNNNNNNN",
            "NNNNNNNYNNNNYNNNNNNN",
            "NNNNNNNNNNNNNYNNNYNN",
            "NNNNNNNNNNNYNNYNNNYN",
            "NYNNNNNNNNNNNNNYNNNN",
            "NNYNNNNNNNNNNNNNYNNN",
            "NNNNNNNNNNNNNYNYNYNN",
            "NNNNNNNNYNYNNNNNNNYY",
            "NNNYNNNNNNNNNNNNNNNY"
        };
        Console.WriteLine(string.Format("information:{0}", string.Join(" ", information)));
        double __expected = 0.75;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CarrotBoxes().theProbability(information);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
