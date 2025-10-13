// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T01: Number Conversion Game (Decimal to Binary and Hex)
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   // Converts decimal to binary number and hex numeral.
   static string BinaryHexConverter (int inp, int div) {
      if (inp == 0) return "0";
      string result = "";
      string hexChars = "0123456789ABCDEF";
      while (inp > 0) {
         int rem = inp % div;
         inp /= div;
         if (div == 2) result = rem + result;
         else result = hexChars[rem] + result;
      }
      return result;
   }

   static void Main () {
      Write ("Enter a number: ");
      string? input = ReadLine ();
      if (int.TryParse (input, out int result)) {
         WriteLine ($"Binary number: {BinaryHexConverter (result, 2)}");
         WriteLine ($"Hex number: {BinaryHexConverter (result, 16)}");
      } else WriteLine ("Invalid input");
   }
}