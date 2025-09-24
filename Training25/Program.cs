// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T01 branch."This code is used to convert decimal number, to binarynumber and hexadecimal".
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   /// <summary>It is used to convert a normal decimal number to Binary number</summary>
   /// <param name="input">Input number is taken from the user,takes only natural numbers</param>
   /// <returns>Binary number for the given decimal number</returns>
   static string BinaryConverter (int input) {
      string result = "";
      while (input != 0) {
         int remainder = input % 2;
         input /= 2;
         result = remainder + result;
      }
      return result;
   }

   /// <summary>It is used to convert a normal decimal number to Binary number</summary>
   /// <param name="input">Input number is taken from the user,takes only natural numbers</param>
   /// <returns>Hexadecimal number for the given decimal number</returns>
   static string HexConverter (int input) {
      string hexChar = "0123456789ABCDEF";
      string result = "";
      while (input != 0) {
         int remainder = input % 16;
         input /= 16;
         result = hexChar[remainder] + result;
      }
      return result;
   }

   static void Main (string[] args) {
      Console.WriteLine ("Enter a number");
      string input = Console.ReadLine ();
      if (int.TryParse (input, out int result) && result != 0) {
         Console.WriteLine ($"Binary number:{BinaryConverter (result)}");
         Console.WriteLine ($"Hex number:{HexConverter (result)}");
      } else Console.WriteLine ("Invalid input");
   }
}