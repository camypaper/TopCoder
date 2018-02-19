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
        int __result = new BrightLamps().maxBrightness(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string init, int[] a, int K)
    {
        Console.WriteLine("init:{0}", init);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine("K:{0}", K);
        int __expected = new BrightLamps().maxBrightness(init, a, K);
        
        int __result = new BrightLamps().Naive_Test(init, a, K);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string init, int[] a, int K)
    {
        Console.WriteLine("init:{0}", init);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine("K:{0}", K);
        int __result = new BrightLamps().maxBrightness(init, a, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string init = "011";
        Console.WriteLine("init:{0}", init);
        int[] a = new int[] {
            3,
            2,
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BrightLamps().maxBrightness(init, a, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string init = "0010100101";
        Console.WriteLine("init:{0}", init);
        int[] a = new int[] {
            1,
            1,
            1,
            3,
            4,
            3,
            4,
            5,
            1,
            5
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 28;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BrightLamps().maxBrightness(init, a, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string init = "1111111111";
        Console.WriteLine("init:{0}", init);
        int[] a = new int[] {
            5,
            5,
            3,
            3,
            4,
            3,
            5,
            1,
            1,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int K = 7;
        Console.WriteLine("K:{0}", K);
        int __expected = 33;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BrightLamps().maxBrightness(init, a, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string init = "0010000001";
        Console.WriteLine("init:{0}", init);
        int[] a = new int[] {
            8,
            3,
            10,
            8,
            3,
            7,
            4,
            6,
            3,
            10
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int __expected = 55;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BrightLamps().maxBrightness(init, a, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string init = "00001001010101100001100000010000011001000000001011";
        Console.WriteLine("init:{0}", init);
        int[] a = new int[] {
            99,
            29,
            22,
            50,
            17,
            49,
            50,
            54,
            43,
            29,
            30,
            33,
            38,
            53,
            71,
            48,
            82,
            25,
            62,
            93,
            90,
            64,
            43,
            95,
            68,
            35,
            79,
            11,
            13,
            47,
            51,
            44,
            35,
            55,
            4,
            34,
            7,
            10,
            25,
            38,
            29,
            58,
            36,
            34,
            77,
            90,
            37,
            58,
            20,
            20
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int K = 17;
        Console.WriteLine("K:{0}", K);
        int __expected = 2068;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BrightLamps().maxBrightness(init, a, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
