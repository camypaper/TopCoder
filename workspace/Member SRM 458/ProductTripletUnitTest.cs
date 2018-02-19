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
    public void ManualTest(int minx, int maxx, int miny, int maxy, int minz, int maxz)
    {
        Console.WriteLine("minx:{0}", minx);
        Console.WriteLine("maxx:{0}", maxx);
        Console.WriteLine("miny:{0}", miny);
        Console.WriteLine("maxy:{0}", maxy);
        Console.WriteLine("minz:{0}", minz);
        Console.WriteLine("maxz:{0}", maxz);
        long __result = new ProductTriplet().countTriplets(minx, maxx, miny, maxy, minz, maxz);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int minx = 2;
        Console.WriteLine("minx:{0}", minx);
        int maxx = 2;
        Console.WriteLine("maxx:{0}", maxx);
        int miny = 3;
        Console.WriteLine("miny:{0}", miny);
        int maxy = 3;
        Console.WriteLine("maxy:{0}", maxy);
        int minz = 6;
        Console.WriteLine("minz:{0}", minz);
        int maxz = 6;
        Console.WriteLine("maxz:{0}", maxz);
        long __expected = 1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProductTriplet().countTriplets(minx, maxx, miny, maxy, minz, maxz);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int minx = 2;
        Console.WriteLine("minx:{0}", minx);
        int maxx = 2;
        Console.WriteLine("maxx:{0}", maxx);
        int miny = 3;
        Console.WriteLine("miny:{0}", miny);
        int maxy = 3;
        Console.WriteLine("maxy:{0}", maxy);
        int minz = 7;
        Console.WriteLine("minz:{0}", minz);
        int maxz = 7;
        Console.WriteLine("maxz:{0}", maxz);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProductTriplet().countTriplets(minx, maxx, miny, maxy, minz, maxz);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int minx = 6;
        Console.WriteLine("minx:{0}", minx);
        int maxx = 8;
        Console.WriteLine("maxx:{0}", maxx);
        int miny = 4;
        Console.WriteLine("miny:{0}", miny);
        int maxy = 5;
        Console.WriteLine("maxy:{0}", maxy);
        int minz = 27;
        Console.WriteLine("minz:{0}", minz);
        int maxz = 35;
        Console.WriteLine("maxz:{0}", maxz);
        long __expected = 4L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProductTriplet().countTriplets(minx, maxx, miny, maxy, minz, maxz);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int minx = 1;
        Console.WriteLine("minx:{0}", minx);
        int maxx = 458;
        Console.WriteLine("maxx:{0}", maxx);
        int miny = 1;
        Console.WriteLine("miny:{0}", miny);
        int maxy = 458;
        Console.WriteLine("maxy:{0}", maxy);
        int minz = 1;
        Console.WriteLine("minz:{0}", minz);
        int maxz = 458;
        Console.WriteLine("maxz:{0}", maxz);
        long __expected = 2877L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProductTriplet().countTriplets(minx, maxx, miny, maxy, minz, maxz);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int minx = 8176;
        Console.WriteLine("minx:{0}", minx);
        int maxx = 184561;
        Console.WriteLine("maxx:{0}", maxx);
        int miny = 1348;
        Console.WriteLine("miny:{0}", miny);
        int maxy = 43168;
        Console.WriteLine("maxy:{0}", maxy);
        int minz = 45814517;
        Console.WriteLine("minz:{0}", minz);
        int maxz = 957843164;
        Console.WriteLine("maxz:{0}", maxz);
        long __expected = 2365846085L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProductTriplet().countTriplets(minx, maxx, miny, maxy, minz, maxz);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
