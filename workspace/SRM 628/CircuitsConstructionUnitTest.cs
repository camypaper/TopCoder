using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new CircuitsConstruction().maximizeResistance(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string circuit, int[] conductors)
    {
        Console.WriteLine("circuit:{0}", circuit);
        Console.WriteLine(string.Format("conductors:{0}", string.Join(" ",conductors)));
        int __expected = new CircuitsConstruction().maximizeResistance(circuit, conductors);
        
        int __result = new CircuitsConstruction().Naive_Test(circuit, conductors);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string circuit, int[] conductors)
    {
        Console.WriteLine("circuit:{0}", circuit);
        Console.WriteLine(string.Format("conductors:{0}", string.Join(" ",conductors)));
        int __result = new CircuitsConstruction().maximizeResistance(circuit, conductors);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string circuit = "BXBXX";
        Console.WriteLine("circuit:{0}", circuit);
        int[] conductors = new int[] {
            8,
            2,
            3
        };
        Console.WriteLine(string.Format("conductors:{0}", string.Join(" ", conductors)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CircuitsConstruction().maximizeResistance(circuit, conductors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string circuit = "AAXXAXAXX";
        Console.WriteLine("circuit:{0}", circuit);
        int[] conductors = new int[] {
            1,
            1,
            2,
            8,
            10
        };
        Console.WriteLine(string.Format("conductors:{0}", string.Join(" ", conductors)));
        int __expected = 22;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CircuitsConstruction().maximizeResistance(circuit, conductors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string circuit = "AXBXX";
        Console.WriteLine("circuit:{0}", circuit);
        int[] conductors = new int[] {
            8,
            2,
            3
        };
        Console.WriteLine(string.Format("conductors:{0}", string.Join(" ", conductors)));
        int __expected = 11;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CircuitsConstruction().maximizeResistance(circuit, conductors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string circuit = "BAAXBXXBXAXXBBAXXBXXAAXXX";
        Console.WriteLine("circuit:{0}", circuit);
        int[] conductors = new int[] {
            17,
            7,
            21,
            102,
            56,
            72,
            88,
            15,
            9,
            192,
            16,
            8,
            30
        };
        Console.WriteLine(string.Format("conductors:{0}", string.Join(" ", conductors)));
        int __expected = 454;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CircuitsConstruction().maximizeResistance(circuit, conductors);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
