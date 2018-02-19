using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);        
    }
	public void ManualTest(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new DrivingPlans().count(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int N, int[] A, int[] B, int[] C)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine(string.Format("C:{0}", string.Join(" ",C)));
        int __expected = new DrivingPlans().count(N, A, B, C);
        
        int __result = new DrivingPlans().Naive_Test(N, A, B, C);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int N, int[] A, int[] B, int[] C)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine(string.Format("C:{0}", string.Join(" ",C)));
        int __result = new DrivingPlans().count(N, A, B, C);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            1,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4,
            4
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] C = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DrivingPlans().count(N, A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            1,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4,
            4
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] C = new int[] {
            1,
            1,
            1,
            0
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DrivingPlans().count(N, A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 7;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            1,
            1,
            2,
            3,
            4,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4,
            4,
            5,
            6,
            7,
            7
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] C = new int[] {
            1,
            1,
            2,
            2,
            3,
            3,
            4,
            4
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DrivingPlans().count(N, A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
