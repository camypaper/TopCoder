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
        int __result = new MappingABC().countStrings(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] t)
    {
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int __expected = new MappingABC().countStrings(t);
        
        int __result = new MappingABC().Naive_Test(t);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] t)
    {
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int __result = new MappingABC().countStrings(t);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] t = new int[] {
            9,
            9,
            2,
            9,
            4
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MappingABC().countStrings(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] t = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MappingABC().countStrings(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] t = new int[] {
            1,
            2,
            2,
            1,
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MappingABC().countStrings(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] t = new int[] {
            7,
            3000,
            1,
            3000,
            1,
            3000,
            1,
            10,
            7
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MappingABC().countStrings(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] t = new int[] {
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
            35,
            36,
            37,
            38,
            39,
            40,
            41,
            42,
            43,
            44,
            45,
            46,
            47,
            48
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 166952139;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MappingABC().countStrings(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
