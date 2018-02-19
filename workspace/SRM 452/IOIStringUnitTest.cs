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
        int __result = new IOIString().countIOIs(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string[] mask)
    {
        Console.WriteLine(string.Format("mask:{0}", string.Join(" ",mask)));
        int __expected = new IOIString().countIOIs(mask);
        
        int __result = new IOIString().Naive_Test(mask);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string[] mask)
    {
        Console.WriteLine(string.Format("mask:{0}", string.Join(" ",mask)));
        int __result = new IOIString().countIOIs(mask);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] mask = new string[] {
            "IO?"
        };
        Console.WriteLine(string.Format("mask:{0}", string.Join(" ", mask)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new IOIString().countIOIs(mask);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] mask = new string[] {
            "????"
        };
        Console.WriteLine(string.Format("mask:{0}", string.Join(" ", mask)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new IOIString().countIOIs(mask);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] mask = new string[] {
            "?II"
        };
        Console.WriteLine(string.Format("mask:{0}", string.Join(" ", mask)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new IOIString().countIOIs(mask);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] mask = new string[] {
            "I??O??I"
        };
        Console.WriteLine(string.Format("mask:{0}", string.Join(" ", mask)));
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new IOIString().countIOIs(mask);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] mask = new string[] {
            "???I???????O???",
            "???????????O??IO????????I???"
        };
        Console.WriteLine(string.Format("mask:{0}", string.Join(" ", mask)));
        int __expected = 438952513;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new IOIString().countIOIs(mask);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
