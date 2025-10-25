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
         string? inp = ReadLine ()?.ToLower ().Trim ();
         if (string.IsNullOrWhiteSpace (inp)) continue;
         if (inp == "x") break;
         WriteLine (ReducedString (inp).Length == 0 ? "Everything is removed." : $"The resultant string for the given input {inp} is {ReducedString (inp)}\n");
      }
   }

   // Checks and removes the adjacent matching characters from the string.
   static string ReducedString (string inp) {
      for (int i = 0; i < inp.Length; i++) {
         if (i > 0 && inp[i] == inp[i - 1]) {
            inp = inp.Remove (i - 1, 2);
            i = 0;
         }
      }
      return inp;
   }
   #endregion
}
#endregion