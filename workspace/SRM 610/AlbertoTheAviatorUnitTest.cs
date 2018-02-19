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
    public void ManualTest(int F, int[] duration, int[] refuel)
    {
        Console.WriteLine("F:{0}", F);
        Console.WriteLine(string.Format("duration:{0}", string.Join(" ",duration)));
        Console.WriteLine(string.Format("refuel:{0}", string.Join(" ",refuel)));
        int __result = new AlbertoTheAviator().MaximumFlights(F, duration, refuel);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int F = 10;
        Console.WriteLine("F:{0}", F);
        int[] duration = new int[] {
            10
        };
        Console.WriteLine(string.Format("duration:{0}", string.Join(" ", duration)));
        int[] refuel = new int[] {
            0
        };
        Console.WriteLine(string.Format("refuel:{0}", string.Join(" ", refuel)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlbertoTheAviator().MaximumFlights(F, duration, refuel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int F = 10;
        Console.WriteLine("F:{0}", F);
        int[] duration = new int[] {
            8,
            4
        };
        Console.WriteLine(string.Format("duration:{0}", string.Join(" ", duration)));
        int[] refuel = new int[] {
            0,
            2
        };
        Console.WriteLine(string.Format("refuel:{0}", string.Join(" ", refuel)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlbertoTheAviator().MaximumFlights(F, duration, refuel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int F = 12;
        Console.WriteLine("F:{0}", F);
        int[] duration = new int[] {
            4,
            8,
            2,
            1
        };
        Console.WriteLine(string.Format("duration:{0}", string.Join(" ", duration)));
        int[] refuel = new int[] {
            2,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("refuel:{0}", string.Join(" ", refuel)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlbertoTheAviator().MaximumFlights(F, duration, refuel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int F = 9;
        Console.WriteLine("F:{0}", F);
        int[] duration = new int[] {
            4,
            6
        };
        Console.WriteLine(string.Format("duration:{0}", string.Join(" ", duration)));
        int[] refuel = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("refuel:{0}", string.Join(" ", refuel)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlbertoTheAviator().MaximumFlights(F, duration, refuel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int F = 100;
        Console.WriteLine("F:{0}", F);
        int[] duration = new int[] {
            101
        };
        Console.WriteLine(string.Format("duration:{0}", string.Join(" ", duration)));
        int[] refuel = new int[] {
            100
        };
        Console.WriteLine(string.Format("refuel:{0}", string.Join(" ", refuel)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlbertoTheAviator().MaximumFlights(F, duration, refuel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int F = 1947;
        Console.WriteLine("F:{0}", F);
        int[] duration = new int[] {
            2407,
            2979,
            1269,
            2401,
            3227,
            2230,
            3991,
            2133,
            3338,
            356,
            2535,
            3859,
            3267,
            365
        };
        Console.WriteLine(string.Format("duration:{0}", string.Join(" ", duration)));
        int[] refuel = new int[] {
            2406,
            793,
            905,
            2400,
            1789,
            2229,
            1378,
            2132,
            1815,
            355,
            72,
            3858,
            3266,
            364
        };
        Console.WriteLine(string.Format("refuel:{0}", string.Join(" ", refuel)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlbertoTheAviator().MaximumFlights(F, duration, refuel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
