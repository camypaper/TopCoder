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
    public void ManualTest(int m, int[] k, int[] a, int[] b)
    {
        Console.WriteLine("m:{0}", m);
        Console.WriteLine(string.Format("k:{0}", string.Join(" ",k)));
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        int __result = new FleetFunding().maxShips(m, k, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int[] k = new int[] {
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("k:{0}", string.Join(" ", k)));
        int[] a = new int[] {
            1,
            2,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            3,
            3,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleetFunding().maxShips(m, k, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int[] k = new int[] {
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
        Console.WriteLine(string.Format("k:{0}", string.Join(" ", k)));
        int[] a = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 55;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleetFunding().maxShips(m, k, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int m = 10;
        Console.WriteLine("m:{0}", m);
        int[] k = new int[] {
            2,
            4,
            6,
            8,
            10,
            1,
            3,
            5,
            7,
            9
        };
        Console.WriteLine(string.Format("k:{0}", string.Join(" ", k)));
        int[] a = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleetFunding().maxShips(m, k, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int m = 84457;
        Console.WriteLine("m:{0}", m);
        int[] k = new int[] {
            374778,
            169109,
            529984,
            498638,
            29462,
            465769,
            29285,
            394948,
            307944,
            459189,
            349316,
            766627,
            686851,
            404285,
            850199,
            359378,
            3014,
            248257,
            558856,
            27393,
            32370,
            574862,
            337134,
            965567,
            32223,
            935678,
            389898,
            973497,
            990575,
            483190,
            122899,
            857994,
            991217,
            149619,
            415870
        };
        Console.WriteLine(string.Format("k:{0}", string.Join(" ", k)));
        int[] a = new int[] {
            92,
            4997,
            11,
            28545,
            933,
            210,
            2,
            124,
            114,
            4513,
            32959,
            1,
            57,
            17,
            13,
            133,
            1843,
            41851,
            3,
            9296,
            9757,
            28,
            3,
            769,
            10,
            11102,
            683,
            6173,
            11821,
            3982,
            214,
            2,
            4304,
            439,
            1998
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            81034,
            54474,
            70239,
            79597,
            47317,
            82938,
            83883,
            74652,
            84033,
            84422,
            84456,
            84457,
            81095,
            83743,
            79210,
            84255,
            84455,
            45596,
            84456,
            82959,
            67062,
            80330,
            44090,
            84445,
            84454,
            84450,
            45931,
            77190,
            83025,
            83567,
            83639,
            84333,
            83355,
            70982,
            84456
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 186;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleetFunding().maxShips(m, k, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int[] k = new int[] {
            1000000,
            1000000,
            1000000,
            1000000,
            1000000
        };
        Console.WriteLine(string.Format("k:{0}", string.Join(" ", k)));
        int[] a = new int[] {
            1,
            1,
            1,
            2,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            1,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 2500000;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FleetFunding().maxShips(m, k, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
