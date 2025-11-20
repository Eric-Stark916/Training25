// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T11.1: Nth Armstrong Number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Enter a number (1–25) to find the nth Armstrong number, or 'X' to exit: ");
         var inp = ReadLine ()?.Trim ().ToLower ();
         if (inp == "x") break;
         else if (int.TryParse (inp, out int nthPlace) && nthPlace is > 0 and < 26)
            // Upto 10th Armstrong number 'GetArmstrongNum' method is not called.
            WriteLine ($"The #{nthPlace} Armstrong number is: {(nthPlace <= 10 ? nthPlace - 1 : GetArmstrongNum (nthPlace))}\n");
      }
   }

   // Returns the nth Armstrong number.
   static string GetArmstrongNum (int nthPlace) {
      // We start from 153 (11th Armstrong number) to avoid recalculating previous values.
      int num = 153, placeCount = 10;
      while (true) {
         if (IsArmstrongNum (num)) placeCount++;
         if (placeCount == nthPlace) break;
         num++;
      }
      return num.ToString ();
   }

   // Finds whether a number is an Armstrong number or not.
   static bool IsArmstrongNum (int inp) {
      int len = inp.ToString ().Length, sum = 0;
      for (int temp = inp; temp > 0; temp /= 10)
         sum += (int)Math.Pow (temp % 10, len);
      return sum == inp;
   }
   #endregion
}
#endregion