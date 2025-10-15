// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T03: LCM & GCD Generator
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   // Gives the greatest common divisor of a and b
   static int GCD (int a, int b) {
      while (b != 0) {
         int rem = a % b;
         a = b;
         b = rem;
      }
      return a;
   }

   static void Main () {
      WriteLine ("Enter two positive integers to find their GCD and LCM: ");
      string? num1 = ReadLine ();
      string? num2 = ReadLine ();
      if (int.TryParse (num1, out int val1) && int.TryParse (num2, out int val2)
         && val1 > 0 && val2 > 0) {
         int gcd = GCD (val1, val2);
         WriteLine ($"The GCD of the given input {val1}, {val2} is: {gcd}");
         WriteLine ($"The LCM of the given input {val1}, {val2} is: {val1 * val2 / gcd}");
      } else WriteLine ("Invalid input, please enter two positive integers.");
   }
}