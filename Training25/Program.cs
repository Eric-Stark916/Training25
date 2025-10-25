// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T06: Digital Root of a Number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25 {

   #region class Program --------------------------------------------------------------------------
   internal class Program {
      #region Implementation ----------------------------------------
      static void Main () {
         while (true) {
            Write ("Enter a number to find its digital root or 'X' to exit: ");
            var input = ReadLine ()?.Trim ().ToLower ();
            if (input == "x") break;
            bool isValid = int.TryParse (input, out int num) && num >= 0;
            WriteLine (isValid ? $"The digital root of {num} is {DigitalRoot (num)}\n" : "Invalid input. Try again.\n");
         }
      }

      // Function to calculate Digital Root of a number.
      static int DigitalRoot (int inp) {
         while (inp >= 10) {
            // Separates the digits except the last digit.
            int div = inp / 10;
            // Separates the last digit.
            int rem = inp % 10;
            inp = div + rem;
         }
         return inp;
      }
   }
   #endregion
}
#endregion