using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);    }
    public void ManualTest(int[] S, int P)
    {
        Console.WriteLine(string.Format("S:{0}", string.Join(" ",S)));
        Console.WriteLine("P:{0}", P);
        int __result = new EllysSocks().getDifference(S, P);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] S = new int[] {
            42,
            37,
            84,
            36,
            41,
            42
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int P = 2;
        Console.WriteLine("P:{0}", P);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysSocks().getDifference(S, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] S = new int[] {
            42,
            37,
            84,
            36,
            41,
            42
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int P = 3;
        Console.WriteLine("P:{0}", P);
        int __expected = 42;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysSocks().getDifference(S, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] S = new int[] {
            5,
            2,
            8,
            8,
            6,
            7,
            3,
            7,
            4,
            2,
            4,
            5,
            3,
            6
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int P = 7;
        Console.WriteLine("P:{0}", P);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysSocks().getDifference(S, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] S = new int[] {
            17,
            3,
            13,
            3,
            2,
            17,
            11,
            5,
            5,
            7,
            11,
            7,
            13,
            19
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int P = 7;
        Console.WriteLine("P:{0}", P);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysSocks().getDifference(S, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] S = new int[] {
            795755685,
            581869303,
            404620563,
            708632712,
            545404205,
            133711906,
            372047868,
            949333986,
            579004999,
            323567404,
            418932836,
            944672732,
            196140741,
            809094427,
            946129058,
            30574577,
            182506778,
            15198493,
            150802600,
            138749191,
            676943010,
            177512688,
            126303054,
            81133258,
            183966551,
            471852627,
            84672537,
            867128744,
            857788837,
            275731772,
            609397213,
            20544910,
            811450930,
            483031419,
            361913171,
            547204602,
            892462744,
            522136404,
            173978710,
            131752569,
            478582453,
            867889991,
            153380496,
            551745921,
            647984700,
            910208077,
            283496852,
            368550363,
            379821990,
            712568903,
            40498239,
            113911604,
            103237637,
            39073007,
            684602223,
            812852787,
            479711181,
            746745228,
            735241235,
            296707007,
            262522458,
            870676136,
            136721027,
            359573809,
            189375153,
            547914047,
            198304613,
            640439653,
            417177802,
            25475624,
            758242872,
            764919655,
            310701088,
            537655880,
            361931892,
            14685971,
            213794688,
            107063881,
            147944789,
            444803289,
            884392679,
            540721924,
            638781100,
            902841101,
            7097711,
            219972874,
            879609715,
            156513984,
            802611721,
            755486970,
            103522060,
            967048445,
            913778155,
            94092596,
            519074050,
            884870761,
            248268555,
            339840186,
            53612697,
            826647953
        };
        Console.WriteLine(string.Format("S:{0}", string.Join(" ", S)));
        int P = 42;
        Console.WriteLine("P:{0}", P);
        int __expected = 12866316;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysSocks().getDifference(S, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
