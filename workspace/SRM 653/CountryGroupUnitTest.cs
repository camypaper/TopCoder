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
        int __result = new CountryGroup().solve(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] a)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        int __expected = new CountryGroup().solve(a);
        
        int __result = new CountryGroup().Naive_Test(a);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] a)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        int __result = new CountryGroup().solve(a);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            2,
            2,
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CountryGroup().solve(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CountryGroup().solve(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            3,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CountryGroup().solve(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            4,
            4,
            4,
            4,
            1,
            1,
            2,
            2,
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CountryGroup().solve(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            2,
            1,
            2,
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CountryGroup().solve(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
