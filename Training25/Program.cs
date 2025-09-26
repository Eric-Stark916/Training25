// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T07.//This code creates a Pascal's Triangle up to a specified number of rows.
// ------------------------------------------------------------------------------------------------
using System.Numerics;
namespace Training25;

internal class Program {
   /// <summary>This method is used to find out the factorial of a number</summary>
   static BigInteger Factorial (BigInteger number) {
      BigInteger count = 1; BigInteger result = number;
      if (number == 0 || (number == 1)) return 1;
      else while (count < number) result *= (number - count++);
      return result;
   }

   /// <summary>This method is used to find out the numbers in different position example(2,0),(2,1)</summary>
   /// <param name="number">It is the number of rows in a Pascal's Triangle</param>
   /// <param name="position">It is the coloumn for the Pascal's Triangle</param>
   static BigInteger PascalStructure (BigInteger number, BigInteger position) {
      return Factorial (number) / (Factorial (position) * Factorial (number - position));
   }

   static void Main (string[] args) {
      Console.WriteLine ("Enter number of rows required in Pascal's Triangle:");
      if (!int.TryParse (Console.ReadLine (), out int num) || num < 0 || num > 20) {
         Console.WriteLine ("Invalid Input");
         return;
      }
      for (int i = 0; i < num; i++) {
         for (int j = 0; j < num - i; j++) Console.Write (" ");//for spaces to form the triangle shape
         for (int k = 0; k <= i; k++) Console.Write (PascalStructure (i, k) + "  ");//to print the numbers in the triangle
         Console.WriteLine ();
      }
   }
}







