// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T03 //This code is used to find GCD and LCM of two numbers.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {


   public static int GCD (int a, int b) {
      int remainder;
      while (b != 0) {
         remainder = a % b;
         if (remainder == 1) return 1;
         if (remainder == 0) return b;
         a = b;
         b = remainder;
      }
      return a;}
   public static int LCM (int a, int b) {
      return ((a * b) / GCD (a, b));
   }
   static void Main (string[] args) {
      Console.WriteLine (" What two number you need to find GCD eg:10,5: ");
      string input = Console.ReadLine ();
      string[] num = input.Split (',');
      int a = int.Parse ((num[0]));
      int b = int.Parse ((num[1]));
      Console.WriteLine ($"The GCD of the given input {a},{b}is:"+GCD (a, b));
      Console.WriteLine ($"The LCM of the given input{a},{b}is:"+LCM (a, b));
   }
}