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
         WriteLine ("Welcome to number conversion game. Choose mode: \n1. Words\n2. Roman Numerals");
         Write ("Enter your choice (1 or 2) or 'X' to exit: ");
         string? input = ReadLine ()?.Trim ().ToLower ();
         if (input == "x") break;
         if (!int.TryParse (input, out int choice) || choice != 1 && choice != 2) {
            WriteLine ("Invalid choice.");
            WriteLine ("---------------");
            continue;
         }
         (int min, int max) = choice == 1 ? (0, 9999999) : (1, 3999);
         Write ($"Enter a number between {min} and {max} to convert: ");
         bool invalid = !int.TryParse (ReadLine (), out int num) || num < min || num > max;
         WriteLine (invalid ? "Invalid input. Number must be with in the specified range." :
            choice == 1 ? $"The word representation of {num} is: {NumToWords (num)}" :
            $"The Roman numeral of {num} is: {NumToRomanNumeral (num)}");
         WriteLine ("---------------");
      }
   }

   // Converts an number (from 1 to 3999) into its Roman numeral representation.
   static string NumToRomanNumeral (int inp) {
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

   // Converts a number (from 1 to 9999999) into its word representation.
   static string NumToWords (int inp) {
      if (inp == 0) return "Zero";
      List<string> words = [ "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                             "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                             "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", "Thirty",
                             "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" ];
      StringBuilder result = new ();
      // For tens (21–99), no label needed
      var placeValues = new List<(string, int)> { ("Lakhs", 100000), ("Thousand", 1000),
                                                  ("Hundred", 100), ("", 10) };
      foreach (var (name, divisor) in placeValues) {
         int num = inp / divisor;
         if (num <= 0 || inp < 20) continue;
         result.Append (!string.IsNullOrEmpty (name) ? $"{NumToWords (num)} {name} " : words[18 + num] + " ");
         inp %= divisor;
         if (inp > 0) result.Append ($"{(divisor == 100 ? "and " : "")}");
      }
      if (inp > 0) result.Append (words[inp]);
      return result.ToString ().TrimEnd ();
   }
}