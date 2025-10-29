// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         WriteLine ("Enter the numbers to get sorted or 'X' to close: ");
         var inputStr = ReadLine ();
         if (inputStr?.ToLower () == "x") {
            break;
         }
         bool isValid = int.TryParse (inputStr, out int input) && input != 0;
         if (isValid) {
            WriteLine ($"The sorted number for the given input {input} is: {GetEvenDigits (input)}\n");
            continue;
         }
         WriteLine ("Invalid input.\n");
      }
   }

   // Gets even digits first in ascending order followed by odd digits in ascending order.
   static string GetEvenDigits (int input) {
      List<int> digits = [];
      string result = "";
      while (input > 0) {
         digits.Add (input % 10);
         input /= 10;
      }
      digits.Sort ();
      foreach (int digit in digits) {
         if (digit % 2 == 0) {
            result += digit;
         }
      }
      foreach (int digit in digits) {
         if (digit % 2 != 0) {
            result += digit;
         }
      }
      return result;
   }
   #endregion
}
#endregion