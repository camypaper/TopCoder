using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string[] cityMap = Scanner.In.string_array();
        Console.WriteLine(string.Format("cityMap:{0}",string.Join(" ",cityMap)));
        int[] POIs = Scanner.In.int_array();
        Console.WriteLine(string.Format("POIs:{0}",string.Join(" ",POIs)));
        string __result  = new CityMap().getLegend(cityMap, POIs);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string[] cityMap = new string[] {
            "M....M",
            "...R.M",
            "R..R.R"
        };
        Console.WriteLine(string.Format("cityMap:{0}",string.Join(" ",cityMap)));
        int[] POIs = new int[] {
            3,
            4
        };
        Console.WriteLine(string.Format("POIs:{0}",string.Join(" ",POIs)));
        string __expected = "MR";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CityMap().getLegend(cityMap, POIs);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] cityMap = new string[] {
            "XXXXXXXZXYYY"
        };
        Console.WriteLine(string.Format("cityMap:{0}",string.Join(" ",cityMap)));
        int[] POIs = new int[] {
            1,
            8,
            3
        };
        Console.WriteLine(string.Format("POIs:{0}",string.Join(" ",POIs)));
        string __expected = "ZXY";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CityMap().getLegend(cityMap, POIs);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] cityMap = new string[] {
            "...........",
            "...........",
            "...........",
            "..........T"
        };
        Console.WriteLine(string.Format("cityMap:{0}",string.Join(" ",cityMap)));
        int[] POIs = new int[] {
            1
        };
        Console.WriteLine(string.Format("POIs:{0}",string.Join(" ",POIs)));
        string __expected = "T";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CityMap().getLegend(cityMap, POIs);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] cityMap = new string[] {
            "AIAAARRI.......GOAI.",
            ".O..AIIGI.OAAAGI.A.I",
            ".A.IAAAARI..AI.AAGR.",
            "....IAI..AOIGA.GAIA.",
            "I.AIIIAG...GAR.IIAGA",
            "IA.AOA....I....I.GAA",
            "IOIGRAAAO.AI.AA.RAAA",
            "AI.AAA.AIR.AGRIAAG..",
            "AAAAIAAAI...AAG.RGRA",
            ".J.IA...G.A.AA.II.AA"
        };
        Console.WriteLine(string.Format("cityMap:{0}",string.Join(" ",cityMap)));
        int[] POIs = new int[] {
            16,
            7,
            1,
            35,
            11,
            66
        };
        Console.WriteLine(string.Format("POIs:{0}",string.Join(" ",POIs)));
        string __expected = "GOJIRA";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CityMap().getLegend(cityMap, POIs);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
