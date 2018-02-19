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
        int __result = new TwoSquares().maxOnes(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string[] t)
    {
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int __expected = new TwoSquares().maxOnes(t);
        
        int __result = new TwoSquares().Naive_Test(t);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string[] t)
    {
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int __result = new TwoSquares().maxOnes(t);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] t = new string[] {
            "000",
            "010",
            "011"
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSquares().maxOnes(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] t = new string[] {
            "0"
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSquares().maxOnes(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] t = new string[] {
            "0001",
            "0001",
            "0111",
            "1001"
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSquares().maxOnes(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] t = new string[] {
            "001111",
            "111111",
            "110001",
            "110001",
            "110001",
            "111111"
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 35;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSquares().maxOnes(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
