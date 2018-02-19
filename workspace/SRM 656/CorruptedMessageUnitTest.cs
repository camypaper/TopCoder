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
        string __result = new CorruptedMessage().reconstructMessage(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string s, int k)
    {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("k:{0}", k);
        string __expected = new CorruptedMessage().reconstructMessage(s, k);
        
        string __result = new CorruptedMessage().Naive_Test(s, k);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string s, int k)
    {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("k:{0}", k);
        string __result = new CorruptedMessage().reconstructMessage(s, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "hello";
        Console.WriteLine("s:{0}", s);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        string __expected = "lllll";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CorruptedMessage().reconstructMessage(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "abc";
        Console.WriteLine("s:{0}", s);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        string __expected = "ddd";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CorruptedMessage().reconstructMessage(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "wwwwwwwwwwwwwwwwww";
        Console.WriteLine("s:{0}", s);
        int k = 0;
        Console.WriteLine("k:{0}", k);
        string __expected = "wwwwwwwwwwwwwwwwww";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CorruptedMessage().reconstructMessage(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "ababba";
        Console.WriteLine("s:{0}", s);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        string __expected = "aaaaaa";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CorruptedMessage().reconstructMessage(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "zoztxtoxytyt";
        Console.WriteLine("s:{0}", s);
        int k = 10;
        Console.WriteLine("k:{0}", k);
        string __expected = "oooooooooooo";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CorruptedMessage().reconstructMessage(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string s = "jlmnmiunaxzywed";
        Console.WriteLine("s:{0}", s);
        int k = 13;
        Console.WriteLine("k:{0}", k);
        string __expected = "mmmmmmmmmmmmmmm";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CorruptedMessage().reconstructMessage(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
