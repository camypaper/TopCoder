using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        string __result = new DivisibleSetDiv1().isPossible(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] b)
    {
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        string __expected = new DivisibleSetDiv1().isPossible(b);
        
        string __result = new DivisibleSetDiv1().Naive_Test(b);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] b)
    {
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        string __result = new DivisibleSetDiv1().isPossible(b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] b = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DivisibleSetDiv1().isPossible(b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] b = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DivisibleSetDiv1().isPossible(b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] b = new int[] {
            7,
            7,
            7
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DivisibleSetDiv1().isPossible(b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] b = new int[] {
            5,
            3,
            5,
            4,
            6,
            1,
            3,
            7,
            9,
            6,
            2,
            5,
            4,
            1,
            1,
            9,
            6,
            10,
            10,
            6,
            10,
            7,
            7,
            8
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DivisibleSetDiv1().isPossible(b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
