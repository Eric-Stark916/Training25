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
         Write ("Enter a number to see transformation steps, or 'X' to exit or 'I' for information: ");
         var input = ReadLine ();
         if (input?.ToLower ().Trim () == "i") {
            WriteLine ("\n1)This program calculates the smallest number of steps required to" +
                       "\ntransform all digits of a given number into a same digit." +
                       "\n2)The transformed digit must be with in the given number." +
                       "\n3)Each step consists of incrementing or decrementing a digit by 1." +
                       "\nExample: 399 -> 999 -> 6 Steps.\n");
            continue;
         }
         if (input?.ToLower ().Trim () == "x") break;
         bool isvalid = int.TryParse (input, out var num) && num >= 0;
         WriteLine (isvalid ? $"The smallest possible steps required to change the number {input} is: " +
                              $"{smallest (num)}\n" : "Invalid input.\n");
      }
   }

   // This method finds the digit in the number that requires the least total steps to convert all other digits to it.
   static int smallest (int inp) {
      List<int> numList = [];
      if (inp < 10) return 0;
      while (inp > 0) {
         int rem = inp % 10;
         numList.Add (rem);
         inp = inp / 10;
      }
      int minSteps = int.MaxValue;
      for (int i = 0; i < numList.Count; i++) {
         int steps = 0;
         for (int j = 0; j < numList.Count; j++)
            steps += Math.Abs (numList[i] - numList[j]);
         if (steps < minSteps) minSteps = steps;
      }
      return minSteps;
   }
   #endregion
}
#endregion