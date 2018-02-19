using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        long __result = new OthersXor().minSum(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] x)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        long __expected = new OthersXor().minSum(x);
        
        long __result = new OthersXor().Naive_Test(x);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] x)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        long __result = new OthersXor().minSum(x);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            1,
            -1,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new OthersXor().minSum(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new OthersXor().minSum(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            70,
            100
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        long __expected = 170L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new OthersXor().minSum(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            -1,
            0,
            -1,
            100,
            36
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        long __expected = 164L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new OthersXor().minSum(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            0,
            536870912,
            0,
            536870912,
            0,
            536870912,
            0,
            536870912,
            0,
            536870912,
            0,
            536870912,
            0,
            536870912,
            0,
            536870912,
            0,
            536870912,
            0,
            536870912,
            1073741823,
            1073741823,
            1073741823,
            123456789,
            987654321,
            804289383
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        long __expected = 11992352010L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new OthersXor().minSum(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] x = new int[] {
            1287325,
            424244444,
            92759185,
            812358213,
            1000000000,
            825833522,
            749092703
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new OthersXor().minSum(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] x = new int[] {
            -1,
            -1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new OthersXor().minSum(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
