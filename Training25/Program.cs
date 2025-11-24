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
         bool isInvalid = string.IsNullOrEmpty (input) || input.Any (ch => !char.IsLetterOrDigit (ch)
                                                                        && !char.IsWhiteSpace (ch));
         if (isInvalid) {
            WriteLine ("Invalid input.\n");
            continue;
         } else if (input?.ToLower () == "x") break;
         WriteLine ($"The reversed string for the given input \"{input}\" is: {GetReversed (input!)}\n");
      }
   }

   // Gives reversed string while maintaining the case and spaces.
   static string GetReversed (string inp) {
      int inpLength = inp.Length;
      char[] output = new char[inpLength];
      int revIndex = inpLength - 1;
      for (int i = 0; i < inpLength; i++) {
         char inpChar = inp[i];
         if (char.IsWhiteSpace (inpChar)) output[i] = ' ';
         else {
            while (!char.IsLetterOrDigit (inp[revIndex])) revIndex--;
            char revChar = inp[revIndex];
            output[i] = char.IsUpper (inpChar) ? char.ToUpper (revChar) : char.ToLower (revChar);
            revIndex--;
         }
      }
      return new string (output);
   }
   #endregion
}
#endregion