using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new BoardFolding().howMany(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int N, int M, string[] compressedPaper)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("M:{0}", M);
        Console.WriteLine(string.Format("compressedPaper:{0}", string.Join(" ",compressedPaper)));
        int __expected = new BoardFolding().howMany(N, M, compressedPaper);
        
        int __result = new BoardFolding().Naive_Test(N, M, compressedPaper);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int N, int M, string[] compressedPaper)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("M:{0}", M);
        Console.WriteLine(string.Format("compressedPaper:{0}", string.Join(" ",compressedPaper)));
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 2;
        Console.WriteLine("M:{0}", M);
        string[] compressedPaper = new string[] {
            "1",
            "3"
        };
        Console.WriteLine(string.Format("compressedPaper:{0}", string.Join(" ", compressedPaper)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 7;
        Console.WriteLine("M:{0}", M);
        string[] compressedPaper = new string[] {
            "@@",
            "@@"
        };
        Console.WriteLine(string.Format("compressedPaper:{0}", string.Join(" ", compressedPaper)));
        int __expected = 84;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int M = 4;
        Console.WriteLine("M:{0}", M);
        string[] compressedPaper = new string[] {
            "6",
            "9",
            "9",
            "6"
        };
        Console.WriteLine(string.Format("compressedPaper:{0}", string.Join(" ", compressedPaper)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        string[] compressedPaper = new string[] {
            "0",
            "2",
            "6",
            "@",
            "4",
            "A"
        };
        Console.WriteLine(string.Format("compressedPaper:{0}", string.Join(" ", compressedPaper)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int M = 3;
        Console.WriteLine("M:{0}", M);
        string[] compressedPaper = new string[] {
            "0",
            "2",
            "0"
        };
        Console.WriteLine(string.Format("compressedPaper:{0}", string.Join(" ", compressedPaper)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
