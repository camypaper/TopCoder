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
        long __result = new MultiplyAddPuzzle().minimalSteps(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(long s, long t, long a, long b)
    {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("t:{0}", t);
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        long __expected = new MultiplyAddPuzzle().minimalSteps(s, t, a, b);
        
        long __result = new MultiplyAddPuzzle().Naive_Test(s, t, a, b);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(long s, long t, long a, long b)
    {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("t:{0}", t);
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        long __result = new MultiplyAddPuzzle().minimalSteps(s, t, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long s = 10L;
        Console.WriteLine("s:{0}", s);
        long t = 40L;
        Console.WriteLine("t:{0}", t);
        long a = 4L;
        Console.WriteLine("a:{0}", a);
        long b = 2L;
        Console.WriteLine("b:{0}", b);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MultiplyAddPuzzle().minimalSteps(s, t, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long s = 10L;
        Console.WriteLine("s:{0}", s);
        long t = 28L;
        Console.WriteLine("t:{0}", t);
        long a = 4L;
        Console.WriteLine("a:{0}", a);
        long b = 2L;
        Console.WriteLine("b:{0}", b);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MultiplyAddPuzzle().minimalSteps(s, t, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long s = 10L;
        Console.WriteLine("s:{0}", s);
        long t = 99L;
        Console.WriteLine("t:{0}", t);
        long a = 4L;
        Console.WriteLine("a:{0}", a);
        long b = 2L;
        Console.WriteLine("b:{0}", b);
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MultiplyAddPuzzle().minimalSteps(s, t, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long s = 345L;
        Console.WriteLine("s:{0}", s);
        long t = 12345L;
        Console.WriteLine("t:{0}", t);
        long a = 1L;
        Console.WriteLine("a:{0}", a);
        long b = 10L;
        Console.WriteLine("b:{0}", b);
        long __expected = 895L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MultiplyAddPuzzle().minimalSteps(s, t, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long s = 1000000000000000000L;
        Console.WriteLine("s:{0}", s);
        long t = 1000000000000000000L;
        Console.WriteLine("t:{0}", t);
        long a = 1000000000000000000L;
        Console.WriteLine("a:{0}", a);
        long b = 1000000000000000000L;
        Console.WriteLine("b:{0}", b);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MultiplyAddPuzzle().minimalSteps(s, t, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
