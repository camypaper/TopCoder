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
    public void ManualTest(int[] p, int[] l, int[] r)
    {
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        Console.WriteLine(string.Format("l:{0}", string.Join(" ",l)));
        Console.WriteLine(string.Format("r:{0}", string.Join(" ",r)));
        string __result = new SegmentsAndPoints().isPossible(p, l, r);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] p = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] l = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("l:{0}", string.Join(" ", l)));
        int[] r = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new SegmentsAndPoints().isPossible(p, l, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] p = new int[] {
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] l = new int[] {
            2
        };
        Console.WriteLine(string.Format("l:{0}", string.Join(" ", l)));
        int[] r = new int[] {
            3
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new SegmentsAndPoints().isPossible(p, l, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] p = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] l = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("l:{0}", string.Join(" ", l)));
        int[] r = new int[] {
            1,
            2,
            1
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new SegmentsAndPoints().isPossible(p, l, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] p = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] l = new int[] {
            -1,
            0
        };
        Console.WriteLine(string.Format("l:{0}", string.Join(" ", l)));
        int[] r = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new SegmentsAndPoints().isPossible(p, l, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] p = new int[] {
            434,
            63,
            241,
            418,
            -380,
            -46,
            397,
            -205,
            -262,
            -282,
            260,
            -106,
            -389,
            -286,
            422,
            -75,
            127,
            382,
            52,
            -383
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int[] l = new int[] {
            -447,
            -226,
            -411,
            287,
            -83,
            -228,
            -390,
            358,
            422,
            395,
            -461,
            -112,
            49,
            75,
            -160,
            -152,
            372,
            -447,
            -337,
            -362
        };
        Console.WriteLine(string.Format("l:{0}", string.Join(" ", l)));
        int[] r = new int[] {
            -102,
            348,
            -70,
            466,
            168,
            -61,
            -389,
            469,
            433,
            471,
            -75,
            -41,
            52,
            236,
            299,
            -48,
            383,
            -353,
            346,
            -217
        };
        Console.WriteLine(string.Format("r:{0}", string.Join(" ", r)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new SegmentsAndPoints().isPossible(p, l, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
