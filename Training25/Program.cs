// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T10: Reverse the String.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program ------------------------------------------------------------------------------
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
         Write ($"The reversed string for the given input \"{input}\" is: {IsUpper (input)}\n\n");
      }

      // Gives reversed string while maintaining the case and spaces.
      static string IsUpper (string input) {
         List<char> reversed = [.. new string ([.. input.Where (c => !char.IsWhiteSpace (c)).Reverse ()]).ToLower ()];
         string result = "";
         for (int i = 0; i < input.Length; i++) {
            if (char.IsUpper (input[i])) reversed[i] = char.ToUpper (reversed[i]);
            if (char.IsWhiteSpace (input[i])) reversed.Insert (i, ' ');
            result += reversed[i];
         }
         return result;
      }
   }
   #endregion
}
#endregion