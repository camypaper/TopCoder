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
        int __result = new SuffixArrayDiv1().minimalCharacters(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] SA)
    {
        Console.WriteLine(string.Format("SA:{0}", string.Join(" ",SA)));
        int __expected = new SuffixArrayDiv1().minimalCharacters(SA);
        
        int __result = new SuffixArrayDiv1().Naive_Test(SA);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] SA)
    {
        Console.WriteLine(string.Format("SA:{0}", string.Join(" ",SA)));
        int __result = new SuffixArrayDiv1().minimalCharacters(SA);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] SA = new int[] {
            3,
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("SA:{0}", string.Join(" ", SA)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuffixArrayDiv1().minimalCharacters(SA);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] SA = new int[] {
            3,
            2,
            1,
            0
        };
        Console.WriteLine(string.Format("SA:{0}", string.Join(" ", SA)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuffixArrayDiv1().minimalCharacters(SA);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] SA = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("SA:{0}", string.Join(" ", SA)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuffixArrayDiv1().minimalCharacters(SA);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] SA = new int[] {
            7,
            4,
            8,
            6,
            1,
            5,
            2,
            9,
            3,
            0
        };
        Console.WriteLine(string.Format("SA:{0}", string.Join(" ", SA)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuffixArrayDiv1().minimalCharacters(SA);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] SA = new int[] {
            0
        };
        Console.WriteLine(string.Format("SA:{0}", string.Join(" ", SA)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuffixArrayDiv1().minimalCharacters(SA);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
