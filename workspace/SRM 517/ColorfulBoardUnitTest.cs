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
        int __result = new ColorfulBoard().theMin(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string[] board)
    {
        Console.WriteLine(string.Format("board:{0}", string.Join(" ",board)));
        int __expected = new ColorfulBoard().theMin(board);
        
        int __result = new ColorfulBoard().Naive_Test(board);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string[] board)
    {
        Console.WriteLine(string.Format("board:{0}", string.Join(" ",board)));
        int __result = new ColorfulBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "SSS",
            "SRR",
            "SMM"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "BBBBBBBB",
            "BBBBBBBB",
            "BBBBBBBB",
            "BBBBBBBB",
            "BBBBBBBB"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "Ab",
            "bA"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "iiiii",
            "iwiwi"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            "ffffffffff",
            "xfxxoofoxo",
            "ffffffffff",
            "xfxxoofoxo",
            "ffffffffff",
            "ooxxoofoxo",
            "xfxxoofoxo",
            "xfxxoxfxxo",
            "ffxxofffxo",
            "xfxxoxfxxo"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 17;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
