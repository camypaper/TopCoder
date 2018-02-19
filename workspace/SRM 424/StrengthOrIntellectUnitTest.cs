using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] strength = Scanner.In.int_array();
        Console.WriteLine(string.Format("strength:{0}",string.Join(" ",strength)));
        int[] intellect = Scanner.In.int_array();
        Console.WriteLine(string.Format("intellect:{0}",string.Join(" ",intellect)));
        int[] points = Scanner.In.int_array();
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __result  = new StrengthOrIntellect().numberOfMissions(strength, intellect, points);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] strength = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("strength:{0}",string.Join(" ",strength)));
        int[] intellect = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("intellect:{0}",string.Join(" ",intellect)));
        int[] points = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new StrengthOrIntellect().numberOfMissions(strength, intellect, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] strength = new int[] {
            3
        };
        Console.WriteLine(string.Format("strength:{0}",string.Join(" ",strength)));
        int[] intellect = new int[] {
            2
        };
        Console.WriteLine(string.Format("intellect:{0}",string.Join(" ",intellect)));
        int[] points = new int[] {
            1
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new StrengthOrIntellect().numberOfMissions(strength, intellect, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] strength = new int[] {
            1,
            3,
            1,
            10,
            3
        };
        Console.WriteLine(string.Format("strength:{0}",string.Join(" ",strength)));
        int[] intellect = new int[] {
            1,
            1,
            3,
            20,
            3
        };
        Console.WriteLine(string.Format("intellect:{0}",string.Join(" ",intellect)));
        int[] points = new int[] {
            2,
            1,
            1,
            5,
            1
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new StrengthOrIntellect().numberOfMissions(strength, intellect, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] strength = new int[] {
            1,
            2,
            100,
            5,
            100,
            10,
            100,
            17,
            100
        };
        Console.WriteLine(string.Format("strength:{0}",string.Join(" ",strength)));
        int[] intellect = new int[] {
            1,
            100,
            3,
            100,
            7,
            100,
            13,
            100,
            21
        };
        Console.WriteLine(string.Format("intellect:{0}",string.Join(" ",intellect)));
        int[] points = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            1
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new StrengthOrIntellect().numberOfMissions(strength, intellect, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] strength = new int[] {
            1,
            10,
            1,
            2,
            16,
            12,
            13,
            19,
            12,
            8
        };
        Console.WriteLine(string.Format("strength:{0}",string.Join(" ",strength)));
        int[] intellect = new int[] {
            1,
            5,
            1,
            8,
            3,
            5,
            3,
            16,
            19,
            20
        };
        Console.WriteLine(string.Format("intellect:{0}",string.Join(" ",intellect)));
        int[] points = new int[] {
            1,
            1,
            1,
            2,
            1,
            1,
            2,
            3,
            5,
            1
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new StrengthOrIntellect().numberOfMissions(strength, intellect, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
