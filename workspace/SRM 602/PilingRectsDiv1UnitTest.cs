using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(int N, int[] XS, int[] YS, int XA, int XB, int XC, int YA, int YB, int YC)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("XS:{0}", string.Join(" ",XS)));
        Console.WriteLine(string.Format("YS:{0}", string.Join(" ",YS)));
        Console.WriteLine("XA:{0}", XA);
        Console.WriteLine("XB:{0}", XB);
        Console.WriteLine("XC:{0}", XC);
        Console.WriteLine("YA:{0}", YA);
        Console.WriteLine("YB:{0}", YB);
        Console.WriteLine("YC:{0}", YC);
        long __result = new PilingRectsDiv1().getmax(N, XS, YS, XA, XB, XC, YA, YB, YC);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] XS = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("XS:{0}", string.Join(" ", XS)));
        int[] YS = new int[] {
            10,
            5,
            3,
            5
        };
        Console.WriteLine(string.Format("YS:{0}", string.Join(" ", YS)));
        int XA = 0;
        Console.WriteLine("XA:{0}", XA);
        int XB = 0;
        Console.WriteLine("XB:{0}", XB);
        int XC = 1;
        Console.WriteLine("XC:{0}", XC);
        int YA = 0;
        Console.WriteLine("YA:{0}", YA);
        int YB = 0;
        Console.WriteLine("YB:{0}", YB);
        int YC = 1;
        Console.WriteLine("YC:{0}", YC);
        long __expected = 14L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new PilingRectsDiv1().getmax(N, XS, YS, XA, XB, XC, YA, YB, YC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] XS = new int[] {
            7,
            7
        };
        Console.WriteLine(string.Format("XS:{0}", string.Join(" ", XS)));
        int[] YS = new int[] {
            4,
            4
        };
        Console.WriteLine(string.Format("YS:{0}", string.Join(" ", YS)));
        int XA = 9;
        Console.WriteLine("XA:{0}", XA);
        int XB = 0;
        Console.WriteLine("XB:{0}", XB);
        int XC = 10;
        Console.WriteLine("XC:{0}", XC);
        int YA = 2;
        Console.WriteLine("YA:{0}", YA);
        int YB = 7;
        Console.WriteLine("YB:{0}", YB);
        int YC = 9;
        Console.WriteLine("YC:{0}", YC);
        long __expected = 56L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new PilingRectsDiv1().getmax(N, XS, YS, XA, XB, XC, YA, YB, YC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] XS = new int[] {
            5,
            6,
            9,
            10,
            4,
            7
        };
        Console.WriteLine(string.Format("XS:{0}", string.Join(" ", XS)));
        int[] YS = new int[] {
            9,
            5,
            8,
            6,
            8,
            7
        };
        Console.WriteLine(string.Format("YS:{0}", string.Join(" ", YS)));
        int XA = 0;
        Console.WriteLine("XA:{0}", XA);
        int XB = 0;
        Console.WriteLine("XB:{0}", XB);
        int XC = 1;
        Console.WriteLine("XC:{0}", XC);
        int YA = 0;
        Console.WriteLine("YA:{0}", YA);
        int YB = 0;
        Console.WriteLine("YB:{0}", YB);
        int YC = 1;
        Console.WriteLine("YC:{0}", YC);
        long __expected = 69L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new PilingRectsDiv1().getmax(N, XS, YS, XA, XB, XC, YA, YB, YC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 10000;
        Console.WriteLine("N:{0}", N);
        int[] XS = new int[] {
            1000000000
        };
        Console.WriteLine(string.Format("XS:{0}", string.Join(" ", XS)));
        int[] YS = new int[] {
            1000000000
        };
        Console.WriteLine(string.Format("YS:{0}", string.Join(" ", YS)));
        int XA = 93827162;
        Console.WriteLine("XA:{0}", XA);
        int XB = 91238127;
        Console.WriteLine("XB:{0}", XB);
        int XC = 98231267;
        Console.WriteLine("XC:{0}", XC);
        int YA = 92138287;
        Console.WriteLine("YA:{0}", YA);
        int YB = 98563732;
        Console.WriteLine("YB:{0}", YB);
        int YC = 99381279;
        Console.WriteLine("YC:{0}", YC);
        long __expected = 1240119561532788L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new PilingRectsDiv1().getmax(N, XS, YS, XA, XB, XC, YA, YB, YC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] XS = new int[] {
            375,
            571,
            973,
            896,
            460,
            930,
            583,
            530,
            657,
            590
        };
        Console.WriteLine(string.Format("XS:{0}", string.Join(" ", XS)));
        int[] YS = new int[] {
            284,
            37,
            994,
            699,
            941,
            745,
            166,
            884,
            270,
            708
        };
        Console.WriteLine(string.Format("YS:{0}", string.Join(" ", YS)));
        int XA = 428;
        Console.WriteLine("XA:{0}", XA);
        int XB = 1000;
        Console.WriteLine("XB:{0}", XB);
        int XC = 788;
        Console.WriteLine("XC:{0}", XC);
        int YA = 851;
        Console.WriteLine("YA:{0}", YA);
        int YB = 125;
        Console.WriteLine("YB:{0}", YB);
        int YC = 894;
        Console.WriteLine("YC:{0}", YC);
        long __expected = 420515L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new PilingRectsDiv1().getmax(N, XS, YS, XA, XB, XC, YA, YB, YC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 34734;
        Console.WriteLine("N:{0}", N);
        int[] XS = new int[] {
            898,
            579,
            465,
            665,
            875,
            391,
            583,
            901,
            326,
            133,
            656,
            562,
            701,
            707,
            492,
            617,
            455,
            441,
            382,
            952,
            689,
            656,
            334,
            877,
            120,
            318,
            497,
            25,
            569,
            962,
            845,
            562,
            632,
            898,
            882,
            498,
            595,
            889,
            382,
            507,
            791,
            548,
            810,
            606,
            105,
            869,
            569,
            970,
            322,
            974
        };
        Console.WriteLine(string.Format("XS:{0}", string.Join(" ", XS)));
        int[] YS = new int[] {
            83,
            18,
            492,
            27,
            339,
            622,
            851,
            915,
            464,
            347,
            287,
            210,
            282,
            166,
            976,
            167,
            968,
            769,
            14,
            383,
            454,
            983,
            319,
            165,
            185,
            315,
            795,
            851,
            124,
            287,
            846,
            745,
            19,
            639,
            894,
            828,
            540,
            420,
            147,
            452,
            501,
            670,
            466,
            554,
            166,
            1,
            446,
            808,
            508,
            172
        };
        Console.WriteLine(string.Format("YS:{0}", string.Join(" ", YS)));
        int XA = 569;
        Console.WriteLine("XA:{0}", XA);
        int XB = 185;
        Console.WriteLine("XB:{0}", XB);
        int XC = 285;
        Console.WriteLine("XC:{0}", XC);
        int YA = 741;
        Console.WriteLine("YA:{0}", YA);
        int YB = 304;
        Console.WriteLine("YB:{0}", YB);
        int YC = 296;
        Console.WriteLine("YC:{0}", YC);
        long __expected = 10050L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new PilingRectsDiv1().getmax(N, XS, YS, XA, XB, XC, YA, YB, YC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
