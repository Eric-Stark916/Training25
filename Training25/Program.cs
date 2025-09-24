// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T01 branch."This code is used to convert decimal number, to binarynumber and hexadecimal".
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static string binaryConverter (int input) {
      string result = "";
      while (input != 0) {
         int rem = input % 2;
         input /= 2;
         result = rem + result;
      }
      return result;
   }

   static string hexConverter (int input) {
      string hexchar = "0123456789ABCDEF";
      string result = "";
      while (input != 0) {
         int remainder = input % 16;
         input /= 16;
         result = hexchar[remainder] + result;
      }
      return result;
   }

   static void Main (string[] args) {
      Console.WriteLine ("Enter a number");
      string input = Console.ReadLine ();
      bool s = int.TryParse (input, out int result);
      if (s) {
         Console.WriteLine ($"Binary number:{binaryConverter (result)}");
         Console.WriteLine ($"Hex number:{hexConverter (result)}");
      } else {
         Console.WriteLine ("Invalid input");
      }
   }
}