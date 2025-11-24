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
         Write ("Enter letters (without spaces) to remove the matching adjacent pair or 'X' to exit: ");
         string? inp = ReadLine ()?.Trim ().ToLower ();
         if (string.IsNullOrWhiteSpace (inp) || !inp.All (char.IsLetter)) continue;
         else if (inp == "x") break;
         string result = GetReducedString (inp);
         WriteLine (result.Length == 0 ? "Empty string.\n" : $"The resultant string for the given input {inp} : {result}\n");
      }
   }

   // Checks and removes the adjacent matching character pairs from the given string.
   static string GetReducedString (string inp) {
      var charStack = new Stack<char> ();
      foreach (char c in inp) {
         if (charStack.Count > 0 && charStack.Peek () == c) charStack.Pop ();
         else charStack.Push (c);
      }
      return new string (charStack.Reverse ().ToArray ());
   }
   #endregion
}
#endregion