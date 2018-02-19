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
        long __result = new DivisorsPower().findArgument(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(long n)
    {
        Console.WriteLine("n:{0}", n);
        long __expected = new DivisorsPower().findArgument(n);
        
        long __result = new DivisorsPower().Naive_Test(n);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(long n)
    {
        Console.WriteLine("n:{0}", n);
        long __result = new DivisorsPower().findArgument(n);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long n = 4L;
        Console.WriteLine("n:{0}", n);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new DivisorsPower().findArgument(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long n = 10L;
        Console.WriteLine("n:{0}", n);
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new DivisorsPower().findArgument(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long n = 64L;
        Console.WriteLine("n:{0}", n);
        long __expected = 4L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new DivisorsPower().findArgument(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long n = 10000L;
        Console.WriteLine("n:{0}", n);
        long __expected = 10L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new DivisorsPower().findArgument(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long n = 2498388559757689L;
        Console.WriteLine("n:{0}", n);
        long __expected = 49983883L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new DivisorsPower().findArgument(n);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
