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
        int __result = new PotentialArithmeticSequence().numberOfSubsequences(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] d)
    {
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        int __expected = new PotentialArithmeticSequence().numberOfSubsequences(d);
        
        int __result = new PotentialArithmeticSequence().Naive_Test(d);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] d)
    {
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        int __result = new PotentialArithmeticSequence().numberOfSubsequences(d);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] d = new int[] {
            0,
            1,
            0,
            2,
            0,
            1,
            0
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 28;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PotentialArithmeticSequence().numberOfSubsequences(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] d = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PotentialArithmeticSequence().numberOfSubsequences(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] d = new int[] {
            0,
            0,
            0,
            0,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PotentialArithmeticSequence().numberOfSubsequences(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] d = new int[] {
            0,
            100,
            0,
            2,
            0
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 11;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PotentialArithmeticSequence().numberOfSubsequences(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] d = new int[] {
            1,
            11,
            3,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            1,
            0,
            3,
            0,
            2,
            0,
            0,
            0,
            0,
            1,
            2,
            3,
            20
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 49;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PotentialArithmeticSequence().numberOfSubsequences(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
