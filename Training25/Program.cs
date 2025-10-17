// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T07: Pascal's Triangle
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Enter number of rows required in Pascal's triangle (1-13): ");
         // Above row 13, numbers are too close to each other.
         if (int.TryParse (ReadLine (), out int inp) && inp > 0 && inp < 14) {
            PrintPascalTriangle (inp);
            break;
         }
         WriteLine ("Invalid input. Please try again.");
      }
   }

   // Prints Pascal's triangle
   static void PrintPascalTriangle (int rows) {
      // For row traverse
      for (int row = 0; row < rows; row++) {
         int value = 1;
         // For spaces in descending order to form the triangle shape
         for (int gap = 0; gap < (rows - row) * 2; gap++) Write (" ");
         // For column traverse
         for (int col = 0; col <= row; col++) {
            Write ($"{value,4}");
            value = value * (row - col) / (col + 1);
         }
         // New line after each row
         WriteLine ();
      }
   }
}