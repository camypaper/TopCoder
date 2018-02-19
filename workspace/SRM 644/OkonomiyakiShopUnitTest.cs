using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class OkonomiyakiShopTest
{
    [TestMethod]
    public void Example0()
    {
        int[] osize = new int[] {
            1,
            4,
            6,
            7,
            9
        };
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));
        int K = 3;
        Console.WriteLine("K:{0}",K);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiShop().count(osize, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] osize = new int[] {
            1,
            1,
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));
        int K = 2;
        Console.WriteLine("K:{0}",K);
        int __expected = 10;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiShop().count(osize, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] osize = new int[] {
            1,
            5,
            9,
            14,
            20
        };
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));
        int K = 3;
        Console.WriteLine("K:{0}",K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiShop().count(osize, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] osize = new int[] {
            7,
            2,
            6,
            3,
            4,
            2,
            7,
            8,
            3,
            4,
            9,
            1,
            8,
            4,
            3,
            7,
            5,
            2,
            1,
            9,
            9,
            4,
            5
        };
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));
        int K = 6;
        Console.WriteLine("K:{0}",K);
        int __expected = 234;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiShop().count(osize, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
