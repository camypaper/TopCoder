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
        long __result = new LotsOfLines().countDivisions(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int A, int B)
    {
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        long __expected = new LotsOfLines().countDivisions(A, B);
        
        long __result = new LotsOfLines().Naive_Test(A, B);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int A, int B)
    {
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        long __result = new LotsOfLines().countDivisions(A, B);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int A = 1;
        Console.WriteLine("A:{0}", A);
        int B = 1;
        Console.WriteLine("B:{0}", B);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LotsOfLines().countDivisions(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int A = 2;
        Console.WriteLine("A:{0}", A);
        int B = 2;
        Console.WriteLine("B:{0}", B);
        long __expected = 9L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LotsOfLines().countDivisions(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int A = 3;
        Console.WriteLine("A:{0}", A);
        int B = 2;
        Console.WriteLine("B:{0}", B);
        long __expected = 17L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LotsOfLines().countDivisions(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int A = 1;
        Console.WriteLine("A:{0}", A);
        int B = 1200;
        Console.WriteLine("B:{0}", B);
        long __expected = 1201L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LotsOfLines().countDivisions(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int A = 5;
        Console.WriteLine("A:{0}", A);
        int B = 9;
        Console.WriteLine("B:{0}", B);
        long __expected = 638L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LotsOfLines().countDivisions(A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
