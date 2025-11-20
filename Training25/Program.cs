// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T14: Smallest Transform.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Enter a number (or X to exit, I for information: ");
         var input = ReadLine ()?.Trim ().ToLower ();
         if (input == "i") {
            WriteLine ("""
               
               1)This program calculates the minimum number of steps required to
                 transform all digits of a given number into the same digit.
               2)The target digit must be one of the digits present in the given number.
               3)Each step consists of incrementing or decrementing a digit by 1.
                 Example: 399 -> 999 requires 6 steps.

               """);
            continue;
         }
         if (input == "x") break;
         bool isvalid = int.TryParse (input, out var num) && num >= 0;
         WriteLine (isvalid ? $"The minimum steps to change the number {input}: " +
                              $"{GetMinSteps (num)}\n" : "Invalid input.\n");
      }
   }

   // finds the digit in the number that requires the least total steps to convert all other digits to it.
   static int GetMinSteps (int inp) {
      if (inp < 10) return 0;
      int minSteps = int.MaxValue;
      for (int temp = inp; temp > 0; temp /= 10) {
         int rem = inp, steps = 0;
         int targetDigit = temp % 10;
         while (rem > 0) {
            int digit = rem % 10;
            steps += Math.Abs (digit - targetDigit);
            rem /= 10;
         }
         if (steps < minSteps) minSteps = steps;
      }
      return minSteps;
   }
   #endregion
}
#endregion