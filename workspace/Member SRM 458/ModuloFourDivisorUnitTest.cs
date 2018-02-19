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
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new ModuloFourDivisor().countQuadruplets(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(long[] A, long[] B, long[] C, long[] D)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine(string.Format("C:{0}", string.Join(" ",C)));
        Console.WriteLine(string.Format("D:{0}", string.Join(" ",D)));
        int __expected = new ModuloFourDivisor().countQuadruplets(A, B, C, D);
        
        int __result = new ModuloFourDivisor().Naive_Test(A, B, C, D);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(long[] A, long[] B, long[] C, long[] D)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine(string.Format("C:{0}", string.Join(" ",C)));
        Console.WriteLine(string.Format("D:{0}", string.Join(" ",D)));
        int __result = new ModuloFourDivisor().countQuadruplets(A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long[] A = new long[] {
            1L
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        long[] B = new long[] {
            1L
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        long[] C = new long[] {
            1L
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        long[] D = new long[] {
            0L
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ModuloFourDivisor().countQuadruplets(A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long[] A = new long[] {
            0L
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        long[] B = new long[] {
            0L
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        long[] C = new long[] {
            0L
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        long[] D = new long[] {
            0L
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ModuloFourDivisor().countQuadruplets(A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long[] A = new long[] {
            0L
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        long[] B = new long[] {
            0L,
            1L
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        long[] C = new long[] {
            0L
        };
        Console.WriteLine(string.Format("C:{0}", string.Join(" ", C)));
        long[] D = new long[] {
            0L
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ModuloFourDivisor().countQuadruplets(A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
