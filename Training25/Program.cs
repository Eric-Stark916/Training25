// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch Test02: EXCEL COLUMN NAME GENERATOR.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Enter the number to get the equivalent excel column name or 'X' to exit: ");
         string? input = ReadLine ();
         if(input?.ToLower()=="x") break;
         bool isValid = int.TryParse (input, out int valNum) && valNum > 0 && valNum<16385;
         if (isValid) {
            WriteLine ($"The equivalent excel column cell for the given input '{valNum}' is: {GetExcelColumnName (valNum)}\n");
            continue;
         } 
         WriteLine ("Invalid input.\n");
      }
   }

   // Converts the given number to excel column name.
   static string GetExcelColumnName (int inp) {
      List<char> chars = 
      ['A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
      string result = "";
      while (inp > 0) {
         int rem = (inp - 1) % 26;
         result=chars[rem]+result;
         inp = (inp - 1) / 26;
      }
      return result;
   }
   #endregion
}
#endregion