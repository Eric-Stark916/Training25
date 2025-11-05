// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T12: Voting Contest.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
internal class Program {
   #region Implementation -------------------------------------------
   static void Main () {
      while (true) {
         Write ("Cast your votes to any characters or 'X' to exit: ");
         var inp = ReadLine ()?.Trim ().ToLower ();
         if (inp == "x") break;
         if (!string.IsNullOrEmpty (inp))
            WriteLine ($"The winner of the voting contest is: {GetWinner (inp)}");
         WriteLine ();
      }
   }

   // Returns the winner character based on maximum votes.
   static char GetWinner (string input) {
      int currentWinner = 0;
      char winner = ' ';
      Dictionary<char, int> charVotes = [];
      foreach (var chars in input) {
         // Stores the character with default value 1.
         charVotes[chars] = charVotes.GetValueOrDefault (chars, 0) + 1;
         // In case of tie, the first character with maximum votes is considered as winner.
         if (charVotes.Values.Max () > currentWinner) {
            currentWinner = charVotes.Values.Max ();
            winner = chars;
         }
      }
      return winner;
   }
   #endregion
}
#endregion