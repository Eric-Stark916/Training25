// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T09: Reduced String.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training25;

internal class Program {

   static void Main () {
      while (true) {
         Write ("Enter characters to delete the matching adjacent character: ");
         string? inp = ReadLine ();
         if (string.IsNullOrEmpty (inp)) continue;
         WriteLine ($"The reduced string for the given input {inp} is {ReducedString (inp)}\n");
      }

      // Checks and removes the adjacent matching characters from the string.
      static string ReducedString (string inp) {
         StringBuilder chars = new (inp);
         for (int i = 0; i < chars.Length; i++) {
            if (i > 0 && chars[i] == chars[i - 1]) {
               chars.Remove (i, 1);
               i = 0;
            }
         }
         return chars.ToString ();
      }
   }
}