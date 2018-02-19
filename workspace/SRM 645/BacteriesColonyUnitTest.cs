using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class BacteriesColonyTest
{
    [TestMethod]
    public void Example0()
    {
        int[] colonies = new int[] {
            5,
            3,
            4,
            6,
            1
        };
        Console.WriteLine(string.Format("colonies:{0}",string.Join(" ",colonies)));
        int[] __expected = new int[] {
            5,
            4,
            4,
            4,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new BacteriesColony().performTheExperiment(colonies);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example1()
    {
        int[] colonies = new int[] {
            1,
            5,
            4,
            9
        };
        Console.WriteLine(string.Format("colonies:{0}",string.Join(" ",colonies)));
        int[] __expected = new int[] {
            1,
            4,
            5,
            9
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new BacteriesColony().performTheExperiment(colonies);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example2()
    {
        int[] colonies = new int[] {
            78,
            34,
            3,
            54,
            44,
            99
        };
        Console.WriteLine(string.Format("colonies:{0}",string.Join(" ",colonies)));
        int[] __expected = new int[] {
            78,
            34,
            34,
            49,
            49,
            99
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new BacteriesColony().performTheExperiment(colonies);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example3()
    {
        int[] colonies = new int[] {
            32,
            68,
            50,
            89,
            34,
            56,
            47,
            30,
            82,
            7,
            21,
            16,
            82,
            24,
            91
        };
        Console.WriteLine(string.Format("colonies:{0}",string.Join(" ",colonies)));
        int[] __expected = new int[] {
            32,
            59,
            59,
            59,
            47,
            47,
            47,
            47,
            47,
            18,
            18,
            19,
            53,
            53,
            91
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new BacteriesColony().performTheExperiment(colonies);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

}
