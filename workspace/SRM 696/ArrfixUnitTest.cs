using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0); Tests.Add(Example1); Tests.Add(Example2); Tests.Add(Example3); Tests.Add(Example4);
    }
    public void ManualTestFromInput(string myinput)
    {
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new Arrfix().mindiff((parser.Items[0] as object[]).Select(x => int.Parse(x.ToString())).ToArray(), (parser.Items[1] as object[]).Select(x => int.Parse(x.ToString())).ToArray(), (parser.Items[2] as object[]).Select(x => int.Parse(x.ToString())).ToArray());
        Console.WriteLine("__result:{0}", __result);
    }
    public void Challenge(int[] A, int[] B, int[] F)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        Console.WriteLine(string.Format("F:{0}", string.Join(" ", F)));
        int __expected = new Arrfix().mindiff(A, B, F);

        int __result = new Arrfix().Naive_Test(A, B, F);

        Assert.AreEqual(__expected, __result);
    }
    public void ManualTest(int[] A, int[] B, int[] F)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        Console.WriteLine(string.Format("F:{0}", string.Join(" ", F)));
        int __result = new Arrfix().mindiff(A, B, F);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] A = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] F = new int[] {
            2
        };
        Console.WriteLine(string.Format("F:{0}", string.Join(" ", F)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Arrfix().mindiff(A, B, F);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            2,
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] F = new int[] {
            2,
            2
        };
        Console.WriteLine(string.Format("F:{0}", string.Join(" ", F)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Arrfix().mindiff(A, B, F);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] F = new int[] {
        };
        Console.WriteLine(string.Format("F:{0}", string.Join(" ", F)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Arrfix().mindiff(A, B, F);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] F = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("F:{0}", string.Join(" ", F)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Arrfix().mindiff(A, B, F);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            1,
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] F = new int[] {
            2,
            2
        };
        Console.WriteLine(string.Format("F:{0}", string.Join(" ", F)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Arrfix().mindiff(A, B, F);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
