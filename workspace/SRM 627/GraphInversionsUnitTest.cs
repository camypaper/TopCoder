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
        int __result = new GraphInversions().getMinimumInversions(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] A, int[] B, int[] V, int K)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine(string.Format("V:{0}", string.Join(" ",V)));
        Console.WriteLine("K:{0}", K);
        int __expected = new GraphInversions().getMinimumInversions(A, B, V, K);
        
        int __result = new GraphInversions().Naive_Test(A, B, V, K);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] A, int[] B, int[] V, int K)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine(string.Format("V:{0}", string.Join(" ",V)));
        Console.WriteLine("K:{0}", K);
        int __result = new GraphInversions().getMinimumInversions(A, B, V, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] A = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2,
            0
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] V = new int[] {
            40,
            50,
            60
        };
        Console.WriteLine(string.Format("V:{0}", string.Join(" ", V)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GraphInversions().getMinimumInversions(A, B, V, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] V = new int[] {
            60,
            40,
            50,
            30
        };
        Console.WriteLine(string.Format("V:{0}", string.Join(" ", V)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GraphInversions().getMinimumInversions(A, B, V, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            0,
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2,
            3,
            0,
            4
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] V = new int[] {
            10,
            10,
            10,
            5,
            5
        };
        Console.WriteLine(string.Format("V:{0}", string.Join(" ", V)));
        int K = 5;
        Console.WriteLine("K:{0}", K);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GraphInversions().getMinimumInversions(A, B, V, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            0,
            1,
            2,
            3,
            0,
            2
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2,
            3,
            0,
            4,
            5
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] V = new int[] {
            10,
            2,
            5,
            3,
            7,
            1
        };
        Console.WriteLine(string.Format("V:{0}", string.Join(" ", V)));
        int K = 6;
        Console.WriteLine("K:{0}", K);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GraphInversions().getMinimumInversions(A, B, V, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            5,
            7,
            7,
            5,
            5,
            7,
            6,
            4
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            0,
            2,
            0,
            1,
            4,
            7,
            3
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] V = new int[] {
            15,
            10,
            5,
            30,
            22,
            10,
            5,
            2
        };
        Console.WriteLine(string.Format("V:{0}", string.Join(" ", V)));
        int K = 6;
        Console.WriteLine("K:{0}", K);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GraphInversions().getMinimumInversions(A, B, V, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
