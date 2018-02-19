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
        int __result = new NineEasy().count(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int N, int[] d)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        int __expected = new NineEasy().count(N, d);
        
        int __result = new NineEasy().Naive_Test(N, d);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int N, int[] d)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        int __result = new NineEasy().count(N, d);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NineEasy().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            3,
            3
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 12;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NineEasy().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NineEasy().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            1,
            2,
            4,
            8,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 893703876;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NineEasy().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 200;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NineEasy().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
