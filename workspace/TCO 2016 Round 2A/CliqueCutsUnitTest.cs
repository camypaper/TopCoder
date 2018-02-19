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
        int __result = new CliqueCuts().sum(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int n, int[] a, int[] b, int[] c)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine(string.Format("c:{0}", string.Join(" ",c)));
        int __expected = new CliqueCuts().sum(n, a, b, c);
        
        int __result = new CliqueCuts().Naive_Test(n, a, b, c);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int n, int[] a, int[] b, int[] c)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine(string.Format("c:{0}", string.Join(" ",c)));
        int __result = new CliqueCuts().sum(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            100
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 100;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueCuts().sum(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            0,
            0,
            0,
            1,
            1,
            1,
            2,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            2,
            3,
            4,
            3,
            4,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 45;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueCuts().sum(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            9,
            2,
            4,
            3
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 999999941;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueCuts().sum(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 10;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            1,
            2,
            9,
            5,
            3,
            4,
            7,
            3,
            4,
            1,
            5,
            2,
            3,
            0,
            7,
            8
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            6,
            7,
            4,
            5,
            6,
            2,
            6,
            3,
            1,
            8,
            2,
            0,
            9,
            9,
            8,
            2,
            5
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            10000,
            10000000,
            100000000,
            100,
            10,
            1,
            1000,
            100,
            10000,
            100,
            10000,
            1000,
            100,
            10,
            100,
            100000000,
            10
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 209370454;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueCuts().sum(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 45;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueCuts().sum(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
