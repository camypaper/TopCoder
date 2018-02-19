using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string[] attendance = Scanner.In.string_array();
        Console.WriteLine(string.Format("attendance:{0}",string.Join(" ",attendance)));
        string[] problemTopics = Scanner.In.string_array();
        Console.WriteLine(string.Format("problemTopics:{0}",string.Join(" ",problemTopics)));
        string[] __result  = new TrainingCamp().determineSolvers(attendance, problemTopics);; ;
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
 
    }

    [TestMethod]
    public void Example0()
    {
        string[] attendance = new string[] {
            "XXX",
            "XXX",
            "XX-"
        };
        Console.WriteLine(string.Format("attendance:{0}",string.Join(" ",attendance)));
        string[] problemTopics = new string[] {
            "---",
            "XXX",
            "-XX",
            "XX-"
        };
        Console.WriteLine(string.Format("problemTopics:{0}",string.Join(" ",problemTopics)));
        string[] __expected = new string[] {
            "XXXX",
            "XXXX",
            "X--X"
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        string[] __result = new TrainingCamp().determineSolvers(attendance, problemTopics);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example1()
    {
        string[] attendance = new string[] {
            "-XXXX",
            "----X",
            "XXX--",
            "X-X-X"
        };
        Console.WriteLine(string.Format("attendance:{0}",string.Join(" ",attendance)));
        string[] problemTopics = new string[] {
            "X---X",
            "-X---",
            "XXX--",
            "--X--"
        };
        Console.WriteLine(string.Format("problemTopics:{0}",string.Join(" ",problemTopics)));
        string[] __expected = new string[] {
            "-X-X",
            "----",
            "-XXX",
            "X--X"
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        string[] __result = new TrainingCamp().determineSolvers(attendance, problemTopics);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example2()
    {
        string[] attendance = new string[] {
            "-----",
            "XXXXX"
        };
        Console.WriteLine(string.Format("attendance:{0}",string.Join(" ",attendance)));
        string[] problemTopics = new string[] {
            "XXXXX",
            "-----",
            "--X-X"
        };
        Console.WriteLine(string.Format("problemTopics:{0}",string.Join(" ",problemTopics)));
        string[] __expected = new string[] {
            "-X-",
            "XXX"
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        string[] __result = new TrainingCamp().determineSolvers(attendance, problemTopics);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example3()
    {
        string[] attendance = new string[] {
            "-",
            "X",
            "X",
            "-",
            "X"
        };
        Console.WriteLine(string.Format("attendance:{0}",string.Join(" ",attendance)));
        string[] problemTopics = new string[] {
            "-",
            "X"
        };
        Console.WriteLine(string.Format("problemTopics:{0}",string.Join(" ",problemTopics)));
        string[] __expected = new string[] {
            "X-",
            "XX",
            "XX",
            "X-",
            "XX"
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        string[] __result = new TrainingCamp().determineSolvers(attendance, problemTopics);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example4()
    {
        string[] attendance = new string[] {
            "X----X--X",
            "X--X-X---",
            "--X-X----",
            "XXXX-X-X-",
            "XXXX--XXX"
        };
        Console.WriteLine(string.Format("attendance:{0}",string.Join(" ",attendance)));
        string[] problemTopics = new string[] {
            "X----X-X-",
            "-----X---",
            "-X----X-X",
            "-X-X-X---",
            "-----X---",
            "X-------X"
        };
        Console.WriteLine(string.Format("problemTopics:{0}",string.Join(" ",problemTopics)));
        string[] __expected = new string[] {
            "-X--XX",
            "-X--X-",
            "------",
            "XX-XX-",
            "--X--X"
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        string[] __result = new TrainingCamp().determineSolvers(attendance, problemTopics);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

}
