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
   //Gives the Gretest common divisor for the given two numbers.
   //Both input a and b Takes only Natural numbers.
   //Returns Gretest common divisor.
   static int Gcd (int a, int b) {
      while (b != 0) {
         int remainder = a % b;
         a = b;
         b = remainder;
      }
      return a;
   }

   //Gives the Lowest common divisor for the given two numbers.
   //Both input a and b Takes only Natural numbers.
   //Returns Lowest common divisor.
   static int Lcm (int a, int b) => (a * b) / Gcd (a, b);

   static void Main () {
      WriteLine ("Enter two positive integers to find their GCD and LCM.");
      string? num1 = ReadLine ();
      string? num2 = ReadLine ();
      if (int.TryParse (num1, out int value1) && int.TryParse (num2, out int value2)
         && (value1 > 0 && value2 > 0)) {
         WriteLine ($"The GCD of the given input {value1},{value2} is:" + Gcd (value1, value2));
         WriteLine ($"The LCM of the given input {value1},{value2} is:" + Lcm (value1, value2));
      } else WriteLine ("Invalid input, please enter two positive integers ");
   }
}