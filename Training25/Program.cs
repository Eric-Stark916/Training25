// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T05: Multiplication Tables 
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         WriteLine ("Enter the number of tables you want to print (max 100): ");
         bool isvalid = int.TryParse (ReadLine (), out int inp);
         if (isvalid && inp < 101) {// After 100, output is not in proper alignment
            Tables (inp);
            break;
         } else { WriteLine ("Invalid input"); }
      }
   }

   // Function to print multiplication tables with header
   static void Tables (int inpCol) {
      int row = 5;// Row limit
      // For starting new row of tables after row limit
      for (int col = 1; col <= inpCol; col += row) {
         WriteLine ();
         // For printing each table header
         for (int hed = col; hed < col + row && hed <= inpCol; hed++) {
            ForegroundColor = ConsoleColor.Cyan;
            Write ($"  [Tables {hed}]   ");// Spaces for alignment
            ResetColor ();
         }
         WriteLine ();
         WriteLine ();
         // For printing multiplication number
         for (int mulNo = 1; mulNo <= 10; mulNo++) {
            // For printing table number
            for (int tabNo = col; tabNo < col + row && tabNo <= inpCol; tabNo++)
               // Space at the starting is for alignment
               Write ($"  {mulNo,2} X {tabNo,-2} = {tabNo * mulNo,-3}");
            WriteLine ();
         }
         WriteLine ();
      }
   }
}