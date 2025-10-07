// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T03 //This code is used to find GCD and LCM of two numbers.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   /// <summary>Gives the Gretest common divisor for the given two numbers</summary>
   /// <param name="a">Takes only Natural numbers</param>
   /// <param name="b">Takes only Natural numbers</param>
   /// <returns>Gretest common divisor </returns>
   static int Gcd (int a, int b) {
      int remainder;
      while (b != 0) {
         remainder = a % b;
         if (remainder == 1) return 1;
         a = b;
         b = remainder;
      }
      return a;
   }

   /// <summary>Gives the Lowest common divisor for the given two numbers</summary>
   /// <param name="a">Takes only Natural numbers</param>
   /// <param name="b">Takes only Natural numbers</param>
   /// <returns>Lowest common divisor</returns>
   static int Lcm(int a, int b) {
      return ((a * b) / Gcd (a, b));
   }

   static void Main () {
      WriteLine (" What two number you need to find GCD & LCM eg:10,5: ");
      string[] num = ReadLine()?.Split (',') ?? Array.Empty<string> ();
      if (int.TryParse ((num[0]), out int value1) && int.TryParse ((num[1]),
         out int value2) && num.Length == 2 && (value1 > 0 && value2 > 0)) {
         WriteLine ($"The GCD of the given input {value1},{value2} is:" + Gcd (value1, value2));
         WriteLine ($"The LCM of the given input {value1},{value2} is:" + Lcm (value1, value2));
      } else WriteLine ("Invalid input, please enter two positive integers separated by a comma.");
   }
}