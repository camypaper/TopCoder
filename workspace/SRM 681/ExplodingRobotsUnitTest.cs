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
    public void ManualTest(int x1, int y1, int x2, int y2, string instructions)
    {
        Console.WriteLine("x1:{0}", x1);
        Console.WriteLine("y1:{0}", y1);
        Console.WriteLine("x2:{0}", x2);
        Console.WriteLine("y2:{0}", y2);
        Console.WriteLine("instructions:{0}", instructions);
        string __result = new ExplodingRobots().canExplode(x1, y1, x2, y2, instructions);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int x1 = 1;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 0;
        Console.WriteLine("y1:{0}", y1);
        int x2 = 2;
        Console.WriteLine("x2:{0}", x2);
        int y2 = 0;
        Console.WriteLine("y2:{0}", y2);
        string instructions = "L";
        Console.WriteLine("instructions:{0}", instructions);
        string __expected = "Explosion";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ExplodingRobots().canExplode(x1, y1, x2, y2, instructions);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int x1 = 1;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 0;
        Console.WriteLine("y1:{0}", y1);
        int x2 = 2;
        Console.WriteLine("x2:{0}", x2);
        int y2 = 0;
        Console.WriteLine("y2:{0}", y2);
        string instructions = "U";
        Console.WriteLine("instructions:{0}", instructions);
        string __expected = "Safe";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ExplodingRobots().canExplode(x1, y1, x2, y2, instructions);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int x1 = 1;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 0;
        Console.WriteLine("y1:{0}", y1);
        int x2 = 2;
        Console.WriteLine("x2:{0}", x2);
        int y2 = 0;
        Console.WriteLine("y2:{0}", y2);
        string instructions = "UL";
        Console.WriteLine("instructions:{0}", instructions);
        string __expected = "Explosion";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ExplodingRobots().canExplode(x1, y1, x2, y2, instructions);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int x1 = 3;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 3;
        Console.WriteLine("y1:{0}", y1);
        int x2 = 5;
        Console.WriteLine("x2:{0}", x2);
        int y2 = 5;
        Console.WriteLine("y2:{0}", y2);
        string instructions = "LURLL";
        Console.WriteLine("instructions:{0}", instructions);
        string __expected = "Safe";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ExplodingRobots().canExplode(x1, y1, x2, y2, instructions);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int x1 = 10;
        Console.WriteLine("x1:{0}", x1);
        int y1 = 5;
        Console.WriteLine("y1:{0}", y1);
        int x2 = -9;
        Console.WriteLine("x2:{0}", x2);
        int y2 = -10;
        Console.WriteLine("y2:{0}", y2);
        string instructions = "LULULULLLUULRULULULULULULLULULLULD";
        Console.WriteLine("instructions:{0}", instructions);
        string __expected = "Explosion";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new ExplodingRobots().canExplode(x1, y1, x2, y2, instructions);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
