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
        double __result = new OptimalBetting().findProbability(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int a, int b, int k)
    {
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("k:{0}", k);
        double __expected = new OptimalBetting().findProbability(a, b, k);
        
        double __result = new OptimalBetting().Naive_Test(a, b, k);

        Assert.AreEqual(__expected, __result, 1e-9);
    }
    public void ManualTest(int a, int b, int k)
    {
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("k:{0}", k);
        double __result = new OptimalBetting().findProbability(a, b, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int a = 23;
        Console.WriteLine("a:{0}", a);
        int b = 26;
        Console.WriteLine("b:{0}", b);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        double __expected = 0.875;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new OptimalBetting().findProbability(a, b, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int a = 7;
        Console.WriteLine("a:{0}", a);
        int b = 1000;
        Console.WriteLine("b:{0}", b);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        double __expected = 1.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new OptimalBetting().findProbability(a, b, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int a = 2;
        Console.WriteLine("a:{0}", a);
        int b = 3;
        Console.WriteLine("b:{0}", b);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        double __expected = 0.8888888888888887;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new OptimalBetting().findProbability(a, b, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int a = 7;
        Console.WriteLine("a:{0}", a);
        int b = 8;
        Console.WriteLine("b:{0}", b);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        double __expected = 0.06785714285714287;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new OptimalBetting().findProbability(a, b, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int a = 10;
        Console.WriteLine("a:{0}", a);
        int b = 20;
        Console.WriteLine("b:{0}", b);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        double __expected = 0.09917355371900842;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new OptimalBetting().findProbability(a, b, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example5()
    {
        int a = 1234;
        Console.WriteLine("a:{0}", a);
        int b = 1567;
        Console.WriteLine("b:{0}", b);
        int k = 5;
        Console.WriteLine("k:{0}", k);
        double __expected = 0.00861475126753315;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new OptimalBetting().findProbability(a, b, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example6()
    {
        int a = 50123;
        Console.WriteLine("a:{0}", a);
        int b = 87654;
        Console.WriteLine("b:{0}", b);
        int k = 5;
        Console.WriteLine("k:{0}", k);
        double __expected = 0.02304278352341867;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new OptimalBetting().findProbability(a, b, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
