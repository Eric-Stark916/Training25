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
      while (true) {
         Write ("Enter the array of letters,special letters and order A or D each should be separated by comma or enter 'I' for information: ");
         List<string> words = [.. (ReadLine () ?? "").ToLower ().Split (',')];
         if (words[0] == "i")
            WriteLine ("\nThe input should be in the following order: abcd,c,d\n" +
                "Here, 'abcd' is the letters to be sorted.\n" +
                "'c' is the special letter that will not be included in the sorting process and will appear at the end.\n" +
                "'d' indicates descending order sorting, entering 'a' instead will sort in ascending order.\n" +
                "The output for the above input will look like this: \"d,b,a,c\".\n");
         else {
            if (words.Count != 3) {
               WriteLine ("\nPlease enter exactly 3 values separated by commas\n");
               continue;
            }
            if (words.Any (w => w.Any (c => char.IsDigit (c) || char.IsWhiteSpace (c)))) {
               WriteLine ("\nThere should be no number and space!\n");
               continue;
            }
            while (words[1].Length != 1 || !char.IsLetter (words[1][0])) {
               WriteLine ("\nOnly one special letter should be used!\n");
               Write ("Update the special letter: ");
               words[1] = (ReadLine () ?? "").ToLower ();
            }
            while (words[2] != "d" && words[2] != "a") {
               WriteLine ("\nThe order should either contain A or D.\n");
               Write ("Update the order: ");
               words[2] = (ReadLine () ?? "").ToLower ();
            }
            WriteLine ($"The resultant array: \"{GetSortedArray (words[0], words[1], words[2])}\"\n");
            break;
         }
      }
   }

   // This method is used to sort array of letters in ascending or descending order and swap special letters to the last.
   static string GetSortedArray (string words, string splChar, string order) {
      List<string> result = [];
      int count = 0;
      for (int i = 0; i < words.Length; i++) {
         if (words[i].ToString () != splChar)
            result.Add (words[i].ToString ());
         else count++;
      }
      if (order == "d") {
         result.Sort ();
         result.Reverse ();
      } else result.Sort ();
      result.AddRange (Enumerable.Repeat (splChar, count));
      return string.Join (",", result);
   }
   #endregion
}
#endregion