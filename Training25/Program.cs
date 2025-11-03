// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T10: Reverse the String.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Enter words or numbers to get a reversed one or enter 'X' to exit: ");
         var input = ReadLine ();
         if (input?.ToLower () == "x") break;
         if (string.IsNullOrWhiteSpace (input)) {
            WriteLine ("Invalid input.\n");
            continue;
         }
         WriteLine ($"The reversed string for the given input \"{input}\" is: {GetReversed (input)}\n");
      }

      // Gives reversed string while maintaining the case and spaces.
      static string GetReversed (string inp) {
         List<char> inpChars = [.. inp.Replace (" ", "").ToLower ()];
         inpChars.Reverse ();
         for(int i= 0;i<inp.Length; i++) {
            if (char.IsUpper (inp[i])) inpChars[i] = char.ToUpper (inpChars[i]);
            if (char.IsWhiteSpace (inp[i])) inpChars.Insert (i, ' ');
         }
         return new string ([.. inpChars]);
      }
   }
   #endregion
}
#endregion