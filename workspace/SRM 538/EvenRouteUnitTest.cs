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
    public void ManualTest(int[] x, int[] y, int wantedParity)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        Console.WriteLine("wantedParity:{0}", wantedParity);
        string __result = new EvenRoute().isItPossible(x, y, wantedParity);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            -1,
            -1,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -1,
            1,
            1,
            -1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int wantedParity = 0;
        Console.WriteLine("wantedParity:{0}", wantedParity);
        string __expected = "CAN";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EvenRoute().isItPossible(x, y, wantedParity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            -5,
            -3,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            2,
            0,
            3
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int wantedParity = 1;
        Console.WriteLine("wantedParity:{0}", wantedParity);
        string __expected = "CAN";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EvenRoute().isItPossible(x, y, wantedParity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            1001,
            -4000
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int wantedParity = 1;
        Console.WriteLine("wantedParity:{0}", wantedParity);
        string __expected = "CAN";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EvenRoute().isItPossible(x, y, wantedParity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            11,
            21,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -20,
            42,
            7
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int wantedParity = 0;
        Console.WriteLine("wantedParity:{0}", wantedParity);
        string __expected = "CANNOT";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EvenRoute().isItPossible(x, y, wantedParity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            0,
            6
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            10,
            -20
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int wantedParity = 1;
        Console.WriteLine("wantedParity:{0}", wantedParity);
        string __expected = "CANNOT";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EvenRoute().isItPossible(x, y, wantedParity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
