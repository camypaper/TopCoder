using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new FromToDivisible().shortest(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3], parser.Items[4]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int N, int S, int T, int[] a, int[] b)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("S:{0}", S);
        Console.WriteLine("T:{0}", T);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        int __expected = new FromToDivisible().shortest(N, S, T, a, b);
        
        int __result = new FromToDivisible().Naive_Test(N, S, T, a, b);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int N, int S, int T, int[] a, int[] b)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("S:{0}", S);
        Console.WriteLine("T:{0}", T);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        int __result = new FromToDivisible().shortest(N, S, T, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 11;
        Console.WriteLine("N:{0}", N);
        int S = 9;
        Console.WriteLine("S:{0}", S);
        int T = 6;
        Console.WriteLine("T:{0}", T);
        int[] a = new int[] {
            3,
            10
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            5,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FromToDivisible().shortest(N, S, T, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 123456789;
        Console.WriteLine("N:{0}", N);
        int S = 18;
        Console.WriteLine("S:{0}", S);
        int T = 12;
        Console.WriteLine("T:{0}", T);
        int[] a = new int[] {
            1,
            42,
            50
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            17,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FromToDivisible().shortest(N, S, T, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 60;
        Console.WriteLine("N:{0}", N);
        int S = 30;
        Console.WriteLine("S:{0}", S);
        int T = 8;
        Console.WriteLine("T:{0}", T);
        int[] a = new int[] {
            16,
            15,
            12
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            20,
            5
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FromToDivisible().shortest(N, S, T, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 77;
        Console.WriteLine("N:{0}", N);
        int S = 10;
        Console.WriteLine("S:{0}", S);
        int T = 62;
        Console.WriteLine("T:{0}", T);
        int[] a = new int[] {
            2,
            5,
            7,
            4,
            17,
            26
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            25,
            7,
            11,
            13,
            31,
            34
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FromToDivisible().shortest(N, S, T, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 100;
        Console.WriteLine("N:{0}", N);
        int S = 90;
        Console.WriteLine("S:{0}", S);
        int T = 40;
        Console.WriteLine("T:{0}", T);
        int[] a = new int[] {
            20,
            30,
            100,
            99,
            100
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            10,
            30,
            100,
            100,
            99
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FromToDivisible().shortest(N, S, T, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 1000000000;
        Console.WriteLine("N:{0}", N);
        int S = 7000;
        Console.WriteLine("S:{0}", S);
        int T = 424212345;
        Console.WriteLine("T:{0}", T);
        int[] a = new int[] {
            35000000,
            120000000,
            424212345,
            200000000,
            3500,
            19
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            15,
            1,
            7000,
            200000000,
            400000000,
            17
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FromToDivisible().shortest(N, S, T, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int S = 1;
        Console.WriteLine("S:{0}", S);
        int T = 2;
        Console.WriteLine("T:{0}", T);
        int[] a = new int[] {
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FromToDivisible().shortest(N, S, T, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
