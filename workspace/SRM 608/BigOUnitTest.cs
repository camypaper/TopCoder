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
        int __result = new BigO().minK(graph);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] graph = new string[] {
            "NYY",
            "YNY",
            "YYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BigO().minK(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] graph = new string[] {
            "NYNNN",
            "NNYNN",
            "NNNYN",
            "NNNNY",
            "NNNNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BigO().minK(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] graph = new string[] {
            "NYNNN",
            "YNNNN",
            "NNNYN",
            "NNNNY",
            "NNYNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BigO().minK(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] graph = new string[] {
            "NYYYNYYYNNYYYYYYNYNN",
            "NNNNYNYYNNYYYNYYNYYN",
            "NYNNYYYNNNYYYYNYNYNN",
            "NYYNNYYYYNNNYYNNYNYY",
            "NYNYNNNNNNYYYYYNYYYN",
            "YNNNNNNYNNYNNYYYYYYY",
            "NNYYNNNNNYNYNYNNYNYY",
            "NNYNYYNNNNYNYNYYYYNN",
            "NYYNYYNNNYNNYYYNYNYN",
            "YYNNYNNYYNYNNNNNYNNN",
            "YYNYYNNYYYNYYNYNYYYY",
            "YYNNYYNYNYNNNNYNNNNY",
            "NNYYNYYYNNNNNYYYYYNY",
            "YNNNYNNNNYNNNNNYNNNY",
            "YYYYNYYNNYNNNNNYNNNN",
            "NYYYYNYNYYNNYNNNYNNY",
            "YYYYYNNNYYYYNYYYNNYN",
            "NNYNNYNYNYNNNNNNYNYN",
            "YYNYYNNNNNYNNYNYNNNY",
            "YYYYNYNYYNNYNYNYNNNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BigO().minK(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] graph = new string[] {
            "NYNYYYNYYYNYYNYYNYYNYYNYNNYYYYNNNYYNNNYNYYNYNNNYNY",
            "NNNNNNNNNNNNNNNNYNNNYNNNNNYNYNYNNNNNNYNNNNNNNNNNNN",
            "NYNYYYYNYNYYNNYYYYYYYYYYNYYYNYYYYYYNNYYYYYYYNNYYYY",
            "NYNNYYNNNNNNNNNNNYNNNYNYNNYNYNYYNYYNNYYYNNNNNNNYYY",
            "NNNNNNNNNNNNYNNYYNNNYNNNNYNNYNNYNNYNNYNYNNNNNNNYYN",
            "NNNNNNNNNNNNNNNNYNNNYNNNNNNNNNYNNNNNNYNNNNNNNNNNNN",
            "YYNYNNNYNYYYYNYYYYYYYYYYNYYYYYYYNYYNNYNYYYYYNNYNYY",
            "NYNYYNNNYYNNYNNYYYNNYYNYNYYNYYYNNNYNNYYYNNNNNNNYYY",
            "NYNYYYNYNYNNNNNYYYNNNNNNNYYNYYYYNYYNNYYYNNNNNNNYYY",
            "NYNNNYNNNNNNNNNYYNNNYNNNNNYNYNYNNYYNNYNYNNNYNNNNYN",
            "NYNYYYNNYYNYYNYNYYNYYYNYNYYNYYYYNYNNNNYYYYNYNNNYNY",
            "NYNNYYNNNYNNYNNYYYNNYYNNNYYNYYNNNYYNNNNYNNNYNNNYYY",
            "NNNNNNNNNNNNNNNYYNNNYNNNNNNNYNNYNYNNNYYNNNNNNNNYNN",
            "YYYYNYYYYYYYYNYYYYNYYYYYYYYYYYNYYNYYYNYYYYYNNYYNYN",
            "NYNYYNNYYYNYYNNYYYNYNYNYNYYNYYYYNYYNNYYYYYNYNNNNNY",
            "NYNNNNNNNNNNNNNNYNNNYNNNNNYNYNYYNYNNNNNNNNNNNNNNNN",
            "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNN",
            "NYNNNYNNNNNNNNNYYNNNNNNNNNNNYNYYNYYNNYNNNNNNNNNYYN",
            "NYNYYYNNYYNYNNYYYYNYYYNYNYYYYNNYNNYNNYNYYYYNNNYYYY",
            "NNNYYYNNNYNYYNNYYYNNYYNNNYYNYYYYNYYNNNYYNYNYNNNYYY",
            "NNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNN",
            "NYNNNYNNNNNNNNNYNNNNNNNNNYYNYYYYNYYNNYNNNNNNNNNYYN",
            "YYNYYYNNYYNYYNYNYYNYNYNYNYYYYYYYNYNNNYYYYYNYNNYYYY",
            "NYNYYYNNNNNNYNNNYYNNYYNNNYYNYYYYNYYNNYYYNNNNNNNYNY",
            "YNNNYYYYYYYYYNYYYYYYYYYNNYYNYNYNYNNYYYYYYYNYNNYYYY",
            "NYNNNYNNNNNNNNNYYNNNYNNNNNYNYNYYNYYNNNNYNNNNNNNYNN",
            "NNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNN",
            "NYNYYYNYYYNYNNNNYYNYYNNYNYYNYYYYNYYNNNNNYYNYNNYYNN",
            "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNN",
            "NYNNNYNNNNNNNNNYYNNNYNNNNNNNNNYYNYYNNNNYNNNNNNNYYY",
            "NNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN",
            "NNNNNNNNNNNNNNNNYNNNYNNNNNYNNNYNNNNNNNNNNNNNNNNNNN",
            "NYNYYNNYYYNNNNNYYYNYYYNNNYYYYYYYNYYNNYYYYNNYNNNNYY",
            "NNNNNNNNNNNNNNNYYNNNYNNNNNYNYNYYNNNNNYNNNNNNNNNNNN",
            "NYNNNNNNNNNNNNNNYNNNYNNNNNYNNNYYNNNNNNNNNNNNNNNYNN",
            "NYNYYYYYNYYYYNYYYYYYNYYYNNNYYYYYNYYNYNYYYYYYNYYYNY",
            "YYNYYYNYYYNNNNNYNYYYYNYNNNYYYYYYNYYNNYYNYNNYNNYNNY",
            "NNNNNNNNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNNNNNNNNNNNN",
            "NYNNNYNNNNNNNNNYYNNNNYNNNNYNYNNYNNNNNYNYNNNNNNNYNN",
            "NYNNNYNNNNNNNNNYYNNNNNNNNYYNYNYNNYYNNNNNNNNNNNNYNN",
            "NYNYYYNYYYNYNNNNNYNNYYNYNNYNNYYYNYYNNYYYNNNNNNNYYY",
            "NYNYYNNNNYNYYNNYYYNYYYNNNYYNYYYNNYYNNYYYNNNYNNNNYY",
            "NYNYNYNYYYNYYNYYNYNYNYYYNNYYYYYYNNNNNYYYNYNYNNYNYY",
            "NYNNNYNNNYNNNNNYYYNNYNNNNNYNYNNNNYYNNYNYNNNNNNNYYN",
            "YYYNNYNYYYNYNNYYYYYNYYNYNYYYYYNYYNYNYYYYYNNYNNYNYN",
            "YYNNYYYYYYYNYNYYNYYYYYYYYYYNYYYNYYYNNYYYYNYYNNYYYY",
            "NYNNYYNYYYNNYNNYYYNYNYNYNYYNNYYNNYNNNYYYNYNYNNNNYY",
            "NNNNNNNNNNNNNNNNYNNNNNNNNNNNNNYNNNNNNNNNNNNNNNNNNN",
            "NNNNNNNNNNNNNNNNNNNNYNNNNNYNYNYNNNNNNYNNNNNNNNNYNN",
            "NYNNYYNNNNNNNNNYYNNNNNNNNYYNYNNYNYYNNYNYNNNNNNNYNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BigO().minK(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
