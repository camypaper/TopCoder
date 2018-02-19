using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        string[] graph = Scanner.In.string_array();
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ",graph)));
        int[] winprob = Scanner.In.int_array();
        Console.WriteLine(string.Format("winprob:{0}", string.Join(" ",winprob)));
        int[] looseprob = Scanner.In.int_array();
        Console.WriteLine(string.Format("looseprob:{0}", string.Join(" ",looseprob)));
        int Start = Scanner.In.@int();
        Console.WriteLine("Start:{0}", Start);
        double __result = new GraphWalkWithProbabilities().findprob(graph, winprob, looseprob, Start);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string[] graph, int[] winprob, int[] looseprob, int Start)
    {
                        Console.WriteLine(string.Format("graph:{0}", string.Join(" ",graph)));
                        Console.WriteLine(string.Format("winprob:{0}", string.Join(" ",winprob)));
                        Console.WriteLine(string.Format("looseprob:{0}", string.Join(" ",looseprob)));
                        Console.WriteLine("Start:{0}", Start);
                double __result = new GraphWalkWithProbabilities().findprob(graph, winprob, looseprob, Start);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] graph = new string[] {
            "1"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int[] winprob = new int[] {
            1
        };
        Console.WriteLine(string.Format("winprob:{0}", string.Join(" ", winprob)));
        int[] looseprob = new int[] {
            1
        };
        Console.WriteLine(string.Format("looseprob:{0}", string.Join(" ", looseprob)));
        int Start = 0;
        Console.WriteLine("Start:{0}", Start);
        double __expected = 0.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GraphWalkWithProbabilities().findprob(graph, winprob, looseprob, Start);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        string[] graph = new string[] {
            "11",
            "11"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int[] winprob = new int[] {
            60,
            40
        };
        Console.WriteLine(string.Format("winprob:{0}", string.Join(" ", winprob)));
        int[] looseprob = new int[] {
            40,
            60
        };
        Console.WriteLine(string.Format("looseprob:{0}", string.Join(" ", looseprob)));
        int Start = 0;
        Console.WriteLine("Start:{0}", Start);
        double __expected = 0.6;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GraphWalkWithProbabilities().findprob(graph, winprob, looseprob, Start);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        string[] graph = new string[] {
            "11",
            "11"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int[] winprob = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("winprob:{0}", string.Join(" ", winprob)));
        int[] looseprob = new int[] {
            3,
            4
        };
        Console.WriteLine(string.Format("looseprob:{0}", string.Join(" ", looseprob)));
        int Start = 0;
        Console.WriteLine("Start:{0}", Start);
        double __expected = 0.4285714285714286;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GraphWalkWithProbabilities().findprob(graph, winprob, looseprob, Start);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        string[] graph = new string[] {
            "110",
            "011",
            "001"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int[] winprob = new int[] {
            2,
            1,
            10
        };
        Console.WriteLine(string.Format("winprob:{0}", string.Join(" ", winprob)));
        int[] looseprob = new int[] {
            20,
            20,
            10
        };
        Console.WriteLine(string.Format("looseprob:{0}", string.Join(" ", looseprob)));
        int Start = 0;
        Console.WriteLine("Start:{0}", Start);
        double __expected = 0.405;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GraphWalkWithProbabilities().findprob(graph, winprob, looseprob, Start);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        string[] graph = new string[] {
            "111",
            "111",
            "011"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int[] winprob = new int[] {
            100,
            1,
            1
        };
        Console.WriteLine(string.Format("winprob:{0}", string.Join(" ", winprob)));
        int[] looseprob = new int[] {
            0,
            50,
            50
        };
        Console.WriteLine(string.Format("looseprob:{0}", string.Join(" ", looseprob)));
        int Start = 2;
        Console.WriteLine("Start:{0}", Start);
        double __expected = 0.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GraphWalkWithProbabilities().findprob(graph, winprob, looseprob, Start);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
