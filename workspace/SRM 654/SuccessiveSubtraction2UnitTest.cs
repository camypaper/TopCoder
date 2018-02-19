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
        int[] __result = new SuccessiveSubtraction2().calc(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
	}
    public void Challenge(int[] a, int[] p, int[] v)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        Console.WriteLine(string.Format("v:{0}", string.Join(" ",v)));
        int[] __expected = new SuccessiveSubtraction2().calc(a, p, v);
        
        int[] __result = new SuccessiveSubtraction2().Naive_Test(a, p, v);

            CollectionAssert.AreEquivalent(__expected, __result);
         }
    public void ManualTest(int[] a, int[] p, int[] v)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        Console.WriteLine(string.Format("v:{0}", string.Join(" ",v)));
        int[] __result = new SuccessiveSubtraction2().calc(a, p, v);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            1,
            2,
            0,
            4,
            3
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] v = new int[] {
            3,
            9,
            -10,
            5,
            1
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] __expected = new int[] {
            10,
            16,
            5,
            5,
            2
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new SuccessiveSubtraction2().calc(a, p, v);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            -100,
            -100,
            -100,
            -100,
            -100
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            0,
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] v = new int[] {
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] __expected = new int[] {
            400,
            300,
            200,
            100,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new SuccessiveSubtraction2().calc(a, p, v);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            83,
            0,
            25,
            21
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            0,
            3,
            2,
            1,
            3,
            1,
            2
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] v = new int[] {
            10,
            -90,
            33,
            52,
            -100,
            0,
            45
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] __expected = new int[] {
            56,
            125,
            133,
            81,
            91,
            143,
            155
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new SuccessiveSubtraction2().calc(a, p, v);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] v = new int[] {
            10,
            -10,
            100,
            -100
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] __expected = new int[] {
            10,
            -10,
            100,
            -100
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new SuccessiveSubtraction2().calc(a, p, v);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            -11,
            -4,
            28,
            38,
            21,
            -29,
            -45,
            11,
            -58,
            -39,
            92,
            35,
            -56,
            -6,
            29,
            -2,
            61,
            10,
            -29,
            -63
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            19,
            5,
            3,
            10,
            4,
            18,
            5,
            2,
            0,
            15
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] v = new int[] {
            -19,
            21,
            7,
            -66,
            38,
            -39,
            -22,
            24,
            -32,
            13
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] __expected = new int[] {
            451,
            443,
            412,
            440,
            457,
            467,
            468,
            464,
            443,
            458
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new SuccessiveSubtraction2().calc(a, p, v);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
