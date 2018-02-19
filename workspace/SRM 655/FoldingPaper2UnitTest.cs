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
        int __result = new FoldingPaper2().solve(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int W, int H, int A)
    {
        Console.WriteLine("W:{0}", W);
        Console.WriteLine("H:{0}", H);
        Console.WriteLine("A:{0}", A);
        int __expected = new FoldingPaper2().solve(W, H, A);
        
        int __result = new FoldingPaper2().Naive_Test(W, H, A);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int W, int H, int A)
    {
        Console.WriteLine("W:{0}", W);
        Console.WriteLine("H:{0}", H);
        Console.WriteLine("A:{0}", A);
        int __result = new FoldingPaper2().solve(W, H, A);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int W = 5;
        Console.WriteLine("W:{0}", W);
        int H = 3;
        Console.WriteLine("H:{0}", H);
        int A = 12;
        Console.WriteLine("A:{0}", A);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoldingPaper2().solve(W, H, A);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int W = 2;
        Console.WriteLine("W:{0}", W);
        int H = 2;
        Console.WriteLine("H:{0}", H);
        int A = 3;
        Console.WriteLine("A:{0}", A);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoldingPaper2().solve(W, H, A);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int W = 4;
        Console.WriteLine("W:{0}", W);
        int H = 4;
        Console.WriteLine("H:{0}", H);
        int A = 1;
        Console.WriteLine("A:{0}", A);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoldingPaper2().solve(W, H, A);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int W = 127;
        Console.WriteLine("W:{0}", W);
        int H = 129;
        Console.WriteLine("H:{0}", H);
        int A = 72;
        Console.WriteLine("A:{0}", A);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoldingPaper2().solve(W, H, A);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int W = 1;
        Console.WriteLine("W:{0}", W);
        int H = 100000;
        Console.WriteLine("H:{0}", H);
        int A = 100000;
        Console.WriteLine("A:{0}", A);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoldingPaper2().solve(W, H, A);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int W = 1;
        Console.WriteLine("W:{0}", W);
        int H = 1;
        Console.WriteLine("H:{0}", H);
        int A = 2;
        Console.WriteLine("A:{0}", A);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoldingPaper2().solve(W, H, A);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
