using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] a = Scanner.In.int_array();
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int b = Scanner.In.@int();
        Console.WriteLine("b:{0}",b);
        int __result  = new CartInSupermarket().calcmin(a, b);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            8
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int b = 3;
        Console.WriteLine("b:{0}",b);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarket().calcmin(a, b);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            6,
            6,
            5
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int b = 3;
        Console.WriteLine("b:{0}",b);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarket().calcmin(a, b);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            12,
            5,
            6,
            2,
            6,
            8
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int b = 4;
        Console.WriteLine("b:{0}",b);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarket().calcmin(a, b);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            15,
            20,
            11,
            13,
            18,
            24,
            25,
            21,
            22,
            10,
            15,
            14,
            19
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int b = 0;
        Console.WriteLine("b:{0}",b);
        int __expected = 25;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarket().calcmin(a, b);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            671122748,
            846444748,
            84701624,
            608579554,
            672060899,
            967957440,
            31438849,
            734849843,
            376589643,
            904285209,
            80693344,
            211737743,
            85405464,
            444633541,
            293184188,
            935462519,
            146753109,
            972886045,
            496631016,
            601669536,
            257574086,
            958464570,
            6294570,
            546189534,
            668105964,
            601197313,
            784337929,
            921840143,
            70408284,
            722040626,
            253400894,
            56411549,
            811940644,
            152086353,
            122638884,
            776352066,
            118932182,
            177589709,
            538122558,
            127914469,
            523761221,
            290027568,
            734517444,
            819458123,
            699130727,
            784698122,
            810265337,
            283326309,
            593596316,
            368671876
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int b = 6478;
        Console.WriteLine("b:{0}",b);
        int __expected = 3805054;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarket().calcmin(a, b);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
