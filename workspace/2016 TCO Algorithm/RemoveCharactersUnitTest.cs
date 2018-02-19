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
        int __result = new RemoveCharacters().minimalDistinct(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string A, string B)
    {
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        int __expected = new RemoveCharacters().minimalDistinct(A, B);
        
        int __result = new RemoveCharacters().Naive_Test(A, B);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string A, string B)
    {
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        int __result = new RemoveCharacters().minimalDistinct(A, B);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string A = "acabc";
        Console.WriteLine("A:{0}", A);
        string B = "accabcc";
        Console.WriteLine("B:{0}", B);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RemoveCharacters().minimalDistinct(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string A = "aabbcc";
        Console.WriteLine("A:{0}", A);
        string B = "ccbbaa";
        Console.WriteLine("B:{0}", B);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RemoveCharacters().minimalDistinct(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string A = "aaaabc";
        Console.WriteLine("A:{0}", A);
        string B = "bcaaaaa";
        Console.WriteLine("B:{0}", B);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RemoveCharacters().minimalDistinct(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string A = "abcde";
        Console.WriteLine("A:{0}", A);
        string B = "abcde";
        Console.WriteLine("B:{0}", B);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RemoveCharacters().minimalDistinct(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string A = "abcdefghijklm";
        Console.WriteLine("A:{0}", A);
        string B = "nopqrstuvwxyz";
        Console.WriteLine("B:{0}", B);
        int __expected = 26;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RemoveCharacters().minimalDistinct(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
