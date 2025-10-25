// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T05: Multiplication Tables.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Enter the number of tables you want to print: ");
         bool isValid = int.TryParse (ReadLine (), out int inp);
         if (isValid) {
            MultiplicationTables (inp);
            break;
         }
         WriteLine ("Invalid input. Try again.");
      }
   }

   // Function to print multiplication tables with header.
   static void MultiplicationTables (int tableNo) {
      // For printing multiplication number.
      for (int tabNo = 1; tabNo <= tableNo; tabNo++) {
         WriteLine ($"\n  Table {tabNo}\n");
         // For printing table number.
         for (int mulNo = 1; mulNo <= 10; mulNo++)
            WriteLine ($"{tabNo,3} * {mulNo,2} = {tabNo * mulNo}");
      }
   }
   #endregion
}
#endregion