using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new Permatchd2().fix(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string[] graph)
    {
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ",graph)));
        int __expected = new Permatchd2().fix(graph);
        
        int __result = new Permatchd2().Naive_Test(graph);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string[] graph)
    {
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ",graph)));
        int __result = new Permatchd2().fix(graph);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] graph = new string[] {
            "NYN",
            "YNN",
            "NNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Permatchd2().fix(graph);
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
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Permatchd2().fix(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] graph = new string[] {
            "NYY",
            "YNY",
            "YYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Permatchd2().fix(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] graph = new string[] {
            "NYYY",
            "YNYY",
            "YYNN",
            "YYNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Permatchd2().fix(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] graph = new string[] {
            "NYNNNN",
            "YNNNNN",
            "NNNYNN",
            "NNYNNN",
            "NNNNNY",
            "NNNNYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Permatchd2().fix(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] graph = new string[] {
            "N"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Permatchd2().fix(graph);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
