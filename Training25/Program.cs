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
         WriteLine ("Enter number of rows required in Pascal's triangle: ");
         // Row limit above 20 will make the triangle too wide
         if (int.TryParse (ReadLine (), out int output) && output > 0 &&
            output < 20) {
            BuildPascalTriangle (output);
            break;
         } else WriteLine ("Invalid input");
      }
   }

   // Prints Pascal's triangle
   static int BuildPascalTriangle (int rows) {
      int value = 0;
      // For row traverse
      for (int row = 0; row < rows; row++) {
         value = 1;
         // For spaces in descending order to form the triangle shape
         for (int gap = 0; gap < rows - row; gap++) Write (" ");
         // For column traverse
         for (int col = 0; col <= row; col++) {
            Write ($"{value} ");
            value = value * (row - col) / (col + 1);
         }
         // New line after each row
         WriteLine ();
      }
      return value;
   }
}