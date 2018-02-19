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
        int __result = new CandyCollection().solve(parser.Items[0], parser.Items[1], parser.Items[2], parser.Items[3]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] Type1, int[] Number1, int[] Type2, int[] Number2)
    {
        Console.WriteLine(string.Format("Type1:{0}", string.Join(" ",Type1)));
        Console.WriteLine(string.Format("Number1:{0}", string.Join(" ",Number1)));
        Console.WriteLine(string.Format("Type2:{0}", string.Join(" ",Type2)));
        Console.WriteLine(string.Format("Number2:{0}", string.Join(" ",Number2)));
        int __expected = new CandyCollection().solve(Type1, Number1, Type2, Number2);
        
        int __result = new CandyCollection().Naive_Test(Type1, Number1, Type2, Number2);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] Type1, int[] Number1, int[] Type2, int[] Number2)
    {
        Console.WriteLine(string.Format("Type1:{0}", string.Join(" ",Type1)));
        Console.WriteLine(string.Format("Number1:{0}", string.Join(" ",Number1)));
        Console.WriteLine(string.Format("Type2:{0}", string.Join(" ",Type2)));
        Console.WriteLine(string.Format("Number2:{0}", string.Join(" ",Number2)));
        int __result = new CandyCollection().solve(Type1, Number1, Type2, Number2);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] Type1 = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("Type1:{0}", string.Join(" ", Type1)));
        int[] Number1 = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("Number1:{0}", string.Join(" ", Number1)));
        int[] Type2 = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("Type2:{0}", string.Join(" ", Type2)));
        int[] Number2 = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("Number2:{0}", string.Join(" ", Number2)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCollection().solve(Type1, Number1, Type2, Number2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] Type1 = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("Type1:{0}", string.Join(" ", Type1)));
        int[] Number1 = new int[] {
            2,
            5
        };
        Console.WriteLine(string.Format("Number1:{0}", string.Join(" ", Number1)));
        int[] Type2 = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("Type2:{0}", string.Join(" ", Type2)));
        int[] Number2 = new int[] {
            2,
            5
        };
        Console.WriteLine(string.Format("Number2:{0}", string.Join(" ", Number2)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCollection().solve(Type1, Number1, Type2, Number2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] Type1 = new int[] {
            0,
            0,
            2,
            3
        };
        Console.WriteLine(string.Format("Type1:{0}", string.Join(" ", Type1)));
        int[] Number1 = new int[] {
            1,
            1,
            2,
            2
        };
        Console.WriteLine(string.Format("Number1:{0}", string.Join(" ", Number1)));
        int[] Type2 = new int[] {
            1,
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("Type2:{0}", string.Join(" ", Type2)));
        int[] Number2 = new int[] {
            1,
            1,
            2,
            2
        };
        Console.WriteLine(string.Format("Number2:{0}", string.Join(" ", Number2)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCollection().solve(Type1, Number1, Type2, Number2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] Type1 = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("Type1:{0}", string.Join(" ", Type1)));
        int[] Number1 = new int[] {
            5,
            5,
            10,
            13
        };
        Console.WriteLine(string.Format("Number1:{0}", string.Join(" ", Number1)));
        int[] Type2 = new int[] {
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("Type2:{0}", string.Join(" ", Type2)));
        int[] Number2 = new int[] {
            8,
            8,
            10,
            15
        };
        Console.WriteLine(string.Format("Number2:{0}", string.Join(" ", Number2)));
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCollection().solve(Type1, Number1, Type2, Number2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] Type1 = new int[] {
            12,
            9,
            0,
            16,
            9,
            18,
            12,
            3,
            6,
            0,
            8,
            2,
            10,
            6,
            5,
            2,
            14,
            10,
            5,
            13
        };
        Console.WriteLine(string.Format("Type1:{0}", string.Join(" ", Type1)));
        int[] Number1 = new int[] {
            895,
            704,
            812,
            323,
            334,
            674,
            665,
            142,
            712,
            254,
            869,
            548,
            645,
            663,
            758,
            38,
            860,
            724,
            742,
            530
        };
        Console.WriteLine(string.Format("Number1:{0}", string.Join(" ", Number1)));
        int[] Type2 = new int[] {
            1,
            4,
            7,
            11,
            15,
            8,
            18,
            13,
            17,
            17,
            19,
            14,
            7,
            11,
            4,
            1,
            15,
            19,
            3,
            16
        };
        Console.WriteLine(string.Format("Type2:{0}", string.Join(" ", Type2)));
        int[] Number2 = new int[] {
            779,
            317,
            36,
            191,
            843,
            289,
            107,
            41,
            943,
            265,
            649,
            447,
            806,
            891,
            730,
            371,
            351,
            7,
            102,
            394
        };
        Console.WriteLine(string.Format("Number2:{0}", string.Join(" ", Number2)));
        int __expected = 5101;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandyCollection().solve(Type1, Number1, Type2, Number2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
