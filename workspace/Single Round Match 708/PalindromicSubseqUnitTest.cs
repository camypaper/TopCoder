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
        int __result = new PalindromicSubseq().solve(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string s)
    {
        Console.WriteLine("s:{0}", s);
        int __expected = new PalindromicSubseq().solve(s);
        
        int __result = new PalindromicSubseq().Naive_Test(s);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string s)
    {
        Console.WriteLine("s:{0}", s);
        int __result = new PalindromicSubseq().solve(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "aaba";
        Console.WriteLine("s:{0}", s);
        int __expected = 30;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromicSubseq().solve(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "abcd";
        Console.WriteLine("s:{0}", s);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromicSubseq().solve(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "tcoct";
        Console.WriteLine("s:{0}", s);
        int __expected = 60;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromicSubseq().solve(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "zyzyzzzzxzyz";
        Console.WriteLine("s:{0}", s);
        int __expected = 717;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromicSubseq().solve(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        Console.WriteLine("s:{0}", s);
        int __expected = 1025495382;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromicSubseq().solve(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
