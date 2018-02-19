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
        string __result = new PartisanGame().getWinner(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int n, int[] a, int[] b)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        string __expected = new PartisanGame().getWinner(n, a, b);
        

        }
    public void ManualTest(int n, int[] a, int[] b)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        string __result = new PartisanGame().getWinner(n, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 7;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            3,
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PartisanGame().getWinner(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 10;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            4,
            3,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Bob";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PartisanGame().getWinner(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 104982;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            5
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PartisanGame().getWinner(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 999999999;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            5
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Bob";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PartisanGame().getWinner(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 1000000000;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PartisanGame().getWinner(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
