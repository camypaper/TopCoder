using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] A = Scanner.In.int_array();
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] B = Scanner.In.int_array();
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int __result  = new AstronomicalRecordsEasy().minimalPlanets(A, B);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

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
        int[] B = new int[] {
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new AstronomicalRecordsEasy().minimalPlanets(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] B = new int[] {
            2,
            4,
            6,
            8
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new AstronomicalRecordsEasy().minimalPlanets(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            1,
            2,
            3,
            5,
            6,
            8,
            9
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] B = new int[] {
            2,
            4,
            5,
            6,
            7,
            8,
            9
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new AstronomicalRecordsEasy().minimalPlanets(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] B = new int[] {
            6,
            7,
            8,
            9
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new AstronomicalRecordsEasy().minimalPlanets(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            200,
            500
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] B = new int[] {
            100,
            200,
            300,
            400,
            600,
            700,
            800,
            900
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new AstronomicalRecordsEasy().minimalPlanets(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int[] A = new int[] {
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
            12
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int[] B = new int[] {
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15
        };
        Console.WriteLine(string.Format("B:{0}",string.Join(" ",B)));
        int __expected = 15;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new AstronomicalRecordsEasy().minimalPlanets(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
