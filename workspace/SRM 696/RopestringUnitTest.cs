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
        string __result = new Ropestring().makerope(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string s)
    {
        Console.WriteLine("s:{0}", s);
        string __expected = new Ropestring().makerope(s);
        
        string __result = new Ropestring().Naive_Test(s);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string s)
    {
        Console.WriteLine("s:{0}", s);
        string __result = new Ropestring().makerope(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "..-..-";
        Console.WriteLine("s:{0}", s);
        string __expected = "-.-...";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new Ropestring().makerope(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "-.-";
        Console.WriteLine("s:{0}", s);
        string __expected = "-.-";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new Ropestring().makerope(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "--..-.---..--";
        Console.WriteLine("s:{0}", s);
        string __expected = "--.--.---.-..";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new Ropestring().makerope(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "--..-.---..--..-----.--.";
        Console.WriteLine("s:{0}", s);
        string __expected = "--.--.--.-----.---.-....";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new Ropestring().makerope(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "...";
        Console.WriteLine("s:{0}", s);
        string __expected = "...";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new Ropestring().makerope(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
