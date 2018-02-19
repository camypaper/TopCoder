using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        string color = Scanner.In.@string();
        Console.WriteLine("color:{0}", color);
        string[] graph = Scanner.In.string_array();
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ",graph)));
        int __result = new GearsDiv1().getmin(color, graph);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string color, string[] graph)
    {
                        Console.WriteLine("color:{0}", color);
                        Console.WriteLine(string.Format("graph:{0}", string.Join(" ",graph)));
                int __result = new GearsDiv1().getmin(color, graph);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string color = "RGB";
        Console.WriteLine("color:{0}", color);
        string[] graph = new string[] {
            "NYY",
            "YNY",
            "YYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GearsDiv1().getmin(color, graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string color = "RGBR";
        Console.WriteLine("color:{0}", color);
        string[] graph = new string[] {
            "NNNN",
            "NNNN",
            "NNNN",
            "NNNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GearsDiv1().getmin(color, graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string color = "RGBR";
        Console.WriteLine("color:{0}", color);
        string[] graph = new string[] {
            "NYNN",
            "YNYN",
            "NYNY",
            "NNYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GearsDiv1().getmin(color, graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string color = "RRRRRGRRBGRRGBBGGGBRRRGBRGRRGG";
        Console.WriteLine("color:{0}", color);
        string[] graph = new string[] {
            "NNNNNYNNNYNNYNNNYNNNNNNNNYNNYY",
            "NNNNNNNNYNNNYNYNNYNNNNYNNYNNYY",
            "NNNNNYNNNNNNNNNNNNYNNNNNNYNNNY",
            "NNNNNNNNNYNNYNNYYYNNNNYNNYNNNN",
            "NNNNNNNNNYNNYNNYYYNNNNYNNNNNNN",
            "YNYNNNYYYNNYNYYNNNNNYYNYNNYYNN",
            "NNNNNYNNNNNNNNNYYYNNNNYNNYNNYY",
            "NNNNNYNNNNNNNNNYNNNNNNNNNNNNYN",
            "NYNNNYNNNYNNYNNYYYNNNNYNNYNNYY",
            "YNNYYNNNYNNNNYYNNNYNYYNYNNNNNN",
            "NNNNNNNNNNNNYNNYNYNNNNYNNNNNNY",
            "NNNNNYNNNNNNYNNYYYNNNNNNNNNNYN",
            "YYNYYNNNYNYYNYYNNNYNYNNYNNNNNN",
            "NNNNNYNNNYNNYNNYYYNNNNYNNYNYYY",
            "NYNNNYNNNYNNYNNYYYNNNNYNNYNNYY",
            "NNNYYNYYYNYYNYYNNNYNYNNYYNYYNN",
            "YNNYYNYNYNNYNYYNNNYNNNNYYNNYNN",
            "NYNYYNYNYNYYNYYNNNNYYNNYYNYNNN",
            "NNYNNNNNNYNNYNNYYNNNNNYNNYNNNY",
            "NNNNNNNNNNNNNNNNNYNNNNYNNYNNNY",
            "NNNNNYNNNYNNYNNYNYNNNNYNNNNNYY",
            "NNNNNYNNNYNNNNNNNNNNNNYNNNNNNN",
            "NYNYYNYNYNYNNYYNNNYYYYNYYNYNNN",
            "NNNNNYNNNYNNYNNYYYNNNNYNNNNNNY",
            "NNNNNNNNNNNNNNNYYYNNNNYNNYNNYY",
            "YYYYNNYNYNNNNYYNNNYYNNNNYNYYNN",
            "NNNNNYNNNNNNNNNYNYNNNNYNNYNNYN",
            "NNNNNYNNNNNNNYNYYNNNNNNNNYNNYY",
            "YYNNNNYYYNNYNYYNNNNNYNNNYNYYNN",
            "YYYNNNYNYNYNNYYNNNYYYNNYYNNYNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GearsDiv1().getmin(color, graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
