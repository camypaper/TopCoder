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
        int __result = new Softmatch().count(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string S, string[] patterns)
    {
        Console.WriteLine("S:{0}", S);
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ",patterns)));
        int __expected = new Softmatch().count(S, patterns);
        
        int __result = new Softmatch().Naive_Test(S, patterns);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string S, string[] patterns)
    {
        Console.WriteLine("S:{0}", S);
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ",patterns)));
        int __result = new Softmatch().count(S, patterns);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string S = "aaa";
        Console.WriteLine("S:{0}", S);
        string[] patterns = new string[] {
            "03",
            "21"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatch().count(S, patterns);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string S = "aba";
        Console.WriteLine("S:{0}", S);
        string[] patterns = new string[] {
            "03",
            "11"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatch().count(S, patterns);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string S = "bba";
        Console.WriteLine("S:{0}", S);
        string[] patterns = new string[] {
            "00",
            "00"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatch().count(S, patterns);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string S = "bbbbbb";
        Console.WriteLine("S:{0}", S);
        string[] patterns = new string[] {
            "1110",
            "011",
            "100"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatch().count(S, patterns);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string S = "abbaa";
        Console.WriteLine("S:{0}", S);
        string[] patterns = new string[] {
            "123"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatch().count(S, patterns);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string S = "aababbaab";
        Console.WriteLine("S:{0}", S);
        string[] patterns = new string[] {
            "012",
            "332",
            "101",
            "0313"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Softmatch().count(S, patterns);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
