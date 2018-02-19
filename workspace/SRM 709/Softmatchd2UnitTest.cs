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
        int __result = new Softmatchd2().count(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string S, string pattern)
    {
        Console.WriteLine("S:{0}", S);
        Console.WriteLine("pattern:{0}", pattern);
        int __expected = new Softmatchd2().count(S, pattern);
        
        int __result = new Softmatchd2().Naive_Test(S, pattern);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string S, string pattern)
    {
        Console.WriteLine("S:{0}", S);
        Console.WriteLine("pattern:{0}", pattern);
        int __result = new Softmatchd2().count(S, pattern);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string S = "aba";
        Console.WriteLine("S:{0}", S);
        string pattern = "13";
        Console.WriteLine("pattern:{0}", pattern);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatchd2().count(S, pattern);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string S = "abbaa";
        Console.WriteLine("S:{0}", S);
        string pattern = "123";
        Console.WriteLine("pattern:{0}", pattern);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatchd2().count(S, pattern);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string S = "aaaa";
        Console.WriteLine("S:{0}", S);
        string pattern = "1230";
        Console.WriteLine("pattern:{0}", pattern);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatchd2().count(S, pattern);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string S = "ababbaaba";
        Console.WriteLine("S:{0}", S);
        string pattern = "0311";
        Console.WriteLine("pattern:{0}", pattern);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatchd2().count(S, pattern);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string S = "aabbbabbbb";
        Console.WriteLine("S:{0}", S);
        string pattern = "332233";
        Console.WriteLine("pattern:{0}", pattern);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatchd2().count(S, pattern);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string S = "aaaabbbababababababaaabaa";
        Console.WriteLine("S:{0}", S);
        string pattern = "02232";
        Console.WriteLine("pattern:{0}", pattern);
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatchd2().count(S, pattern);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
