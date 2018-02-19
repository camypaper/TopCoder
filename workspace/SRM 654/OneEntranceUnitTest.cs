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
        int __result = new OneEntrance().count(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] a, int[] b, int s)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine("s:{0}", s);
        int __expected = new OneEntrance().count(a, b, s);
        
        int __result = new OneEntrance().Naive_Test(a, b, s);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] a, int[] b, int s)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine("s:{0}", s);
        int __result = new OneEntrance().count(a, b, s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int s = 0;
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneEntrance().count(a, b, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int s = 2;
        Console.WriteLine("s:{0}", s);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneEntrance().count(a, b, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int s = 0;
        Console.WriteLine("s:{0}", s);
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneEntrance().count(a, b, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            7,
            4,
            1,
            0,
            1,
            1,
            6,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            6,
            6,
            2,
            5,
            0,
            3,
            8,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int s = 4;
        Console.WriteLine("s:{0}", s);
        int __expected = 896;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneEntrance().count(a, b, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int s = 0;
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneEntrance().count(a, b, s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
