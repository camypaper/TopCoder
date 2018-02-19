using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class OkonomiyakiPartyTest
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
        int M = 2;
        Console.WriteLine("M:{0}",M);
        int K = 3;
        Console.WriteLine("K:{0}",K);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiParty().count(osize, M, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] osize = new int[] {
            1,
            6,
            2,
            7,
            4,
            2,
            6,
            1,
            5,
            2,
            4
        };
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));
        int M = 4;
        Console.WriteLine("M:{0}",M);
        int K = 3;
        Console.WriteLine("K:{0}",K);
        int __expected = 60;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiParty().count(osize, M, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] osize = new int[] {
            1,
            4,
            5,
            7,
            10,
            11,
            13,
            16,
            18
        };
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));
        int M = 4;
        Console.WriteLine("M:{0}",M);
        int K = 5;
        Console.WriteLine("K:{0}",K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiParty().count(osize, M, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] osize = new int[] {
            55,
            2,
            7,
            232,
            52,
            5,
            5332,
            623,
            52,
            6,
            532,
            5147
        };
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));
        int M = 6;
        Console.WriteLine("M:{0}",M);
        int K = 10000;
        Console.WriteLine("K:{0}",K);
        int __expected = 924;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiParty().count(osize, M, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] osize = new int[] {
            5781,
            8708,
            1754,
            4750,
            9888,
            3675,
            4810,
            1020,
            922,
            9834,
            5695,
            1101,
            1236,
            2496,
            8431,
            6727,
            1376,
            3373,
            4423,
            1839,
            7438,
            9407,
            1851,
            6966,
            8715,
            2905,
            542,
            535,
            8980,
            2602,
            2603,
            3117,
            3452,
            5682,
            7775,
            4356,
            5140,
            8923,
            9801,
            3729
        };
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));
        int M = 15;
        Console.WriteLine("M:{0}",M);
        int K = 4003;
        Console.WriteLine("K:{0}",K);
        int __expected = 114514;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new OkonomiyakiParty().count(osize, M, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
