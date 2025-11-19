// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T13: Sort and Swap Special Characters.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      char splLetter, orderType; string? input;
      while (true) {
         Write ("Enter letters (no numbers or special characters and no spaces): ");
         input = ReadLine ();
         if (!string.IsNullOrEmpty (input) && input.All (ch => char.IsLetter (ch))) {
            input = input.ToLower ();
            break;
         }
      }
      while (true) {
         Write ("\nPress a special letter (this will be moved to the end after sorting): ");
         splLetter = char.ToLower (ReadKey (intercept: true).KeyChar);
         if (char.IsLetter (splLetter)) break;
      }
      Write ($"{splLetter}\n");
      while (true) {
         Write ("\nPress sorting order (A = Ascending, D = Descending): ");
         orderType = char.ToUpper (ReadKey (intercept: true).KeyChar);
         if (orderType is 'A' or 'D') break;
      }
      WriteLine (orderType);
      Write ($"\nSorted output: {String.Concat (GetSortedList (input, splLetter, orderType))}");
   }

   // This method is used to sort list of letters in ascending or descending order and swap special letters to the last.
   static List<char> GetSortedList (string letters, char splLetter, char orderType) {
      var result = letters.Where (ch => ch != splLetter).ToList ();
      result.Sort ();
      if (orderType == 'D') result.Reverse ();
      int splLetterCount = letters.Length - result.Count;
      for (int i = 0; i < splLetterCount; i++) result.Add (splLetter);
      return result;
   }
   #endregion
}
#endregion