// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T04: Chess Board.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      OutputEncoding = Encoding.UTF8;
      char[] bPieces = { '♜', '♞', '♝', '♛', '♚', '♝', '♞', '♜' };
      char[] wPieces = { '♖', '♘', '♗', '♕', '♔', '♗', '♘', '♖' };
      string line = "──────";
      string column = " │" + string.Join ("│", Enumerable.Repeat ("      ", 8)) + "│"; // Increasing each cells length.
      string mid = " ├" + string.Join ("┼", Enumerable.Repeat (line, 8)) + "┤"; // Connecting a row with another row.
      WriteLine (" ┌" + string.Join ("┬", Enumerable.Repeat (line, 8)) + "┐"); // Top Border.
      for (int r = 0; r < 8; r++) {
         WriteLine (column);
         if (r is 0 or 7 or 1 or 6) { // In these numbers the pieces exist.
            for (int c = 0; c < 8; c++) {
               char piece = r switch {
                  0 => bPieces[c],
                  1 => '♟',
                  6 => '♙',
                  7 => wPieces[c],
                  _ => ' ',
               };
               Write ($" │  {piece}  ");
               if (c == 7) WriteLine (" │");
            }
         } else WriteLine (column);
         WriteLine (column);
         if (r != 7) WriteLine (mid);
      }
      WriteLine (" └" + string.Join ("┴", Enumerable.Repeat (line, 8)) + "┘"); // Bottom Border.
   }
}