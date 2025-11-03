// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
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
                "Here 'abcd' is the letters we are going to sort\n" +
                "'c' is the special letter, which we don't want to get involved in sorting,and it will be displayed at the end.\n" +
                "'d' denotes descending order sorting, in place of 'd' entering 'a' denotes ascending order sorting.\n" +
                "The output for the above input will look like this \"d,b,a,c\".\n");
         if (words.Count != 3) {
            WriteLine ("\nPlease enter exactly 3 values separated by commas\n");
            continue;
         }
         if (words.Any (w => w.Any (c => char.IsDigit (c) || char.IsWhiteSpace (c)))) {
            WriteLine ("\nThere should be no numbers and space!\n");
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

   // This method is used to sort array of letters in ascending or descending order and swap special letters to the last.
   static string GetSortedArray (string words, string splChar, string order) {
      List<string> list = [];
      for (int i = 0; i < words.Length; i++) {
         if (words[i].ToString () != splChar)
            list.Add (words[i].ToString ());
      }
      if (order == "d") {
         list.Sort ();
         list.Reverse ();
      } else list.Sort ();
      for (int i = 0; i < list.Count; i++) {
         if (words[i].ToString () == splChar) list.Add (splChar);
      }
      return string.Join (",", list);
   }
   #endregion
}
#endregion