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
    public void ManualTest(string[] colors)
    {
        Console.WriteLine(string.Format("colors:{0}", string.Join(" ",colors)));
        long __result = new CubeColoring().theCount(colors);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] colors = new string[] {
            "Y",
            "Y",
            "Y",
            "Y",
            "Y",
            "Y",
            "Y",
            "Y"
        };
        Console.WriteLine(string.Format("colors:{0}", string.Join(" ", colors)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new CubeColoring().theCount(colors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] colors = new string[] {
            "YNNNNNNN",
            "NYNNNNNN",
            "NNYNNNNN",
            "NNNYNNNN",
            "NNNNYNNN",
            "NNNNNYNN",
            "NNNNNNYN",
            "NNNNNNNY"
        };
        Console.WriteLine(string.Format("colors:{0}", string.Join(" ", colors)));
        long __expected = 1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new CubeColoring().theCount(colors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] colors = new string[] {
            "YNNYN",
            "YYYYY",
            "NYYNY",
            "YNYYN",
            "YNNYY",
            "YNNYY",
            "NNNYY",
            "NYYYY"
        };
        Console.WriteLine(string.Format("colors:{0}", string.Join(" ", colors)));
        long __expected = 250L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new CubeColoring().theCount(colors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] colors = new string[] {
            "YNNYN",
            "YYYYY",
            "NNNNN",
            "YNYYN",
            "YNNYY",
            "YNNYY",
            "NNNYY",
            "NYYYY"
        };
        Console.WriteLine(string.Format("colors:{0}", string.Join(" ", colors)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new CubeColoring().theCount(colors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] colors = new string[] {
            "YNNYNYYYYYNN",
            "NNNYNYYNYNNY",
            "YYNNYYNNNYYN",
            "YYYYYNNYYYNN",
            "NNNYYYNNYNYN",
            "YYYNYYYYNYNN",
            "NNNNNNYYNYYN",
            "NNYNYYNNYNYY"
        };
        Console.WriteLine(string.Format("colors:{0}", string.Join(" ", colors)));
        long __expected = 611480L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new CubeColoring().theCount(colors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
