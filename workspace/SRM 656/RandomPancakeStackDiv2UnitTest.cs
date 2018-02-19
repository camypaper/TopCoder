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
        double __result = new RandomPancakeStackDiv2().expectedDeliciousness(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] d)
    {
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        double __expected = new RandomPancakeStackDiv2().expectedDeliciousness(d);
        
        double __result = new RandomPancakeStackDiv2().Naive_Test(d);

        Assert.AreEqual(__expected, __result, 1e-9);
    }
    public void ManualTest(int[] d)
    {
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        double __result = new RandomPancakeStackDiv2().expectedDeliciousness(d);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] d = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        double __expected = 1.6666666666666667;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomPancakeStackDiv2().expectedDeliciousness(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] d = new int[] {
            10,
            20
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        double __expected = 20.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomPancakeStackDiv2().expectedDeliciousness(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] d = new int[] {
            3,
            6,
            10,
            9,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        double __expected = 9.891666666666667;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomPancakeStackDiv2().expectedDeliciousness(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] d = new int[] {
            10,
            9,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        double __expected = 10.999999724426809;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomPancakeStackDiv2().expectedDeliciousness(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] d = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        double __expected = 7.901100088183421;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomPancakeStackDiv2().expectedDeliciousness(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example5()
    {
        int[] d = new int[] {
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
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        double __expected = 1.7182818011463845;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomPancakeStackDiv2().expectedDeliciousness(d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
