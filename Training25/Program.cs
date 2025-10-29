// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch Test03: MAGIC SQUARE (3 X 3) .
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main () {
      List<int> magicSquare = [];
      for (int i = 1; i < 4; i++) {
         for (int j = 1; j < 4; j++) {
            Console.WriteLine ($"Enter the number for{i}x{j}:");
            bool isValidInput = int.TryParse (Console.ReadLine (), out int number);
            if (isValidInput) {
               magicSquare.Add(number);
               Console.Clear ();

            } else {
               Console.WriteLine ("Invalid input. Please enter an integer.");
               j--;
            }
         }
      }
      MagicSquare (magicSquare);
   }

   static void MagicSquare (List<int> inp) {
      int a = inp[0]+inp[1]+inp[2];
      int b = inp[3]+inp[4]+inp[5];
      int c = inp[6]+inp[7]+inp[8];
      int d = inp[0] + inp[3] + inp[6];
      int e = inp[1] + inp[4] + inp[7];
      int f = inp[2] + inp[5] + inp[8];
      if(a==b && b==c && c==d && d==e && e==f) {
         Console.WriteLine ("The entered numbers form a Magic Square.");
      } else {
         Console.WriteLine ("The entered numbers do not form a Magic Square.");

      }
   }
}