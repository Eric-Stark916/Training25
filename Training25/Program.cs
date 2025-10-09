// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T07.//This code creates a Pascal's Triangle up to a specified number of rows.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   // Prints Pascal's triangle
   static int PascalTriangle (int rowLimit) {
      int value = 0;
      for (int row = 0; row < rowLimit; row++) {                       // for Row traverse
         value = 1;
         for (int gap = 0; gap < rowLimit - row; gap++) Write (" ");  // for spaces in decending order to form the triangle shape
         for (int col = 0; col <= row; col++) {                      // for coloumn traverse
            Write ($"{value} ");
            value = value * (row - col) / (col + 1);
         }
         WriteLine ();                                             // New line after each row
      }
      return value;
   }

   static void Main () {
      bool isValid = false;
      while (!isValid) {
         WriteLine ("Enter number of rows required in Pascal's Triangle:");
         if (int.TryParse (ReadLine (), out int output) && output > 0 &&
            output < 20) {
            isValid = true;
            PascalTriangle (output);
         } else WriteLine ("Invalid Input,Enter a valid one");
      }
   }
}