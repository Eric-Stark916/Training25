// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T09: Reduced String.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Enter characters to delete the matching adjacent pair or 'X' to exit: ");
         string? inp = ReadLine ()?.Trim ().ToLower ();
         if (string.IsNullOrWhiteSpace (inp)) continue;
         if (inp == "x") break;
         string result = GetReducedString (inp);
         WriteLine (result.Length == 0 ? "Empty string.\n" : $"The resultant string for the given input {inp} is: {result}\n");
      }
   }

   // Checks and removes the adjacent matching character pairs from the given string.
   static string GetReducedString (string inp) {
      string sortedInp = new (inp.OrderBy (x => x).ToArray ());
      int i = 0;
      while (i < sortedInp.Length - 1) {
         if (sortedInp[i] == sortedInp[i + 1]) sortedInp = sortedInp.Remove (i, 2);
         else i++;
      }
      return sortedInp;
   }
   #endregion
}
#endregion