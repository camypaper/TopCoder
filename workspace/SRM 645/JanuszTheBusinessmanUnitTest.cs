using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class JanuszTheBusinessmanTest
{
    [TestMethod]
    public void Example0()
    {
        int[] arrivals = new int[] {
            2,
            10,
            6
        };
        Console.WriteLine(string.Format("arrivals:{0}",string.Join(" ",arrivals)));
        int[] departures = new int[] {
            6,
            11,
            9
        };
        Console.WriteLine(string.Format("departures:{0}",string.Join(" ",departures)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new JanuszTheBusinessman().makeGuestsReturn(arrivals, departures);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] arrivals = new int[] {
            2,
            10,
            23,
            34,
            45,
            123,
            1
        };
        Console.WriteLine(string.Format("arrivals:{0}",string.Join(" ",arrivals)));
        int[] departures = new int[] {
            25,
            12,
            40,
            50,
            48,
            187,
            365
        };
        Console.WriteLine(string.Format("departures:{0}",string.Join(" ",departures)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new JanuszTheBusinessman().makeGuestsReturn(arrivals, departures);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] arrivals = new int[] {
            8,
            12,
            20,
            30,
            54,
            54,
            68,
            75
        };
        Console.WriteLine(string.Format("arrivals:{0}",string.Join(" ",arrivals)));
        int[] departures = new int[] {
            13,
            31,
            30,
            53,
            55,
            70,
            80,
            76
        };
        Console.WriteLine(string.Format("departures:{0}",string.Join(" ",departures)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new JanuszTheBusinessman().makeGuestsReturn(arrivals, departures);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] arrivals = new int[] {
            124,
            328,
            135,
            234,
            347,
            124,
            39,
            99,
            116,
            148
        };
        Console.WriteLine(string.Format("arrivals:{0}",string.Join(" ",arrivals)));
        int[] departures = new int[] {
            237,
            335,
            146,
            246,
            353,
            213,
            197,
            215,
            334,
            223
        };
        Console.WriteLine(string.Format("departures:{0}",string.Join(" ",departures)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new JanuszTheBusinessman().makeGuestsReturn(arrivals, departures);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] arrivals = new int[] {
            154,
            1,
            340,
            111,
            92,
            237,
            170,
            113,
            241,
            91,
            228,
            134,
            191,
            86,
            59,
            115,
            277,
            328,
            12,
            6
        };
        Console.WriteLine(string.Format("arrivals:{0}",string.Join(" ",arrivals)));
        int[] departures = new int[] {
            159,
            4,
            341,
            118,
            101,
            244,
            177,
            123,
            244,
            96,
            231,
            136,
            193,
            95,
            64,
            118,
            282,
            330,
            17,
            13
        };
        Console.WriteLine(string.Format("departures:{0}",string.Join(" ",departures)));
        int __expected = 14;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new JanuszTheBusinessman().makeGuestsReturn(arrivals, departures);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
