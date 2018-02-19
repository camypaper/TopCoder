using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class TwoNumberGroupsEasyTest
{
    [TestMethod]
    public void Example0()
    {
        int[] A = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] numA = new int[] {
            2,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("numA:{0}",string.Join(" ",numA)));
        int[] B = new int[] {
            5,
            6,
            7,
            8
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int[] numB = new int[] {
            1,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("numB:{0}",string.Join(" ",numB)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TwoNumberGroupsEasy().solve(A, numA, B, numB);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            5,
            7
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] numA = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("numA:{0}",string.Join(" ",numA)));
        int[] B = new int[] {
            12,
            14
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int[] numB = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("numB:{0}",string.Join(" ",numB)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TwoNumberGroupsEasy().solve(A, numA, B, numB);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            100
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] numA = new int[] {
            2
        };
        Console.WriteLine(string.Format("numA:{0}",string.Join(" ",numA)));
        int[] B = new int[] {
            1
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int[] numB = new int[] {
            1
        };
        Console.WriteLine(string.Format("numB:{0}",string.Join(" ",numB)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TwoNumberGroupsEasy().solve(A, numA, B, numB);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            1
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] numA = new int[] {
            1
        };
        Console.WriteLine(string.Format("numA:{0}",string.Join(" ",numA)));
        int[] B = new int[] {
            1
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int[] numB = new int[] {
            1
        };
        Console.WriteLine(string.Format("numB:{0}",string.Join(" ",numB)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TwoNumberGroupsEasy().solve(A, numA, B, numB);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            5
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] numA = new int[] {
            1
        };
        Console.WriteLine(string.Format("numA:{0}",string.Join(" ",numA)));
        int[] B = new int[] {
            6
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int[] numB = new int[] {
            1
        };
        Console.WriteLine(string.Format("numB:{0}",string.Join(" ",numB)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TwoNumberGroupsEasy().solve(A, numA, B, numB);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int[] A = new int[] {
            733815053,
            566264976,
            984867861,
            989991438,
            407773802,
            701974785,
            599158121,
            713333928,
            530987873,
            702824160
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] numA = new int[] {
            8941,
            4607,
            1967,
            2401,
            495,
            7654,
            7078,
            4213,
            5485,
            1026
        };
        Console.WriteLine(string.Format("numA:{0}",string.Join(" ",numA)));
        int[] B = new int[] {
            878175560,
            125398919,
            556001255,
            570171347,
            643069772,
            787443662,
            166157535,
            480000834,
            754757229,
            101000799
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int[] numB = new int[] {
            242,
            6538,
            7921,
            2658,
            1595,
            3049,
            655,
            6945,
            7350,
            6915
        };
        Console.WriteLine(string.Format("numB:{0}",string.Join(" ",numB)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TwoNumberGroupsEasy().solve(A, numA, B, numB);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
