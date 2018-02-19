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
        string __result = new KthStringAgain().getKth(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string s, long k)
    {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("k:{0}", k);
        string __expected = new KthStringAgain().getKth(s, k);
        
        string __result = new KthStringAgain().Naive_Test(s, k);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string s, long k)
    {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("k:{0}", k);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "xyz";
        Console.WriteLine("s:{0}", s);
        long k = 5L;
        Console.WriteLine("k:{0}", k);
        string __expected = "yzx";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "abc";
        Console.WriteLine("s:{0}", s);
        long k = 1L;
        Console.WriteLine("k:{0}", k);
        string __expected = "abc";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "abc";
        Console.WriteLine("s:{0}", s);
        long k = 8L;
        Console.WriteLine("k:{0}", k);
        string __expected = "cba";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "topcoder";
        Console.WriteLine("s:{0}", s);
        long k = 58L;
        Console.WriteLine("k:{0}", k);
        string __expected = "ooredcpt";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "aaaabcdeeeghhhhhiijjjkllmmooooqqrrrrssttuuvvvvvwyy";
        Console.WriteLine("s:{0}", s);
        long k = 38517901796974L;
        Console.WriteLine("k:{0}", k);
        string __expected = "aaaacdeehhhijklmmqqrsttvvvvwyyvuusrrrooooljjihhgeb";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
