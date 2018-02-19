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
        int __result = new SingingEasy().solve(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] pitch)
    {
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ",pitch)));
        int __expected = new SingingEasy().solve(pitch);
        
        int __result = new SingingEasy().Naive_Test(pitch);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] pitch)
    {
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ",pitch)));
        int __result = new SingingEasy().solve(pitch);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] pitch = new int[] {
            1,
            3,
            8,
            12,
            13
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SingingEasy().solve(pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] pitch = new int[] {
            1,
            5,
            6,
            2,
            1
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SingingEasy().solve(pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] pitch = new int[] {
            5,
            5,
            5,
            5,
            4,
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SingingEasy().solve(pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] pitch = new int[] {
            1000000
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SingingEasy().solve(pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] pitch = new int[] {
            24,
            13,
            2,
            4,
            54,
            23,
            12,
            53,
            12,
            23,
            42,
            13,
            53,
            12,
            24,
            12,
            11,
            24,
            42,
            52,
            12,
            32,
            42
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 188;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SingingEasy().solve(pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
