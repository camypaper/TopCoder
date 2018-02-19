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
        long __result = new ColorfulParentheses().count(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] color)
    {
        Console.WriteLine(string.Format("color:{0}", string.Join(" ",color)));
        long __expected = new ColorfulParentheses().count(color);
        
        long __result = new ColorfulParentheses().Naive_Test(color);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] color)
    {
        Console.WriteLine(string.Format("color:{0}", string.Join(" ",color)));
        long __result = new ColorfulParentheses().count(color);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] color = new int[] {
            0,
            0,
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("color:{0}", string.Join(" ", color)));
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ColorfulParentheses().count(color);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] color = new int[] {
            0,
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("color:{0}", string.Join(" ", color)));
        long __expected = 5L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ColorfulParentheses().count(color);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] color = new int[] {
            0,
            1,
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("color:{0}", string.Join(" ", color)));
        long __expected = 1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ColorfulParentheses().count(color);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] color = new int[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            0
        };
        Console.WriteLine(string.Format("color:{0}", string.Join(" ", color)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ColorfulParentheses().count(color);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] color = new int[] {
            0,
            1,
            3,
            3,
            4,
            5,
            6,
            7,
            1,
            9,
            10,
            3
        };
        Console.WriteLine(string.Format("color:{0}", string.Join(" ", color)));
        long __expected = 7L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ColorfulParentheses().count(color);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] color = new int[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35
        };
        Console.WriteLine(string.Format("color:{0}", string.Join(" ", color)));
        long __expected = 477638700L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ColorfulParentheses().count(color);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
