// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T01 branch."This code is used to convert decimal number to binarynumber and hexadecimal".
// ------------------------------------------------------------------------------------------------
using System.Linq;

namespace Training25;
internal class Program {
   public static string Binaryconvertor (int input) {
      string result = "";
      while (input != 0) {
         int rem = input % 2;
         int quotient = input / 2;
         result = rem + result;
         input = quotient;
      }
      return result;
   }
   public static string Hexconvertor (int input) {
      Dictionary<int, string> hexnum = new Dictionary<int, string> () {
         { 0, "0" },{ 1, "1" },
         { 2, "2" },{ 3, "3" },
         { 4, "4" },{ 5, "5" },
         { 6, "6" },{ 7, "7" },
         { 8, "8" },{ 9, "9" },
         { 10, "A" },{ 11, "B" },
         { 12, "C" },{ 13, "D" },
         { 14, "E" }, { 15, "F" },
   };
      List<int> list = new List<int> ();
      int[] n = new int[10];
      string result = "";
      while (input != 0) {
         int remainder = input % 16;
         int Quotient = input / 16;
         list.Add (remainder);
         input = Quotient;
      }
      foreach (int i in list) {
         if (hexnum.ContainsKey (i)) {
            result = hexnum[i] + result;
         }
      }
      return result;
   }
   static void Main (string[] args) {
      Console.WriteLine ("Enter a number to convert into binary");
      int input = int.Parse (Console.ReadLine ());
      Console.WriteLine ($"Binary number for the input:{input} is " + Binaryconvertor (input));
      Console.WriteLine ($"Hex number for the input:{input} is " + Hexconvertor (input));




   }
}