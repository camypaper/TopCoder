using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] platformMount = Scanner.In.int_array();
        Console.WriteLine(string.Format("platformMount:{0}",string.Join(" ",platformMount)));
        int[] platformLength = Scanner.In.int_array();
        Console.WriteLine(string.Format("platformLength:{0}",string.Join(" ",platformLength)));
        int[] balls = Scanner.In.int_array();
        Console.WriteLine(string.Format("balls:{0}",string.Join(" ",balls)));
        int __result  = new YetAnotherIncredibleMachine().countWays(platformMount, platformLength, balls);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] platformMount = new int[] {
            7
        };
        Console.WriteLine(string.Format("platformMount:{0}",string.Join(" ",platformMount)));
        int[] platformLength = new int[] {
            10
        };
        Console.WriteLine(string.Format("platformLength:{0}",string.Join(" ",platformLength)));
        int[] balls = new int[] {
            3,
            4
        };
        Console.WriteLine(string.Format("balls:{0}",string.Join(" ",balls)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new YetAnotherIncredibleMachine().countWays(platformMount, platformLength, balls);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] platformMount = new int[] {
            1,
            4
        };
        Console.WriteLine(string.Format("platformMount:{0}",string.Join(" ",platformMount)));
        int[] platformLength = new int[] {
            3,
            3
        };
        Console.WriteLine(string.Format("platformLength:{0}",string.Join(" ",platformLength)));
        int[] balls = new int[] {
            2,
            7
        };
        Console.WriteLine(string.Format("balls:{0}",string.Join(" ",balls)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new YetAnotherIncredibleMachine().countWays(platformMount, platformLength, balls);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] platformMount = new int[] {
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("platformMount:{0}",string.Join(" ",platformMount)));
        int[] platformLength = new int[] {
            10,
            9,
            8
        };
        Console.WriteLine(string.Format("platformLength:{0}",string.Join(" ",platformLength)));
        int[] balls = new int[] {
            1,
            100
        };
        Console.WriteLine(string.Format("balls:{0}",string.Join(" ",balls)));
        int __expected = 27;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new YetAnotherIncredibleMachine().countWays(platformMount, platformLength, balls);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] platformMount = new int[] {
            0
        };
        Console.WriteLine(string.Format("platformMount:{0}",string.Join(" ",platformMount)));
        int[] platformLength = new int[] {
            1
        };
        Console.WriteLine(string.Format("platformLength:{0}",string.Join(" ",platformLength)));
        int[] balls = new int[] {
            0
        };
        Console.WriteLine(string.Format("balls:{0}",string.Join(" ",balls)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new YetAnotherIncredibleMachine().countWays(platformMount, platformLength, balls);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] platformMount = new int[] {
            100,
            -4215,
            251
        };
        Console.WriteLine(string.Format("platformMount:{0}",string.Join(" ",platformMount)));
        int[] platformLength = new int[] {
            400,
            10000,
            2121
        };
        Console.WriteLine(string.Format("platformLength:{0}",string.Join(" ",platformLength)));
        int[] balls = new int[] {
            5000,
            2270,
            8512,
            6122
        };
        Console.WriteLine(string.Format("balls:{0}",string.Join(" ",balls)));
        int __expected = 250379170;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new YetAnotherIncredibleMachine().countWays(platformMount, platformLength, balls);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
