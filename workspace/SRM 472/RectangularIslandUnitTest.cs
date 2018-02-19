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
    public void ManualTest(int width, int height, int x, int y, int steps)
    {
        Console.WriteLine("width:{0}", width);
        Console.WriteLine("height:{0}", height);
        Console.WriteLine("x:{0}", x);
        Console.WriteLine("y:{0}", y);
        Console.WriteLine("steps:{0}", steps);
        double __result = new RectangularIsland().theProbablity(width, height, x, y, steps);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int width = 5;
        Console.WriteLine("width:{0}", width);
        int height = 8;
        Console.WriteLine("height:{0}", height);
        int x = 4;
        Console.WriteLine("x:{0}", x);
        int y = 3;
        Console.WriteLine("y:{0}", y);
        int steps = 1;
        Console.WriteLine("steps:{0}", steps);
        double __expected = 0.75;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RectangularIsland().theProbablity(width, height, x, y, steps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int width = 5;
        Console.WriteLine("width:{0}", width);
        int height = 8;
        Console.WriteLine("height:{0}", height);
        int x = 4;
        Console.WriteLine("x:{0}", x);
        int y = 7;
        Console.WriteLine("y:{0}", y);
        int steps = 1;
        Console.WriteLine("steps:{0}", steps);
        double __expected = 0.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RectangularIsland().theProbablity(width, height, x, y, steps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int width = 2;
        Console.WriteLine("width:{0}", width);
        int height = 2;
        Console.WriteLine("height:{0}", height);
        int x = 0;
        Console.WriteLine("x:{0}", x);
        int y = 1;
        Console.WriteLine("y:{0}", y);
        int steps = 5;
        Console.WriteLine("steps:{0}", steps);
        double __expected = 0.03125;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RectangularIsland().theProbablity(width, height, x, y, steps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int width = 58;
        Console.WriteLine("width:{0}", width);
        int height = 85;
        Console.WriteLine("height:{0}", height);
        int x = 47;
        Console.WriteLine("x:{0}", x);
        int y = 74;
        Console.WriteLine("y:{0}", y);
        int steps = 1000;
        Console.WriteLine("steps:{0}", steps);
        double __expected = 0.13056659769966347;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RectangularIsland().theProbablity(width, height, x, y, steps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int width = 1000;
        Console.WriteLine("width:{0}", width);
        int height = 1000;
        Console.WriteLine("height:{0}", height);
        int x = 123;
        Console.WriteLine("x:{0}", x);
        int y = 456;
        Console.WriteLine("y:{0}", y);
        int steps = 5000;
        Console.WriteLine("steps:{0}", steps);
        double __expected = 0.9868611148475199;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RectangularIsland().theProbablity(width, height, x, y, steps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
