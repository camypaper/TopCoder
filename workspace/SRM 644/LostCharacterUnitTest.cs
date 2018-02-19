using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class LostCharacterTest
{
    [TestMethod]
    public void Example0()
    {
        string[] str = new string[] {
            "abc",
            "bcd",
            "cde",
            "cdf",
            "bbc"
        };
        Console.WriteLine(string.Format("str:{0}",string.Join(" ",str)));
        int[] __expected = new int[] {
            0,
            2,
            3,
            4,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new LostCharacter().getmins(str);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example1()
    {
        string[] str = new string[] {
            "?ala",
            "ara",
            "baba"
        };
        Console.WriteLine(string.Format("str:{0}",string.Join(" ",str)));
        int[] __expected = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new LostCharacter().getmins(str);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example2()
    {
        string[] str = new string[] {
            "a?",
            "a",
            "a",
            "ab",
            "aa"
        };
        Console.WriteLine(string.Format("str:{0}",string.Join(" ",str)));
        int[] __expected = new int[] {
            2,
            0,
            0,
            3,
            2
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new LostCharacter().getmins(str);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example3()
    {
        string[] str = new string[] {
            "s?nu?ke",
            "sm??eke",
            "?sna?ke",
            "so?th?e",
            "shake??"
        };
        Console.WriteLine(string.Format("str:{0}",string.Join(" ",str)));
        int[] __expected = new int[] {
            0,
            1,
            0,
            2,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new LostCharacter().getmins(str);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example4()
    {
        string[] str = new string[] {
            "?",
            "z?",
            "zz?",
            "zzz?",
            "zzzz?",
            "zzzzz?",
            "zzzzzz?"
        };
        Console.WriteLine(string.Format("str:{0}",string.Join(" ",str)));
        int[] __expected = new int[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        int[] __result = new LostCharacter().getmins(str);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

}
