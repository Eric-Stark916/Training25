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
      for (int tabNo = 1; tabNo <= 10; tabNo++) {
         WriteLine ($"Multiplication table for {tabNo}:\n");
         for (int mulNo = 1; mulNo <= 10; mulNo++)
            WriteLine ($"{tabNo,2} * {mulNo,2} = {tabNo * mulNo}");
         WriteLine ();
      }
   }
   #endregion
}
#endregion