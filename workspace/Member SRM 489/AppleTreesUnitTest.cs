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
        int __result = new AppleTrees().theCount(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int D, int[] r)
    {
        Console.WriteLine("D:{0}", D);
        Console.WriteLine(string.Format("r:{0}", string.Join(" ",r)));
        int __expected = new AppleTrees().theCount(D, r);
        
        int __result = new AppleTrees().Naive_Test(D, r);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int D, int[] r)
    {
        Console.WriteLine("D:{0}", D);
        Console.WriteLine(string.Format("r:{0}", string.Join(" ",r)));
        int __result = new AppleTrees().theCount(D, r);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int D = 10;
        Console.WriteLine("D:{0}", D);
        int[] r = new int[] {
            40
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleTrees().theCount(D, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int D = 4;
        Console.WriteLine("D:{0}", D);
        int[] r = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleTrees().theCount(D, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int D = 4;
        Console.WriteLine("D:{0}", D);
        int[] r = new int[] {
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleTrees().theCount(D, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int D = 58;
        Console.WriteLine("D:{0}", D);
        int[] r = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        int __expected = 2550;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleTrees().theCount(D, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int D = 47;
        Console.WriteLine("D:{0}", D);
        int[] r = new int[] {
            4,
            8,
            9
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        int __expected = 28830;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleTrees().theCount(D, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int D = 100000;
        Console.WriteLine("D:{0}", D);
        int[] r = new int[] {
            21,
            37,
            23,
            13,
            32,
            22,
            9,
            39
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        int __expected = 923016564;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleTrees().theCount(D, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
