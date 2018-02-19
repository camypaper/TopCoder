using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class ConnectingCarsTest
{
    [TestMethod]
    public void Example0()
    {
        int[] positions = new int[] {
            1,
            3,
            10,
            20
        };
        Console.WriteLine(string.Format("positions:{0}",string.Join(" ",positions)));
        int[] lengths = new int[] {
            2,
            2,
            5,
            3
        };
        Console.WriteLine(string.Format("lengths:{0}",string.Join(" ",lengths)));
        long __expected = 15L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ConnectingCars().minimizeCost(positions, lengths);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] positions = new int[] {
            100,
            50,
            1
        };
        Console.WriteLine(string.Format("positions:{0}",string.Join(" ",positions)));
        int[] lengths = new int[] {
            10,
            2,
            1
        };
        Console.WriteLine(string.Format("lengths:{0}",string.Join(" ",lengths)));
        long __expected = 96L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ConnectingCars().minimizeCost(positions, lengths);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] positions = new int[] {
            4,
            10,
            100,
            13,
            80
        };
        Console.WriteLine(string.Format("positions:{0}",string.Join(" ",positions)));
        int[] lengths = new int[] {
            5,
            3,
            42,
            40,
            9
        };
        Console.WriteLine(string.Format("lengths:{0}",string.Join(" ",lengths)));
        long __expected = 66L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ConnectingCars().minimizeCost(positions, lengths);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] positions = new int[] {
            5606451,
            63581020,
            81615191,
            190991272,
            352848147,
            413795385,
            468408016,
            615921162,
            760622952,
            791438427
        };
        Console.WriteLine(string.Format("positions:{0}",string.Join(" ",positions)));
        int[] lengths = new int[] {
            42643329,
            9909484,
            58137134,
            99547272,
            39849232,
            15146704,
            144630245,
            604149,
            15591965,
            107856540
        };
        Console.WriteLine(string.Format("lengths:{0}",string.Join(" ",lengths)));
        long __expected = 1009957100L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ConnectingCars().minimizeCost(positions, lengths);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
