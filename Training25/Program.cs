// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T01 branch."This code is used to convert decimal number, to binarynumber and hexadecimal".
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   // Converts decimal to binary number.
   static string BinaryConverter (int input) {
      if (input == 0) return "0";
      string result = "";
      while (input > 0) {
         int remainder = input % 2;
         input /= 2;
         result = remainder + result;
      }
      return result;
   }

   // Converts decimal to Hexadecimal.
   static string HexConverter (int input) {
      if (input == 0) return "0";
      string hexChars = "0123456789ABCDEF";
      string result = "";
      while (input > 0) {
         int remainder = input % 16;
         input /= 16;
         result = hexChars[remainder] + result;
      }
      return result;
   }

   static void Main () {
      WriteLine ("Enter a number");
      string? input = ReadLine ();
      if (int.TryParse (input, out int result)) {
         WriteLine ($"Binary number:{BinaryConverter (result)}");
         WriteLine ($"Hex number:{HexConverter (result)}");
      } else WriteLine ("Invalid input");
   }
}