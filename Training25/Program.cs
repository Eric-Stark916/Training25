// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T11: Armstrong Number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Enter the number to find the Armstrong number or 'X' to exit: ");
         var input = ReadLine ()?.Trim ().ToLower ();
         if (input == "x") break;
         else if (!int.TryParse (input, out int num) || num < 0)
            WriteLine ("Invalid input.");
         else {
            if (IsArmstrongNum (num))
               WriteLine ($"The given number '{num}' is an Armstrong number.");
            else
               WriteLine ($"The given number '{num}' is not an Armstrong number.");
         }
         WriteLine ();
      }
   }

   // Checks whether the given number is an Armstrong number or not.
   static bool IsArmstrongNum (int inp) {
      if (inp < 10) return true;
      int result = 0;
      int inpNum = inp;
      while (inp > 0) {
         int div = inp / 10;
         result += (int)Math.Pow (inp % 10, inpNum.ToString ().Length);
         inp = div;
      }
      if (inpNum == result) return true;
      return false;
   }
   #endregion
}
#endregion