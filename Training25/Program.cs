// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T06:Digital Root of a Number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25 {

   internal class Program {
      static void Main () {
         while (true) {
            Write ("Enter a number to find its digital root or '-1' to exit: ");
            bool isValid = int.TryParse (ReadLine (), out int num) && num >= 0;
            if(num== -1) break;
            WriteLine (isValid ? $"=>The digital root of {num} is {DigitalRoot (num)}\n" : "Invalid input.Try again\n");
         }
      }

      // Function to calculate Digital Root of a number
      static int DigitalRoot (int inp) {
         while (true) {
            // Separates the digits except the last digit.
            int div = inp / 10;
            // Separates the last digit.
            int rem = inp % 10;
            inp = div + rem;
            if (inp < 10) break;
         }
         return inp;
      }
   }
}