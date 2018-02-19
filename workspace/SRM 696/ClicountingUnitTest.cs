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
        int __result = new Clicounting().count(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string[] g)
    {
        Console.WriteLine(string.Format("g:{0}", string.Join(" ",g)));
        int __expected = new Clicounting().count(g);
        
        int __result = new Clicounting().Naive_Test(g);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string[] g)
    {
        Console.WriteLine(string.Format("g:{0}", string.Join(" ",g)));
        int __result = new Clicounting().count(g);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] g = new string[] {
            "011",
            "101",
            "110"
        };
        Console.WriteLine(string.Format("g:{0}", string.Join(" ", g)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Clicounting().count(g);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] g = new string[] {
            "01?",
            "101",
            "?10"
        };
        Console.WriteLine(string.Format("g:{0}", string.Join(" ", g)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Clicounting().count(g);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] g = new string[] {
            "0?",
            "?0"
        };
        Console.WriteLine(string.Format("g:{0}", string.Join(" ", g)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Clicounting().count(g);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] g = new string[] {
            "0??",
            "?0?",
            "??0"
        };
        Console.WriteLine(string.Format("g:{0}", string.Join(" ", g)));
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Clicounting().count(g);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] g = new string[] {
            "0???",
            "?0??",
            "??0?",
            "???0"
        };
        Console.WriteLine(string.Format("g:{0}", string.Join(" ", g)));
        int __expected = 151;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Clicounting().count(g);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
