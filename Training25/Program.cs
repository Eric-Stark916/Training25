// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T02: Number to Words and Roman Numeral Converter.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         WriteLine ("Welcome to number conversion game. Choose mode: \n1. Words \n2. Roman Numerals");
         Write ("Enter your choice (1 or 2) or 'X' to close: ");
         string? input = ReadLine ();
         if (input == "x") break;
         if (!int.TryParse (input, out int choice) || choice != 1 && choice != 2) {
            WriteLine ("Invalid choice.");
            continue;
         }
         (int min, int max) = choice == 1 ? (0, 9999999) : (1, 3999);
         Write ($"Enter a number between {min} and {max} to convert: ");
         bool inValid = !int.TryParse (ReadLine (), out int num) || num < min || num > max;
         WriteLine (inValid ? "Invalid input. Number must be with in the specified range." :
            choice == 1 ? $"The word representation for the given input {num} is: {NumToWords (num)}" :
            $"The Roman numeral for the given input {num} is: {RomNumConv (num)}");
         WriteLine ("---------------");
      }
   }

   // Converts a number (from 1 to 9999999) into its word representation.
   static string NumToWords (int inp) {
      if (inp == 0) return "Zero";
      List<string> words = [ "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                             "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                             "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", "Thirty", 
                             "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" ];
      StringBuilder result = new ();
      int lakh = 100000, thousand = 1000, hundred = 100, ten = 10, zero = 0;
      int hundreds = 0, lakhs = 0, thousands = 0;
      AddWord (lakhs, "Lakhs", lakh);
      AddWord (thousands, "Thousand", thousand);
      AddWord (hundreds, "Hundred", hundred);
      if (inp > 20) {
         result.Append (words[18 + (inp / ten)]);
         inp %= ten;
         // For numbers like 21, 32, 43 etc.
         if (inp > zero) result.Append (" " + words[inp]);
      }
      // For numbers from 1 to 20
      else if (inp > zero) result.Append (words[inp]);
      return result.ToString ();

      // Helper-----------------------------------------
      void AddWord (int num, string word, int div) {
         num = inp / div;
         if (num > zero) {
            result.Append ($"{NumToWords (num)} {word}");
            inp %= div;
            if (inp > zero && div == hundred) result.Append (" and ");
            else if (inp > zero) result.Append (' ');
         }
      }
   }

   // Converts an number (from 1 to 3999) into its Roman numeral representation.
   static string RomNumConv (int inp) {
      StringBuilder result = new ();
      var romNum = new List<(int, string)> {
                 (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
                  (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
                   (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
      };
      foreach (var (num, rom) in romNum) {
         while (inp >= num) {
            result.Append (rom);
            inp -= num;
         }
      }
      return result.ToString ();
   }
}