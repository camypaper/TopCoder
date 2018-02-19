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
        int __result = new CandyCupRunningCompetition().findMaximum(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int N, int[] A, int[] B)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        int __expected = new CandyCupRunningCompetition().findMaximum(N, A, B);
        
        int __result = new CandyCupRunningCompetition().Naive_Test(N, A, B);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int N, int[] A, int[] B)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        int __result = new CandyCupRunningCompetition().findMaximum(N, A, B);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCupRunningCompetition().findMaximum(N, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            0,
            1,
            0,
            2
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            3,
            2,
            3
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCupRunningCompetition().findMaximum(N, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            0
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCupRunningCompetition().findMaximum(N, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCupRunningCompetition().findMaximum(N, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            1,
            1,
            2,
            0,
            4,
            3,
            0,
            1,
            4
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            3,
            2,
            3,
            1,
            5,
            5,
            2,
            4,
            3
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 39;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCupRunningCompetition().findMaximum(N, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
