using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new XorOrderDiv1().get(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int m, int n, int a0, int b)
    {
        Console.WriteLine("m:{0}", m);
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("a0:{0}", a0);
        Console.WriteLine("b:{0}", b);
        int __expected = new XorOrderDiv1().get(m, n, a0, b);
        
        int __result = new XorOrderDiv1().Naive_Test(m, n, a0, b);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int m, int n, int a0, int b)
    {
        Console.WriteLine("m:{0}", m);
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("a0:{0}", a0);
        Console.WriteLine("b:{0}", b);
        int __result = new XorOrderDiv1().get(m, n, a0, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int a0 = 0;
        Console.WriteLine("a0:{0}", a0);
        int b = 1;
        Console.WriteLine("b:{0}", b);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorOrderDiv1().get(m, n, a0, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int a0 = 1;
        Console.WriteLine("a0:{0}", a0);
        int b = 3;
        Console.WriteLine("b:{0}", b);
        int __expected = 48;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorOrderDiv1().get(m, n, a0, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int m = 16;
        Console.WriteLine("m:{0}", m);
        int n = 100;
        Console.WriteLine("n:{0}", n);
        int a0 = 41;
        Console.WriteLine("a0:{0}", a0);
        int b = 5;
        Console.WriteLine("b:{0}", b);
        int __expected = 523436032;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorOrderDiv1().get(m, n, a0, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int m = 30;
        Console.WriteLine("m:{0}", m);
        int n = 200000;
        Console.WriteLine("n:{0}", n);
        int a0 = 399;
        Console.WriteLine("a0:{0}", a0);
        int b = 18082016;
        Console.WriteLine("b:{0}", b);
        int __expected = 408585698;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorOrderDiv1().get(m, n, a0, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
