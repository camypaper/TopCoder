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
        int __result = new RepeatString().minimalModify(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string s)
    {
        Console.WriteLine("s:{0}", s);
        int __expected = new RepeatString().minimalModify(s);
        
        int __result = new RepeatString().Naive_Test(s);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string s)
    {
        Console.WriteLine("s:{0}", s);
        int __result = new RepeatString().minimalModify(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "aba";
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RepeatString().minimalModify(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "adam";
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RepeatString().minimalModify(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "x";
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RepeatString().minimalModify(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "aaabbbaaaccc";
        Console.WriteLine("s:{0}", s);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RepeatString().minimalModify(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "repeatstring";
        Console.WriteLine("s:{0}", s);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RepeatString().minimalModify(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string s = "aaaaaaaaaaaaaaaaaaaa";
        Console.WriteLine("s:{0}", s);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RepeatString().minimalModify(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
