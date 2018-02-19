using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);    }
    public void ManualTest(int[] x1, int[] y1, int[] x2, int[] y2, int[] xt, int[] yt)
    {
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ",x1)));
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ",y1)));
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ",x2)));
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ",y2)));
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ",xt)));
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ",yt)));
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x1 = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        int[] y1 = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        int[] x2 = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        int[] y2 = new int[] {
            4,
            3
        };
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));
        int[] xt = new int[] {
            2,
            3,
            2
        };
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ", xt)));
        int[] yt = new int[] {
            0,
            1,
            3
        };
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ", yt)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x1 = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        int[] y1 = new int[] {
            2,
            4,
            6
        };
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        int[] x2 = new int[] {
            3,
            5,
            6
        };
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        int[] y2 = new int[] {
            1,
            1,
            0
        };
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));
        int[] xt = new int[] {
            3,
            1,
            -2
        };
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ", xt)));
        int[] yt = new int[] {
            4,
            2,
            10
        };
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ", yt)));
        string __expected = "impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x1 = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        int[] y1 = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        int[] x2 = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        int[] y2 = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));
        int[] xt = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ", xt)));
        int[] yt = new int[] {
            5,
            3,
            8
        };
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ", yt)));
        string __expected = "impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x1 = new int[] {
            6,
            -5,
            1
        };
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        int[] y1 = new int[] {
            3,
            -10,
            -7
        };
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        int[] x2 = new int[] {
            0,
            11,
            5
        };
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        int[] y2 = new int[] {
            -5,
            8,
            5
        };
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));
        int[] xt = new int[] {
            0,
            -5,
            4
        };
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ", xt)));
        int[] yt = new int[] {
            -8,
            -9,
            -4
        };
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ", yt)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x1 = new int[] {
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        int[] y1 = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        int[] x2 = new int[] {
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        int[] y2 = new int[] {
            6,
            5,
            4
        };
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));
        int[] xt = new int[] {
            -2,
            5,
            6
        };
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ", xt)));
        int[] yt = new int[] {
            1,
            -3,
            2
        };
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ", yt)));
        string __expected = "impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] x1 = new int[] {
            903,
            -970,
            404,
            563
        };
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        int[] y1 = new int[] {
            -348,
            -452,
            37,
            692
        };
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        int[] x2 = new int[] {
            3359,
            1486,
            2860,
            3019
        };
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        int[] y2 = new int[] {
            -416,
            -520,
            -31,
            624
        };
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));
        int[] xt = new int[] {
            346,
            -838,
            916
        };
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ", xt)));
        int[] yt = new int[] {
            -541,
            -717,
            -348
        };
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ", yt)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] x1 = new int[] {
            4600,
            8914,
            9330,
            -193,
            5422
        };
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        int[] y1 = new int[] {
            25,
            7650,
            -7366,
            -8494,
            -6574
        };
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        int[] x2 = new int[] {
            -117326,
            -121640,
            -122056,
            -112533,
            -118148
        };
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        int[] y2 = new int[] {
            322619,
            314994,
            330010,
            331138,
            329218
        };
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));
        int[] xt = new int[] {
            9523,
            -7546,
            -9858
        };
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ", xt)));
        int[] yt = new int[] {
            -3750,
            -5347,
            -3828
        };
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ", yt)));
        string __expected = "impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int[] x1 = new int[] {
            4514,
            -67225,
            -78413,
            -96468,
            -58938
        };
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        int[] y1 = new int[] {
            -22815,
            -86062,
            -54529,
            -87391,
            42044
        };
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        int[] x2 = new int[] {
            259998,
            331737,
            342925,
            360980,
            323450
        };
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        int[] y2 = new int[] {
            912263,
            975510,
            943977,
            976839,
            847404
        };
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));
        int[] xt = new int[] {
            23726,
            -98808,
            -26788
        };
        Console.WriteLine(string.Format("xt:{0}", string.Join(" ", xt)));
        int[] yt = new int[] {
            80876,
            -68160,
            -13684
        };
        Console.WriteLine(string.Format("yt:{0}", string.Join(" ", yt)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ArmyTeleportation().ifPossible(x1, y1, x2, y2, xt, yt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
