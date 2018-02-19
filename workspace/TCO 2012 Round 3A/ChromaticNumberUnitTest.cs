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
    public void ManualTest(string[] graph)
    {
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ",graph)));
        int __result = new ChromaticNumber().minColors(graph);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] graph = new string[] {
            "N"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChromaticNumber().minColors(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] graph = new string[] {
            "NYY",
            "YNN",
            "YNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChromaticNumber().minColors(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] graph = new string[] {
            "NYNN",
            "YNNN",
            "NNNY",
            "NNYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChromaticNumber().minColors(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] graph = new string[] {
            "NYNY",
            "YNYY",
            "NYNN",
            "YYNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChromaticNumber().minColors(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] graph = new string[] {
            "NYYYYYYY",
            "YNYYYYYY",
            "YYNYYYYY",
            "YYYNYYYY",
            "YYYYNYYY",
            "YYYYYNYY",
            "YYYYYYNY",
            "YYYYYYYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ChromaticNumber().minColors(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
