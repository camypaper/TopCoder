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
        int __result = new SquareScoresDiv2().getscore(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string s)
    {
        Console.WriteLine("s:{0}", s);
        int __expected = new SquareScoresDiv2().getscore(s);
        
        int __result = new SquareScoresDiv2().Naive_Test(s);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string s)
    {
        Console.WriteLine("s:{0}", s);
        int __result = new SquareScoresDiv2().getscore(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "aaaba";
        Console.WriteLine("s:{0}", s);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SquareScoresDiv2().getscore(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "zzzxxzz";
        Console.WriteLine("s:{0}", s);
        int __expected = 12;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SquareScoresDiv2().getscore(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "abcdefghijklmnopqrstuvwxyz";
        Console.WriteLine("s:{0}", s);
        int __expected = 26;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SquareScoresDiv2().getscore(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "p";
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SquareScoresDiv2().getscore(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        Console.WriteLine("s:{0}", s);
        int __expected = 5050;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SquareScoresDiv2().getscore(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
