using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new NarrowPassage2().count(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] size, int maxSizeSum)
    {
        Console.WriteLine(string.Format("size:{0}", string.Join(" ",size)));
        Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        int __expected = new NarrowPassage2().count(size, maxSizeSum);
        
        int __result = new NarrowPassage2().Naive_Test(size, maxSizeSum);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] size, int maxSizeSum)
    {
        Console.WriteLine(string.Format("size:{0}", string.Join(" ",size)));
        Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        int __result = new NarrowPassage2().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] size = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("size:{0}", string.Join(" ", size)));
        int maxSizeSum = 3;
        Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage2().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] size = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("size:{0}", string.Join(" ", size)));
        int maxSizeSum = 1000;
        Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage2().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] size = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("size:{0}", string.Join(" ", size)));
        int maxSizeSum = 4;
        Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage2().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] size = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("size:{0}", string.Join(" ", size)));
        int maxSizeSum = 2;
        Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        int __expected = 227020758;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage2().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] size = new int[] {
            2,
            4,
            6,
            1,
            3,
            5
        };
        Console.WriteLine(string.Format("size:{0}", string.Join(" ", size)));
        int maxSizeSum = 8;
        Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        int __expected = 60;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage2().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] size = new int[] {
            1000000000
        };
        Console.WriteLine(string.Format("size:{0}", string.Join(" ", size)));
        int maxSizeSum = 1000000000;
        Console.WriteLine("maxSizeSum:{0}", maxSizeSum);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage2().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
