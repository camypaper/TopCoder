using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] x = Scanner.In.int_array();
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = Scanner.In.int_array();
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int[] __result  = new NoRightTurnDiv2().findPath(x, y);; ;
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            -10,
            0,
            10
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            10,
            -10,
            10
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int[] __expected = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new NoRightTurnDiv2().findPath(x, y);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            0,
            0,
            -3,
            -3,
            3,
            3
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            -1,
            1,
            -3,
            3,
            -3,
            3
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int[] __expected = new int[] {
            0,
            4,
            5,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new NoRightTurnDiv2().findPath(x, y);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            10,
            9,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            1,
            4,
            9,
            16,
            25,
            36,
            49,
            64,
            81,
            100
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int[] __expected = new int[] {
            9,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            1,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new NoRightTurnDiv2().findPath(x, y);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            0,
            2,
            -2,
            4,
            -4,
            2,
            -2,
            0
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            1,
            2,
            2,
            4,
            4,
            6,
            6,
            5
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int[] __expected = new int[] {
            4,
            2,
            0,
            1,
            3,
            5,
            6,
            7
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new NoRightTurnDiv2().findPath(x, y);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            -76,
            98,
            83,
            58,
            -15,
            94,
            21,
            55,
            80,
            84,
            -39,
            -90,
            -46,
            100,
            -80,
            -49,
            -2,
            -70,
            36,
            48,
            88,
            10,
            55,
            -56,
            22,
            67,
            31,
            81,
            100,
            -39,
            64,
            -62,
            -7,
            45,
            -82,
            -24,
            51,
            -33,
            53,
            11,
            20,
            -74,
            -83,
            47,
            9,
            39,
            42,
            63,
            -97,
            94
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            -90,
            68,
            91,
            -92,
            -6,
            88,
            99,
            10,
            39,
            -69,
            -61,
            -4,
            71,
            -5,
            90,
            -51,
            21,
            -53,
            -21,
            -86,
            41,
            -9,
            42,
            -23,
            -4,
            12,
            94,
            -59,
            55,
            18,
            70,
            -88,
            -86,
            -17,
            -97,
            -33,
            87,
            80,
            91,
            -80,
            -79,
            -79,
            -78,
            -99,
            57,
            67,
            -52,
            -46,
            61,
            -10
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int[] __expected = new int[] {
            39,
            32,
            40,
            31,
            19,
            27,
            47,
            46,
            0,
            34,
            43,
            3,
            9,
            13,
            28,
            1,
            5,
            2,
            6,
            14,
            48,
            42,
            41,
            49,
            20,
            38,
            26,
            37,
            12,
            11,
            17,
            10,
            33,
            25,
            8,
            30,
            36,
            44,
            29,
            23,
            15,
            18,
            7,
            22,
            45,
            16,
            4,
            35,
            24,
            21
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new NoRightTurnDiv2().findPath(x, y);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

}
